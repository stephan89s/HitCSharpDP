﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
