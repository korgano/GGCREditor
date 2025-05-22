using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;
using System.Threading;
using GGCREditorLib.CDBItem.Ability;

namespace GGCREditor
{
    public static class GGCRUtil
    {
        public static class Logger
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
            // New overload to accept an Exception
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
        }

        #region 系列部分
        public static Dictionary<short, string> ListSeriesCode()
        {
            Dictionary<short, string> dic = new Dictionary<short, string>();

            List<string> names = new GGCRTblFile(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\MiscData.tbl").ListAllText();

            GGCRPkdFile misc = new GGCRPkdFile(GGCRStaticConfig.PATH + @"\resident\MiscData.pkd");

            int idx = misc.GetInnerFile("SeriesList.cdb").StartIndex;
            int count = BitConverter.ToInt32(misc.Data, idx + 8);
            for (int i = 0; i < count; i++)
            {
                short groupId = BitConverter.ToInt16(misc.Data, idx + 12 + i * GGCRStaticConfig.SeriesLength);
                dic.Add(groupId, names[i]);
            }
            return dic;
        }

        #endregion

        #region 人物部分

        public static List<KeyValuePair<string, string>> ListMasterZhaoPin()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("招聘可能.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddMasterZhaoPin(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("招聘可能.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListMasterGrown()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("成长规律.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddMasterGrown(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("成长规律.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        private static List<KeyValuePair<string, string>> peopleSkillExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListPeopleSkill()
        {
            Logger.Log("Entering ListPeopleSkill");

            // Final list to return
            var prop = new List<KeyValuePair<string, string>>();

            // Attempt to get raw abilities; fallback to empty list on error
            /*IList<string> abilities;
            try
            {
                abilities = new AbilitySpecFile().ListPersonAbilitys();
                Logger.Log($"Retrieved abilities count: {abilities?.Count ?? 0}");
            }
            catch (Exception ex)
            {
                Logger.Log($"Exception listing abilities: {ex.GetType().Name} – {ex.Message}");
                abilities = new List<string>();
            }*/

            // Attempt to get raw abilities; fallback to empty list on error
            IList<string> abilities;
            try
            {
                // Fetch all abilities and filter for PersonAbility
                var all = new AbilitySpecFile().ListAbilitys();
                var personNames = new List<string>();
                foreach (var ab in all)
                {
                    if (ab is PersonAbility pa)
                    {
                        personNames.Add(pa.UnitName);
                    }
                }
                abilities = personNames;

                // Log the count
                Logger.Log($"Retrieved abilities count: {abilities.Count}");
            }
            catch (Exception ex)
            {
                Logger.Error("Failed to retrieve person abilities", ex);
                // Ensure `abilities` is assigned even if an error occurs.
                abilities = new List<string>();
            }

            // Add default "none" entry
            const string noneKey = "-1";
            const string noneDisplay = "-1:None";
            prop.Add(new KeyValuePair<string, string>(noneKey, noneDisplay));
            Logger.Log("Added default entry: -1:None");

            // Safely add each ability
            for (int i = 0; i < abilities.Count; i++)
            {
                string name = abilities[i] ?? string.Empty;
                string key = i.ToString();
                string display = $"{key}:{name}";
                prop.Add(new KeyValuePair<string, string>(key, display));
                Logger.Log($"Added ability entry: {display}");
            }

            // Merge extension entries without duplicates
            Logger.Log("Merging extension entries");
            if (peopleSkillExt != null)
            {
                foreach (var kv in peopleSkillExt)
                {
                    if (!prop.Exists(p => p.Key == kv.Key))
                    {
                        prop.Add(kv);
                        Logger.Log($"Merged extension entry: {kv.Key}:{kv.Value}");
                    }
                    else
                    {
                        Logger.Log($"Skipped duplicate extension key: {kv.Key}");
                    }
                }
            }

            Logger.Log($"Exiting ListPeopleSkill with total count: {prop.Count}");
            return prop;
        }

        public static void AddPeopleSkill(short value, string skill)
        {
            Logger.Log($"AddPeopleSkill called with value={value}, skill={skill}");
            peopleSkillExt.Add(new KeyValuePair<string, string>(value.ToString(), skill));
            Logger.Log($"Extension skill added: {value}:{skill}");
        }
        #endregion

        #region 机体部分
        private static List<KeyValuePair<string, string>> sizeExt = new List<KeyValuePair<string, string>>();
        private static List<KeyValuePair<string, string>> gundamEarthExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListGundamSize()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("1", "S"));
            list.Add(new KeyValuePair<string, string>("2", "M"));
            list.Add(new KeyValuePair<string, string>("3", "L"));
            list.Add(new KeyValuePair<string, string>("5", "XL"));
            list.Add(new KeyValuePair<string, string>("6", "XXL"));
            list.AddRange(sizeExt);
            return list;
        }
        public static void AddGundamSize(short value, string size)
        {
            sizeExt.Add(new KeyValuePair<string, string>(value.ToString(), size));
        }

        public static List<KeyValuePair<string, string>> ListGundamEarth()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "-"));
            list.Add(new KeyValuePair<string, string>("1", "D"));
            list.Add(new KeyValuePair<string, string>("2", "C"));
            list.Add(new KeyValuePair<string, string>("3", "B"));
            list.Add(new KeyValuePair<string, string>("4", "A"));
            list.Add(new KeyValuePair<string, string>("5", "S"));
            list.AddRange(gundamEarthExt);
            return list;
        }
        public static void AddGundamEarth(short value, string earth)
        {
            gundamEarthExt.Add(new KeyValuePair<string, string>(value.ToString(), earth));
        }

        private static List<KeyValuePair<string, string>> machineAbilityExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListGundamAbility()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            IList<string> list = new AbilitySpecFile().ListMachineAbilitys();

            prop.Add(new KeyValuePair<string, string>("-1", "-1:无"));
            for (int i = 0; i < list.Count; i++)
            {
                prop.Add(new KeyValuePair<string, string>(i.ToString(), i + ":" + list[i]));
            }
            prop.AddRange(machineAbilityExt);
            return prop;
        }
        public static void AddGundamAbility(short value, string prop)
        {
            machineAbilityExt.Add(new KeyValuePair<string, string>(value.ToString(), prop));
        }


        public static List<KeyValuePair<string, string>> ListConvertAction()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("换装动作.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddConvertAction(int value, string range)
        {
            using (StreamWriter sr = new StreamWriter("换装动作.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListEarthSize()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("占地面积.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddEarthSize(int value, string range)
        {
            using (StreamWriter sr = new StreamWriter("占地面积.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }
        #endregion

        #region 武器部分
        private static List<KeyValuePair<string, string>> mpLimitExt = new List<KeyValuePair<string, string>>();

        public static List<KeyValuePair<string, string>> ListActEarch()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("00", "Ineffective")); //"无效"
            list.Add(new KeyValuePair<string, string>("01", "Half Effectiveness")); //"减半"
            list.Add(new KeyValuePair<string, string>("10", "Normal")); //"正常"
            return list;
        }

        public static List<KeyValuePair<string, string>> ListWeaponMPLimit()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "Normal")); //"普通"
            list.Add(new KeyValuePair<string, string>("4", "Ultra Strong")); //"超强势"
            list.Add(new KeyValuePair<string, string>("5", "Super One‑Hit")); //"超一击"
            list.AddRange(mpLimitExt);
            return list;
        }

        public static void AddWeaponMPLimit(short value, string limit)
        {
            mpLimitExt.Add(new KeyValuePair<string, string>(value.ToString(), limit));
        }

        public static List<KeyValuePair<string, string>> ListWeaponRange()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("射程代码.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddWeaponRange(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("射程代码.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListWeaponType()
        {
            List<KeyValuePair<string, string>> spec = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("武器类型.txt", Encoding.UTF8))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        spec.Add(kv);
                    }
                }
            }
            return spec;
        }

        public static void AddWeaponType(byte value, string type)
        {
            using (StreamWriter sr = new StreamWriter("武器类型.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + type);
                sr.Flush();
            }
        }

        #endregion


        public static string Transform(List<KeyValuePair<string, string>> list, string key)
        {
            foreach (KeyValuePair<string, string> kv in list)
            {
                if (kv.Key == key)
                {
                    return kv.Value;
                }
            }
            return "未知";
        }


        public static string[] Languages()
        {
            return new string[] { "schinese", "tchinese/hk", "tchinese/tw", "japanese", "english", "korean" };
        }
    }
}
