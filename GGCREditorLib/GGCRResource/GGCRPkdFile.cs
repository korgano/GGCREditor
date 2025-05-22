using GGCREditorLib.GGCRResource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// Represents a PKD archive file and provides methods to inspect and modify its inner files.
    /// </summary>
    public class GGCRPkdFile : GGCRResourceFile
    {
        public GGCRPkdFile(string filePath)
            : base(filePath)
        {
 //           Logger.Log($"Opened PKD file: {filePath}");
        }

        /// <summary>
        /// Finds and returns an inner file by name, or null if not found.
        /// </summary>
        public GGCRPkdInnerFile GetInnerFile(string name)
        {
 //           Logger.Log($"Searching for inner file '{name}'.");
            try
            {
                var all = ListInnerFiles();
                foreach (GGCRPkdInnerFile inner in all)
                {
                    if (inner.FileName == name)
                    {
//                        Logger.Log($"Found inner file '{name}' at index {inner.StartIndex}.");
                        return inner;
                    }
                }
//                Logger.Log($"Inner file '{name}' not found.");
                return null;
            }
            catch (Exception ex)
            {
//                Logger.Error($"Error in GetInnerFile('{name}')", ex);
                throw;
            }
        }

        /// <summary>
        /// Lists all inner files in the PKD, reading file count, header length, and filenames.
        /// </summary>
        public List<GGCRPkdInnerFile> ListInnerFiles()
        {
//            Logger.Log("Listing all inner files.");
            try
            {
                // Number of inner files
                int count = BitConverter.ToInt32(this.Data, 8);

                // Total header length (excluding trailing 0x00)
                int headLength = BitConverter.ToInt32(this.Data, 16) - 1;

                // Start position of concatenated filenames
                int namesOffset = 20 + count * 12;
                int namesLength = headLength - count * 12;

                // Extract raw filename bytes
                byte[] nameBytes = new byte[namesLength];
                Buffer.BlockCopy(this.Data, namesOffset, nameBytes, 0, namesLength);

                // Split UTF-8 zero‐terminated strings
                string[] allNames = Encoding.UTF8.GetString(nameBytes).Split('\0');

                var result = new List<GGCRPkdInnerFile>(count);
                for (int i = 0; i < count; i++)
                {
                    var f = new GGCRPkdInnerFile
                    {
                        FileName = allNames.Length > i ? allNames[i] : string.Empty,
                        StartIndex = BitConverter.ToInt32(this.Data, 20 + 12 * i),
                        StartIndexLocation = 20 + 12 * i
                    };
                    result.Add(f);
                }

//                Logger.Log($"Found {result.Count} inner files.");
                return result;
            }
            catch (Exception ex)
            {
//                Logger.Error("Error in ListInnerFiles()", ex);
                throw;
            }
        }

        /// <summary>
        /// Inserts new data into a specific inner file at the given offset,
        /// then shifts all subsequent inner‐file start indices forward.
        /// </summary>
        public void AppendInnerFile(GGCRPkdInnerFile file, int insertOffset, byte[] data)
        {
//            Logger.Log($"Appending {data.Length} bytes to '{file?.FileName}' at offset {insertOffset}.");
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                var all = ListInnerFiles();
                foreach (var next in all)
                {
                    if (next.StartIndex > file.StartIndex)
                    {
                        int newStart = next.StartIndex + data.Length;
                        byte[] bytes = BitConverter.GetBytes(newStart);
                        // Overwrite start index in header
                        Buffer.BlockCopy(bytes, 0, this.Data, next.StartIndexLocation, bytes.Length);
//                        Logger.Log($"Adjusted start of '{next.FileName}' to {newStart}.");
                    }
                }

                // Insert new data block
                this.Insert(file.StartIndex + insertOffset, data);
//                Logger.Log($"Inserted data into '{file.FileName}'.");
            }
            catch (Exception ex)
            {
 //               Logger.Error($"Error in AppendInnerFile('{file.FileName}')", ex);
                throw;
            }
        }

        /// <summary>
        /// Deletes a block of bytes from a specific inner file at the given position (absolute to PKD header),
        /// then shifts subsequent inner‐file start indices backward.
        /// </summary>
        public void DeleteInnerFile(GGCRPkdInnerFile file, int deletePosition, int length)
        {
//            Logger.Log($"Deleting {length} bytes from '{file?.FileName}' at position {deletePosition}.");
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                var all = ListInnerFiles();
                foreach (var next in all)
                {
                    if (next.StartIndex > file.StartIndex)
                    {
                        int newStart = next.StartIndex - length;
                        byte[] bytes = BitConverter.GetBytes(newStart);
                        Buffer.BlockCopy(bytes, 0, this.Data, next.StartIndexLocation, bytes.Length);
//                        Logger.Log($"Adjusted start of '{next.FileName}' to {newStart}.");
                    }
                }

                // Remove data block
                this.Delete(deletePosition, length);
//                Logger.Log($"Deleted data from '{file.FileName}'.");
            }
            catch (Exception ex)
            {
//                Logger.Error($"Error in DeleteInnerFile('{file.FileName}')", ex);
                throw;
            }
        }
    }
}