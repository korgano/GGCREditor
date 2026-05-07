using System;

namespace GGCREditorLib.GameProfile
{
    public static class GameContext
    {
        private static bool _initialized = false;

        public static void Initialize()
        {
            if (_initialized)
            {
                return;
            }

            GameProfileManager.Instance.GetDefaultProfile();
            _initialized = true;
        }

        public static IGGCGameProfile ActiveProfile
        {
            get
            {
                Initialize();
                return GameProfileManager.Instance.GetActiveProfile();
            }
        }

        public static string CurrentGameId
        {
            get
            {
                IGGCGameProfile profile = ActiveProfile;
                return profile != null ? profile.GameId : "cross_rays";
            }
        }

        public static string CurrentGameName
        {
            get
            {
                IGGCGameProfile profile = ActiveProfile;
                return profile != null ? profile.GameName : "Unknown";
            }
        }

        public static int MasterLength
        {
            get { return ActiveProfile.MasterLength; }
        }

        public static int MasterUIDLength
        {
            get { return ActiveProfile.MasterUIDLength; }
        }

        public static int GundamLength
        {
            get { return ActiveProfile.GundamLength; }
        }

        public static int GundamUIDLength
        {
            get { return ActiveProfile.GundamUIDLength; }
        }

        public static int WeaponLength
        {
            get { return ActiveProfile.WeaponLength; }
        }

        public static int WeaponUIDLength
        {
            get { return ActiveProfile.WeaponUIDLength; }
        }

        public static int GundamAbilityStart
        {
            get { return ActiveProfile.GundamAbilityStart; }
        }

        public static int GundamAbilityLength
        {
            get { return ActiveProfile.GundamAbilityLength; }
        }

        public static int PeopleAbilityLength
        {
            get { return ActiveProfile.PeopleAbilityLength; }
        }

        public static int OPAbilityLength
        {
            get { return ActiveProfile.OPAbilityLength; }
        }

        public static int WarAbilityLength
        {
            get { return ActiveProfile.WarAbilityLength; }
        }

        public static int XiaoGuoLength
        {
            get { return ActiveProfile.XiaoGuoLength; }
        }

        public static string MachineFile
        {
            get { return ActiveProfile.MachineFile; }
        }

        public static string MasterFile
        {
            get { return ActiveProfile.MasterFile; }
        }

        public static string AbilityFile
        {
            get { return ActiveProfile.AbilityFile; }
        }

        public static string SpecProfileFile
        {
            get { return ActiveProfile.SpecProfileFile; }
        }

        public static string MachineTxtFile
        {
            get { return ActiveProfile.MachineTxtFile; }
        }

        public static string MasterTxtFile
        {
            get { return ActiveProfile.MasterTxtFile; }
        }

        public static string AbilityTxtFile
        {
            get { return ActiveProfile.AbilityTxtFile; }
        }

        public static void SetGamePath(string path)
        {
            IGGCGameProfile profile = ActiveProfile;
            if (profile != null)
            {
                profile.GamePath = path;
            }
        }

        public static void SetActiveProfile(IGGCGameProfile profile)
        {
            GameProfileManager.Instance.SetActiveProfile(profile);
        }

        public static void SetActiveProfileById(string gameId)
        {
            GameProfileManager.Instance.SetActiveProfileById(gameId);
        }

        public static bool RequiresResidentFolder
        {
            get { return ActiveProfile.RequiresResidentFolder; }
        }
    }
}