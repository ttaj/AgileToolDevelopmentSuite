﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
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
      Application.Run(new WelcomeForm());
      //Application.Run(new TaskForm("FinalJonTest"));
      //Application.Run(new MainMenuForm());
      //Application.Run(new SkillSetForm("Jonathan"));
    }
    }
}
