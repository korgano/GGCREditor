using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using GGCREditor;

namespace GGCREditorLib.GameProfile
{
    public class ProfileLoader
    {
        private static readonly string ProfileFolder;

        static ProfileLoader()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string libDir = Path.Combine(baseDir, "GGCREditorLib");
            ProfileFolder = Path.Combine(libDir, "GameProfile");

            if (!Directory.Exists(ProfileFolder))
            {
                ProfileFolder = Path.Combine(baseDir, "GameProfile");
            }
        }

        public static List<IGGCGameProfile> LoadAllProfiles()
        {
            List<IGGCGameProfile> profiles = new List<IGGCGameProfile>();

            if (!Directory.Exists(ProfileFolder))
            {
                return profiles;
            }

            string[] xmlFiles = Directory.GetFiles(ProfileFolder, "*.xml");
            foreach (string file in xmlFiles)
            {
                try
                {
                    IGGCGameProfile profile = LoadProfile(file);
                    if (profile != null)
                    {
                        profiles.Add(profile);
                    }
                }
                catch
                {
                }
            }

            return profiles;
        }

        public static IGGCGameProfile LoadProfile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode root = doc.SelectSingleNode("GameProfile");
            if (root == null)
            {
                return null;
            }

            return ParseProfile(root);
        }

        public static IGGCGameProfile LoadProfileById(string gameId)
        {
            List<IGGCGameProfile> profiles = LoadAllProfiles();
            foreach (IGGCGameProfile profile in profiles)
            {
                if (profile.GameId == gameId)
                {
                    return profile;
                }
            }
            return null;
        }

        private static IGGCGameProfile ParseProfile(XmlNode root)
        {
            string gameId = GetNodeText(root, "GameId");
            string gameName = GetNodeText(root, "GameName");

            if (string.IsNullOrEmpty(gameId))
            {
                return null;
            }

            XmlNode dataStructures = root.SelectSingleNode("DataStructures");
            XmlNode filePaths = root.SelectSingleNode("FilePaths");
            XmlNode innerFiles = root.SelectSingleNode("InnerFiles");
            XmlNode languageFolder = root.SelectSingleNode("LanguageFolder");
            XmlNode languageFiles = root.SelectSingleNode("LanguageFiles");

            return new XmlGameProfile
            {
                GameId = gameId,
                GameName = gameName,
                MasterLength = GetIntValue(dataStructures, "MasterLength", 112),
                MasterUIDLength = GetIntValue(dataStructures, "MasterUIDLength", 8),
                GundamLength = GetIntValue(dataStructures, "GundamLength", 108),
                GundamUIDLength = GetIntValue(dataStructures, "GundamUIDLength", 8),
                WeaponLength = GetIntValue(dataStructures, "WeaponLength", 36),
                WeaponUIDLength = GetIntValue(dataStructures, "WeaponUIDLength", 10),
                GundamAbilityStart = GetIntValue(dataStructures, "GundamAbilityStart", 48),
                GundamAbilityLength = GetIntValue(dataStructures, "GundamAbilityLength", 16),
                PeopleAbilityLength = GetIntValue(dataStructures, "PeopleAbilityLength", 40),
                OPAbilityLength = GetIntValue(dataStructures, "OPAbilityLength", 60),
                WarAbilityLength = GetIntValue(dataStructures, "WarAbilityLength", 14),
                XiaoGuoLength = GetIntValue(dataStructures, "XiaoGuoLength", 132),
                ResidentFolder = GetNodeText(filePaths, "ResidentFolder"),
                MachineFileName = GetNodeText(filePaths, "MachineFile"),
                MasterFileName = GetNodeText(filePaths, "MasterFile"),
                AbilityFileName = GetNodeText(filePaths, "AbilityFile"),
                SpecProfileFileName = GetNodeText(filePaths, "SpecProfileFile"),
                GundamCdbName = GetNodeText(innerFiles, "GundamCdb", "MachineSpecList.cdb"),
                WeaponCdbName = GetNodeText(innerFiles, "WeaponCdb", "WeaponSpecList.cdb"),
                MasterCdbName = GetNodeText(innerFiles, "MasterCdb", "CharacterSpecList.cdb"),
                ConversionCdbName = GetNodeText(innerFiles, "ConversionCdb", "MachineConversionList.cdb"),
                SeriesCdbName = GetNodeText(innerFiles, "SeriesCdb", "SeriesList.cdb"),
                LanguageFolderName = languageFolder != null ? languageFolder.InnerText : "language",
                MachineTxtName = GetNodeText(languageFiles, "MachineTxt", "MachineSpecList.tbl"),
                MasterTxtName = GetNodeText(languageFiles, "MasterTxt", "CharacterSpecList.tbl"),
                AbilityTxtName = GetNodeText(languageFiles, "AbilityTxt", "AbilitySpecList.tbl")
            };
        }

        private static string GetNodeText(XmlNode parent, string nodeName, string defaultValue = "")
        {
            if (parent == null)
            {
                return defaultValue;
            }
            XmlNode node = parent.SelectSingleNode(nodeName);
            return node != null ? node.InnerText : defaultValue;
        }

        private static int GetIntValue(XmlNode parent, string nodeName, int defaultValue)
        {
            string text = GetNodeText(parent, nodeName);
            if (int.TryParse(text, out int result))
            {
                return result;
            }
            return defaultValue;
        }

        private class XmlGameProfile : IGGCGameProfile
        {
            public string GameId { get; set; }
            public string GameName { get; set; }
            public string GamePath { get; set; }

            public int MasterLength { get; set; }
            public int MasterUIDLength { get; set; }
            public int GundamLength { get; set; }
            public int GundamUIDLength { get; set; }
            public int WeaponLength { get; set; }
            public int WeaponUIDLength { get; set; }
            public int GundamAbilityStart { get; set; }
            public int GundamAbilityLength { get; set; }
            public int PeopleAbilityLength { get; set; }
            public int OPAbilityLength { get; set; }
            public int WarAbilityLength { get; set; }
            public int XiaoGuoLength { get; set; }

            public string ResidentFolder { get; set; }
            public string MachineFileName { get; set; }
            public string MasterFileName { get; set; }
            public string AbilityFileName { get; set; }
            public string SpecProfileFileName { get; set; }

            public string GundamCdbName { get; set; }
            public string WeaponCdbName { get; set; }
            public string MasterCdbName { get; set; }
            public string ConversionCdbName { get; set; }
            public string SeriesCdbName { get; set; }

            public string LanguageFolderName { get; set; }
            public string MachineTxtName { get; set; }
            public string MasterTxtName { get; set; }
            public string AbilityTxtName { get; set; }

            public string MachineFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    string folder = string.IsNullOrEmpty(ResidentFolder) ? "" : ResidentFolder + "\\";
                    return GamePath + "\\" + folder + MachineFileName;
                }
            }

            public string MasterFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    string folder = string.IsNullOrEmpty(ResidentFolder) ? "" : ResidentFolder + "\\";
                    return GamePath + "\\" + folder + MasterFileName;
                }
            }

            public string AbilityFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    string folder = string.IsNullOrEmpty(ResidentFolder) ? "" : ResidentFolder + "\\";
                    return GamePath + "\\" + folder + AbilityFileName;
                }
            }

            public string SpecProfileFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    string folder = string.IsNullOrEmpty(ResidentFolder) ? "" : ResidentFolder + "\\";
                    return GamePath + "\\" + folder + SpecProfileFileName;
                }
            }

            public string MachineTxtFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    return GamePath + "\\" + LanguageFolderName + "\\" + GGCRStaticConfig.Language + "\\" + MachineTxtName;
                }
            }

            public string MasterTxtFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    return GamePath + "\\" + LanguageFolderName + "\\" + GGCRStaticConfig.Language + "\\" + MasterTxtName;
                }
            }

            public string AbilityTxtFile
            {
                get
                {
                    if (string.IsNullOrEmpty(GamePath))
                    {
                        return "";
                    }
                    return GamePath + "\\" + LanguageFolderName + "\\" + GGCRStaticConfig.Language + "\\" + AbilityTxtName;
                }
            }

            public string LanguageFolder
            {
                get { return LanguageFolderName; }
            }

            public bool RequiresResidentFolder
            {
                get { return !string.IsNullOrEmpty(ResidentFolder); }
            }
        }
    }
}