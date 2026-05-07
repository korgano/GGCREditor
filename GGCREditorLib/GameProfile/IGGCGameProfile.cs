using System;

namespace GGCREditorLib.GameProfile
{
    public interface IGGCGameProfile
    {
        string GameId { get; }
        string GameName { get; }
        string GamePath { get; set; }

        int MasterLength { get; }
        int MasterUIDLength { get; }
        int GundamLength { get; }
        int GundamUIDLength { get; }
        int WeaponLength { get; }
        int WeaponUIDLength { get; }
        int GundamAbilityStart { get; }
        int GundamAbilityLength { get; }
        int PeopleAbilityLength { get; }
        int OPAbilityLength { get; }
        int WarAbilityLength { get; }
        int XiaoGuoLength { get; }

        string MachineFile { get; }
        string MasterFile { get; }
        string AbilityFile { get; }
        string SpecProfileFile { get; }

        string MachineTxtFile { get; }
        string MasterTxtFile { get; }
        string AbilityTxtFile { get; }

        string GundamCdbName { get; }
        string WeaponCdbName { get; }
        string MasterCdbName { get; }
        string ConversionCdbName { get; }
        string SeriesCdbName { get; }

        string LanguageFolder { get; }

        bool RequiresResidentFolder { get; }
    }
}