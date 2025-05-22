using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{

    /// <summary>
    /// 技能信息
    /// </summary>
    public abstract class AbstractAbility : GGCRUnitInfo<AbilitySpecFile>
    {
        public AbstractAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {

        }

        public override string UnitName
        {
            get
            {
                // Guard: Data must contain at least 2 bytes for startIndex plus 2 bytes for the 16-bit value
                if (Data == null || Data.Length < 4)
                {
                    return null;
                }

                // Read the ability index from bytes 2–3
                short idx = BitConverter.ToInt16(this.Data, 2);
                // Ensure idx is within valid range [0, Count)
                if (idx >= 0 && idx < PkdFile.AbilityText.Count)
                {
                    return PkdFile.AbilityText[idx];  // Safe indexed access :contentReference[oaicite:2]{index=2}
                }
                // Fallback when index is out of range
                return null;
            }
        }


        public abstract string TypeName { get; }

        public abstract int IDInGroup { get; }

        public virtual short SkillId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 4);
            }
            set
            {
                save(4, value);
            }
        }

        public override int UUID_START => 0;

        public override int UUID_LENGTH => 2;

        public override void SaveUnitName(string name)
        {
            short idx = BitConverter.ToInt16(this.Data, 2);
            if (PkdFile.AbilityText.Count > idx)
            {
                GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile);
                List<string> list = txtFile.ListAllText();
                if (list.Count > idx)
                {
                    list[idx] = name;
                    txtFile.Save(list);

                    PkdFile.ReloadAbilityText();
                }
            }
        }
    }
}
