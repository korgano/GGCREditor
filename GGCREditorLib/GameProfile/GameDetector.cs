using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib.GameProfile
{
    public class GameDetector
    {
        public class DetectionResult
        {
            public IGGCGameProfile Profile { get; set; }
            public int Confidence { get; set; }
            public string Reason { get; set; }
        }

        public static DetectionResult Detect(string dataPath)
        {
            if (string.IsNullOrEmpty(dataPath) || !Directory.Exists(dataPath))
            {
                return null;
            }

            List<IGGCGameProfile> profiles = GameProfileManager.Instance.GetAllProfiles();
            List<DetectionResult> candidates = new List<DetectionResult>();

            foreach (IGGCGameProfile profile in profiles)
            {
                DetectionResult result = AnalyzePath(dataPath, profile);
                if (result != null && result.Confidence > 0)
                {
                    candidates.Add(result);
                }
            }

            if (candidates.Count == 0)
            {
                IGGCGameProfile defaultProfile = GameProfileManager.Instance.GetDefaultProfile();
                return new DetectionResult
                {
                    Profile = defaultProfile,
                    Confidence = 0,
                    Reason = "No matching profile found, using default"
                };
            }

            candidates.Sort((a, b) => b.Confidence.CompareTo(a.Confidence));
            return candidates[0];
        }

        private static DetectionResult AnalyzePath(string dataPath, IGGCGameProfile profile)
        {
            int confidence = 0;
            List<string> reasons = new List<string>();

            string machineFilePath = dataPath;
            if (profile.RequiresResidentFolder)
            {
                machineFilePath = Path.Combine(dataPath, "resident");
            }
            machineFilePath = Path.Combine(machineFilePath, GetMachineFileName(profile));

            if (!File.Exists(machineFilePath))
            {
                return new DetectionResult
                {
                    Profile = profile,
                    Confidence = 0,
                    Reason = "Machine file not found: " + machineFilePath
                };
            }

            confidence += 20;
            reasons.Add("Machine file exists");

            try
            {
                byte[] data = File.ReadAllBytes(machineFilePath);
                List<string> innerFiles = GetInnerFileNames(data);

                if (innerFiles.Count > 0)
                {
                    confidence += 10;
                    reasons.Add("Valid PKD structure");

                    if (profile.GameId == "cross_rays")
                    {
                        if (innerFiles.Contains("MachineSpecList.cdb") &&
                            innerFiles.Contains("WeaponSpecList.cdb") &&
                            innerFiles.Contains("MachineConversionList.cdb"))
                        {
                            confidence += 50;
                            reasons.Add("Cross Rays signature match");
                        }
                    }
                    else if (profile.GameId == "genesis")
                    {
                        if (innerFiles.Contains("MachineSpecList.cdb") &&
                            innerFiles.Contains("WeaponSpecList.cdb"))
                        {
                            confidence += 50;
                            reasons.Add("Genesis signature match");
                        }

                        if (innerFiles.Contains("MachineGrowthList.cdb"))
                        {
                            confidence += 10;
                            reasons.Add("Genesis-specific file found");
                        }
                    }
                }

                string masterPath = dataPath;
                if (profile.RequiresResidentFolder)
                {
                    masterPath = Path.Combine(dataPath, "resident");
                }
                masterPath = Path.Combine(masterPath, GetMasterFileName(profile));

                if (File.Exists(masterPath))
                {
                    confidence += 10;
                    reasons.Add("Master file exists");
                }

                string abilityPath = dataPath;
                if (profile.RequiresResidentFolder)
                {
                    abilityPath = Path.Combine(dataPath, "resident");
                }
                abilityPath = Path.Combine(abilityPath, GetAbilityFileName(profile));

                if (File.Exists(abilityPath))
                {
                    confidence += 10;
                    reasons.Add("Ability file exists");
                }
            }
            catch (Exception)
            {
                return new DetectionResult
                {
                    Profile = profile,
                    Confidence = 0,
                    Reason = "Error reading game files"
                };
            }

            return new DetectionResult
            {
                Profile = profile,
                Confidence = confidence,
                Reason = string.Join(", ", reasons.ToArray())
            };
        }

        private static List<string> GetInnerFileNames(byte[] data)
        {
            List<string> names = new List<string>();

            if (data.Length < 20)
            {
                return names;
            }

            try
            {
                int count = BitConverter.ToInt32(data, 8);
                int headerLength = BitConverter.ToInt32(data, 16) - 1;

                if (count <= 0 || headerLength <= 0 || data.Length < 20 + count * 12)
                {
                    return names;
                }

                int namesOffset = 20 + count * 12;
                int namesLength = headerLength - count * 12;

                if (namesLength <= 0 || data.Length < namesOffset + namesLength)
                {
                    return names;
                }

                byte[] nameBytes = new byte[namesLength];
                Array.Copy(data, namesOffset, nameBytes, 0, namesLength);

                string[] allNames = Encoding.UTF8.GetString(nameBytes).Split('\0');
                foreach (string name in allNames)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        names.Add(name);
                    }
                }
            }
            catch
            {
            }

            return names;
        }

        private static string GetMachineFileName(IGGCGameProfile profile)
        {
            return "MachineSpecList.pkd";
        }

        private static string GetMasterFileName(IGGCGameProfile profile)
        {
            return "CharacterSpecList.pkd";
        }

        private static string GetAbilityFileName(IGGCGameProfile profile)
        {
            return "AbilitySpecList.cdb";
        }
    }
}