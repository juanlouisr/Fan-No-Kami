﻿using System;
using System.Windows.Forms;

namespace Fan_No_Kami {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            Application.Run(form);

        }
    }
}
