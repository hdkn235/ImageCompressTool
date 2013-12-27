﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace 图片压缩小工具
{
    static class Program
    {
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //得到正在运行的例程
            Process instance = RunningInstance();
            if (instance == null)
            {
                //如果没有其它例程，就新建一个窗体
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            else
            {
                //处理发现的例程
                HandleRunningInstance(instance);
            }
        }

        /// <summary>
        /// 得到正在运行的进程
        /// </summary>
        /// <returns></returns>
        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历正在有相同名字运行的进程
            foreach (Process process in processes)
            {
                //忽略现有的进程
                if (process.Id != current.Id)
                {
                    //确保进程从EXE文件运行
                    if (process.MainModule.FileName == current.MainModule.FileName)
                    {
                        // 返回另一个进程实例
                        return process;
                    }
                }
            }
            //没有其它的进程，返回Null
            return null;
        }
        /// <summary>
        /// 处理正在运行的进程,也就是将其激活
        /// </summary>
        /// <param name="instance">要处理的进程</param>
        public static void HandleRunningInstance(Process instance)
        {
            //确保窗口没有被最小化或最大化
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);
            //设置真实进程为foreground window
            SetForegroundWindow(instance.MainWindowHandle);
        }


    }
}
