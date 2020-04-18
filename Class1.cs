using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wad_edit_tool
{
    class Class1
    {
        
        public static string Callcmd(string strcmd)
        {
            using (var process = new Process())
            {
                //初始化 (程序目录 + "wad cmd tool.exe"
                process.StartInfo.FileName = "cmd.exe";

                process.StartInfo.UseShellExecute = false;  //是否使用操作系统shell启动
                process.StartInfo.RedirectStandardInput = true; //是否接受来自调用程序的输入信息
                process.StartInfo.RedirectStandardOutput = true; //是否由调用程序获取输出信息
                process.StartInfo.RedirectStandardError = true; //是否重定向错误输出
                process.StartInfo.CreateNoWindow = false; //是否显示cmd窗口 true=不显示

                //启动程序
                process.Start();
                process.StandardInput.AutoFlush = true;
                process.StandardInput.WriteLine(strcmd + " &exit"); //执行后退出
                //process.StandardInput.WriteLine(strcmd);

                //获取cmd窗口的输出信息  
                string output = process.StandardOutput.ReadToEnd(); //获取cmd输出信息
                //String error = process.StandardError.ReadToEnd(); //获取错误信息
                //Debug.WriteLine(output);

                process.WaitForExit(); //等待程序退出
                process.Close(); //关闭对象
                return output;
            }

        }
    }
}
