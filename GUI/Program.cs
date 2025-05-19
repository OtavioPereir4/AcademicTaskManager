using System;
using System.Windows.Forms;
using AcademicTaskManager.GUI.Forms;

namespace AcademicTaskManager.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}