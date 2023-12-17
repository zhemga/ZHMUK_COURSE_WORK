using System;
using System.Windows.Forms;
using CourseWork.Views.ClinicDbContextView;

namespace CourseWork
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
            Application.Run(new ClinicDbContextView());
        }
    }
}
