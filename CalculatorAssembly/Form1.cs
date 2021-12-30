using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CalculatorAssembly
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void NovaContaButton_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CalculatorAssembly.exe");
            Process.Start(path);
            this.Close();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
