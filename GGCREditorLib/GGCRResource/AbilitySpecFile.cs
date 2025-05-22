using GGCREditor;
using GGCREditorLib.CDBItem;
using GGCREditorLib.CDBItem.Ability;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading;

namespace GGCREditorLib
{
    /*public static class Logger
    {
        private static readonly string LogFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GGCREditor.log");
        private static readonly object _lock = new object();

        public static void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string entry = $"{timestamp} [Thread {Thread.CurrentThread.ManagedThreadId}] {message}";
            lock (_lock)
            {
                File.AppendAllText(LogFilePath, entry + Environment.NewLine);
            }
        }

        public static void Error(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string entry = $"{timestamp} [Thread {Thread.CurrentThread.ManagedThreadId}] [ERROR] {message}";
            lock (_lock)
            {
                File.AppendAllText(LogFilePath, entry + Environment.NewLine);
            }
        }

        public static void Error(string message, Exception ex)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var sb = new StringBuilder();
            sb.Append($"{timestamp} [Thread {threadId}] [ERROR] {message}");
            if (ex != null)
            {
                sb.Append($" | Exception: {ex.Message}");
                sb.Append($" | StackTrace: {ex.StackTrace}");
            }
            string entry = sb.ToString();
            lock (_lock)
            {
                File.AppendAllText(LogFilePath, entry + Environment.NewLine);
            }
        }
    }*/

    /// <summary>
    /// 角色文件数据
    /// </summary>
    public class AbilitySpecFile : GGCRPkdFile
    {
        public int MachineAbilityCount { get; }
        public int OPCount { get; }
        public int PersonAbilityCount { get; }
        public int WarAbilityCount { get; }
        private int xiaoguoCount;
        public int XiaoGuoCount { get { return xiaoguoCount; } }
        private ReadOnlyCollection<string> abilityText;
        public ReadOnlyCollection<string> AbilityText { get { return abilityText; } }

        public AbilitySpecFile()
            : base(GGCRStaticConfig.AbilityFile)
        {
            // 读取机体能力数量
            MachineAbilityCount = BitConverter.ToInt32(this.Data, 8);   // MachineAbilityCount
            //Logger.Log($"Read MachineAbilityCount={MachineAbilityCount} at offset 8"); // Log offset & value

            OPCount = BitConverter.ToInt32(this.Data, 12);              // OPCount
            //Logger.Log($"Read OPCount={OPCount} at offset 12");

            PersonAbilityCount = BitConverter.ToInt32(this.Data, 16);   // PersonAbilityCount
            //Logger.Log($"Read PersonAbilityCount={PersonAbilityCount} at offset 16");

            WarAbilityCount = BitConverter.ToInt32(this.Data, 20);      // WarAbilityCount
            //Logger.Log($"Read WarAbilityCount={WarAbilityCount} at offset 20");

            this.xiaoguoCount = BitConverter.ToInt32(this.Data, 24);    // XiaoGuoCount
            //Logger.Log($"Read XiaoGuoCount={xiaoguoCount} at offset 24");

            ReloadAbilityText();
        }

        public void ReloadAbilityText()
        {
            // 读取字符TBL
            abilityText = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile)
                .ListAllText().AsReadOnly();
        }

        public void CopyAndCreate(AbstractAbility ability)
        {
            if (ability is XiaoGuoAbility)
            {
                copyAndCreate((XiaoGuoAbility)ability);
            }
            else
            {
                byte[] data = new byte[ability.Data.Length];
                ability.Data.CopyTo(data, 0);
                int index = -1;
                int count = -1;

                if (ability is GundamAbility)
                {
                    count = addText("自创机体能力");
                    base.Write(8, BitConverter.GetBytes(MachineAbilityCount + 1));
                    index = GGCRStaticConfig.GundamAbilityStart
                        + GGCRStaticConfig.GundamAbilityLength * MachineAbilityCount;
              //      Logger.Log($"Computed GundamAbility offset={index}");
                }
                else if (ability is OPInfo)
                {
                    count = addText("自创OP");
                    base.Write(12, BitConverter.GetBytes(OPCount + 1));
                    index = GGCRStaticConfig.GundamAbilityStart
                        + GGCRStaticConfig.GundamAbilityLength * MachineAbilityCount
                        + GGCRStaticConfig.OPAbilityLength * OPCount;
                //    Logger.Log($"Computed OPInfo offset={index}");
                }
                else if (ability is PersonAbility)
                {
                    count = addText("自创人物技能");
                    base.Write(16, BitConverter.GetBytes(PersonAbilityCount + 1));
                    index = GGCRStaticConfig.GundamAbilityStart
                        + GGCRStaticConfig.GundamAbilityLength * MachineAbilityCount
                        + GGCRStaticConfig.OPAbilityLength * OPCount
                        + GGCRStaticConfig.PeopleAbilityLength * PersonAbilityCount;
                  //  Logger.Log($"Computed PersonAbility offset={index}");
                }
                else
                {
                    throw new Exception("不支持此物品复制");
                }

                BitConverter.GetBytes((short)(count - 1)).CopyTo(data, 2);
                this.Insert(index, data);
            }
        }

        private void copyAndCreate(XiaoGuoAbility ability)
        {
            int count = addText("我的自创技能效果");
            byte[] newXiaoGuo = new byte[ability.Data.Length];
            ability.Data.CopyTo(newXiaoGuo, 0);
            Array.Copy(BitConverter.GetBytes((short)(count - 1)), newXiaoGuo, 2);
            this.xiaoguoCount++;
            base.Write(24, BitConverter.GetBytes(xiaoguoCount));
//            Logger.Log($"Computed XiaoGuoAbility offset for new item count={xiaoguoCount}");

            int index = GGCRStaticConfig.GundamAbilityStart
                + MachineAbilityCount * GGCRStaticConfig.GundamAbilityLength
                + OPCount * GGCRStaticConfig.OPAbilityLength
                + PersonAbilityCount * GGCRStaticConfig.PeopleAbilityLength
                + WarAbilityCount * GGCRStaticConfig.WarAbilityLength
                + GGCRStaticConfig.XiaoGuoLength * (xiaoguoCount - 1);
//            Logger.Log($"Computed XiaoGuoAbility offset={index}");
            this.Insert(index, newXiaoGuo);
        }

        public List<AbstractAbility> ListAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;
            List<AbstractAbility> list = new List<AbstractAbility>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                var ability = new GundamAbility(this, idx, no);
//                Logger.Log($"MachineAbility {i}: offset = {idx} | name = {ability.UnitName}");
                list.Add(ability);
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }

            for (int i = 0; i < OPCount; i++)
            {
                var ability = new OPInfo(this, idx, no);
 //               Logger.Log($"OPAbility {i}: offset = {idx} | name = {ability.UnitName}");
                list.Add(ability);
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }

            for (int i = 0; i < PersonAbilityCount; i++)
            {
                var ability = new PersonAbility(this, idx, no);
//                Logger.Log($"PersonAbility {i}: offset = {idx} | name = {ability.UnitName}");
                list.Add(ability);
                idx += GGCRStaticConfig.PeopleAbilityLength;
                no++;
            }

            for (int i = 0; i < WarAbilityCount; i++)
            {
                var ability = new WarAbility(this, idx, no);
//                Logger.Log($"WarAbility {i}: offset = {idx} | name = {ability.UnitName}");
                list.Add(ability);
                idx += GGCRStaticConfig.WarAbilityLength;
                no += 2;
            }

            for (int i = 0; i < XiaoGuoCount; i++)
            {
                var ability = new XiaoGuoAbility(this, idx, no);
//                Logger.Log($"XiaoGuoAbility {i}: offset = {idx} | name = {ability.UnitName}");
                list.Add(ability);
                idx += GGCRStaticConfig.XiaoGuoLength;
                no++;
            }

            return list;
        }

        public List<XiaoGuoAbility> ListXiaoGuo()
        {
            int idx = GGCRStaticConfig.GundamAbilityStart;
            //读取机体技能
            List<XiaoGuoAbility> list = new List<XiaoGuoAbility>();

            int skipIndx = GGCRStaticConfig.GundamAbilityStart + MachineAbilityCount * GGCRStaticConfig.GundamAbilityLength
                + OPCount * GGCRStaticConfig.OPAbilityLength + PersonAbilityCount * GGCRStaticConfig.PeopleAbilityLength
                + WarAbilityCount * GGCRStaticConfig.WarAbilityLength;
            int skipLength = MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount * 2;

            for (int i = 0; i < XiaoGuoCount; i++)
            {
                int offset = skipIndx + i * GGCRStaticConfig.XiaoGuoLength;
//                Logger.Log($"XiaoGuoAbility (ListXiaoGuo) {i}: offset = {offset}");
                list.Add(new XiaoGuoAbility(this, offset, skipLength + i));
            }

            return list;
        }

        public ReadOnlyCollection<string> ListMachineAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                machineAbilitys.Add(new GundamAbility(this, idx, no).UnitName);
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }

            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListOPs()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }
            for (int i = 0; i < OPCount; i++)
            {
                machineAbilitys.Add(new OPInfo(this, idx, no).UnitName);
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }

            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListPersonAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }
            for (int i = 0; i < OPCount; i++)
            {
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }
            for (int i = 0; i < PersonAbilityCount; i++)
            {
                machineAbilitys.Add(new PersonAbility(this, idx, no).UnitName);
                idx += GGCRStaticConfig.PeopleAbilityLength;
                no++;
            }

            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListWarAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }
            for (int i = 0; i < OPCount; i++)
            {
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }
            for (int i = 0; i < PersonAbilityCount; i++)
            {
                idx += GGCRStaticConfig.PeopleAbilityLength;
                no++;
            }

            for (int i = 0; i < WarAbilityCount; i++)
            {
                machineAbilitys.Add(new WarAbility(this, idx, no).UnitName);
                idx += GGCRStaticConfig.WarAbilityLength;
                no += 2;
            }
            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListXiaoGuos()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }
            for (int i = 0; i < OPCount; i++)
            {
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }
            for (int i = 0; i < PersonAbilityCount; i++)
            {
                idx += GGCRStaticConfig.PeopleAbilityLength;
                no++;
            }

            for (int i = 0; i < WarAbilityCount; i++)
            {
                idx += GGCRStaticConfig.WarAbilityLength;
                no += 2;
            }
            for (int i = 0; i < XiaoGuoCount; i++)
            {
                machineAbilitys.Add(new XiaoGuoAbility(this, idx, no).UnitName);
                idx += GGCRStaticConfig.XiaoGuoLength;
                no++;
            }

            return machineAbilitys.AsReadOnly();
        }

        private int addText(string text)
        {
            int count = 0;
            foreach (string s in GGCRUtil.Languages())
            {
                GGCRTblFile txtFile = new GGCRTblFile(
                    GGCRStaticConfig.PATH + @"\language\" + s + @"\AbilitySpecList.tbl");
                if (txtFile.Count > count)
                {
                    count = txtFile.Count;
                }
            }
            count++;
            foreach (string s in GGCRUtil.Languages())
            {
                GGCRTblFile txtFile = new GGCRTblFile(
                    GGCRStaticConfig.PATH + @"\language\" + s + @"\AbilitySpecList.tbl");
                List<string> list = txtFile.ListAllText();
                int span = count - list.Count;
                for (int i = 0; i < span; i++)
                {
                    list.Add(text);
                }
                txtFile.Save(list);
            }
            return count;
        }
    }
}