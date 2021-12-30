using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CalculatorAssembly
{
    static class Program
    {

        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}
