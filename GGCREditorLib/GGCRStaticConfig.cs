using System;
using System.Collections.Generic;
using System.Text;
using GGCREditorLib.GameProfile;

namespace GGCREditor
{
    public class GGCRStaticConfig
    {
        /// <summary>
        /// 系列单条长度
        /// </summary>
        public static int SeriesLength = 12;

        /// <summary>
        /// 驾驶员单条数据长度
        /// </summary>
        public static int MasterLength = 112;
        public static int MasterUIDLength = 8;

        /// <summary>
        /// 机体单条数据长度
        /// </summary>
        public static int GundamLength = 108;
        public static int GundamUIDLength = 8;

        /// <summary>
        /// 武器单条数据长度
        /// </summary>
        public static int WeaponLength = 36;
        public static int WeaponUIDLength = 10;

        public static int GundamAbilityStart = 48;

        public static int GundamAbilityLength = 16; //alycecil value = 8

        public static int PeopleAbilityLength = 40; //alycecil value = 34

        public static int OPAbilityLength = 60; //alycecil value = 40

        public static int WarAbilityLength = 14;

        public static int XiaoGuoLength = 132;
        public static int GundamAbilityCount;
        public static int OPCount;

        /// <summary>
        /// 当前data目录
        /// </summary>
        public static string PATH { get; set; }

        public static string Language { get; set; }

        public static string MachineFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.MachineFile))
                {
                    return profile.MachineFile;
                }
                return PATH + "\\resident\\MachineSpecList.pkd";
            }
        }

        public static string MasterFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.MasterFile))
                {
                    return profile.MasterFile;
                }
                return PATH + "\\resident\\CharacterSpecList.pkd";
            }
        }

        public static string AbilityFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.AbilityFile))
                {
                    return profile.AbilityFile;
                }
                return PATH + "\\resident\\AbilitySpecList.cdb";
            }
        }

        public static string SpecProfileFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.SpecProfileFile))
                {
                    return profile.SpecProfileFile;
                }
                return PATH + "\\resident\\SpecProfileList.cdb";
            }
        }

        public static string AbilityTxtFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.AbilityTxtFile))
                {
                    return profile.AbilityTxtFile;
                }
                return PATH + @"\language\" + GGCRStaticConfig.Language + @"\AbilitySpecList.tbl";
            }
        }

        public static string MachineTxtFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.MachineTxtFile))
                {
                    return profile.MachineTxtFile;
                }
                return PATH + @"\language\" + GGCRStaticConfig.Language + @"\MachineSpecList.tbl";
            }
        }

        public static string MasterTxtFile
        {
            get
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile != null && !string.IsNullOrEmpty(profile.MasterTxtFile))
                {
                    return profile.MasterTxtFile;
                }
                return PATH + @"\language\" + GGCRStaticConfig.Language + @"\CharacterSpecList.tbl";
            }
        }

        public static void SyncWithActiveProfile()
        {
            try
            {
                IGGCGameProfile profile = GameContext.ActiveProfile;
                if (profile == null)
                {
                    return;
                }

                MasterLength = profile.MasterLength;
                MasterUIDLength = profile.MasterUIDLength;
                GundamLength = profile.GundamLength;
                GundamUIDLength = profile.GundamUIDLength;
                WeaponLength = profile.WeaponLength;
                WeaponUIDLength = profile.WeaponUIDLength;
                GundamAbilityStart = profile.GundamAbilityStart;
                GundamAbilityLength = profile.GundamAbilityLength;
                PeopleAbilityLength = profile.PeopleAbilityLength;
                OPAbilityLength = profile.OPAbilityLength;
                WarAbilityLength = profile.WarAbilityLength;
                XiaoGuoLength = profile.XiaoGuoLength;
            }
            catch
            {
            }
        }

    }
}
