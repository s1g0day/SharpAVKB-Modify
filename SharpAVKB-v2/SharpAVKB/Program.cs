using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SharpAVKB
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("\n\rAuthor: s1g0day");
                Console.WriteLine("Github: https://github.com/s1g0day/SharpAVKB-Modify/SharpAVKB-v2/");
                Console.WriteLine("Usage: SharpAVKB.exe -AV avlist.json");

            }
            if (args.Length == 2 && args[0] == "-AV")
            {
                Console.WriteLine("\n\r========== SharpAVKB --> GetWindowsAnti-VirusSoftware ==========\n\r");
                getav(av(args[1]));
            }
        }

        public static Dictionary<string, string> av(string jsonfile)
        {
            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);

                    Dictionary<string, string> dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(o.ToString());
                    return dic;
                }
            }
        }
        public static void getav(Dictionary<string, string> av_list)
        {
            // 读取进程
            Cmd c = new Cmd();
            Console.WriteLine("正在获取杀软信息请稍等。。。\n\r");
            string resultStr = c.RunCmd("tasklist /SVC /FO LIST");
            List<string> resultStrlist = new List<string>();
            resultStrlist = resultStr.Split('\n').ToList();

            // 提取进程中的杀软
            List<string> getav_list = new List<string>();
            foreach (var i in resultStrlist)
            {
                if (i.IndexOf("映像名称") > -1)
                {
                    List<string> ilist = new List<string>();
                    ilist = i.Split(':').ToList();
                    //Console.WriteLine(ilist[1].Trim());
                    foreach (KeyValuePair<string, string> kvp in av_list)
                    {
                        if (kvp.Key == ilist[1].Trim())
                        {
                            getav_list.Add(kvp.Key + ": " + kvp.Value);
                            //Console.WriteLine(kvp.Key + ": " + kvp.Value);
                        }
                    }
                }
            }
            if (getav_list.Count != 0)
            {
                Console.WriteLine("存在杀软信息如下：");
                foreach (var j in getav_list)
                {
                    Console.WriteLine(j);
                }
            }
            else
            {
                Console.WriteLine("暂未发现杀软");
            }

        }
    }

    /// <summary>
    /// Cmd 的摘要说明。
    /// </summary>
    public class Cmd
    {
        private Process proc = null;
        /// <summary>
        /// 构造方法
        /// </summary>
        public Cmd()
        {
            proc = new Process();
        }
        /// <summary>
        /// 执行CMD语句
        /// </summary>
        /// <param name="cmd">要执行的CMD命令</param>
        public string RunCmd(string cmd)
        {
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            string outStr = proc.StandardOutput.ReadToEnd();
            proc.Close();
            return outStr;
        }
    }
}
