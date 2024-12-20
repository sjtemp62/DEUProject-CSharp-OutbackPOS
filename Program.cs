﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEUProject_CSharp_OutbackPOS.Data;
using System.Drawing;
using DEUProject_CSharp_OutbackPOS.View;
using DEUProject_CSharp_OutbackPOS.LoadedData;

namespace DEUProject_CSharp_OutbackPOS
{
    internal static class Program
    {

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseHelper.Initialize();
            Application.ApplicationExit += OnApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            // 애플리케이션 종료 직전 데이터 저장
            DataManager.Instance.StopAutoSave();
        }
    }
}
