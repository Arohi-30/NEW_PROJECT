﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CosmeticManagement
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
            Application.Run(new LOGIN());
            Application.Run(new Registration());
            Application.Run(new Product_Page());
        }
    }
}
