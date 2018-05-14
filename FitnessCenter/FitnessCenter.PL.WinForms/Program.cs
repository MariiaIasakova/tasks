using FitnessCenter.BL.Logic;
using FitnessCenter.Shared;
using System;
using System.Windows.Forms;

namespace FitnessCenter.PL.WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogic logic = new Logic();
            Application.Run(new MainForm(logic));
        }
    }
}
