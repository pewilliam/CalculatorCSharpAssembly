using System;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CalculatorAssembly
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SomaButtonClick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Assembly Calculator");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assembly.bat");
            Process.Start(path).WaitForExit();

            string text = File.ReadAllText(@"C:\Assembly Calculator\Input.txt");
            string[] arr = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }

            double a = double.Parse(arr[0]);
            double b = double.Parse(arr[1]);

            Form1 form1 = new Form1();
            form1.txbResult.Text = (a + b).ToString("F1", CultureInfo.InvariantCulture);
            form1.ShowDialog();

            File.Delete(@"C:\Assembly Calculator\Input.txt");
            Directory.Delete(@"C:\Assembly Calculator");
            this.Close();
        }

        private void SubtracaoButtonClick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Assembly Calculator");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assembly.bat");
            Process.Start(path).WaitForExit();

            string text = File.ReadAllText(@"C:\Assembly Calculator\Input.txt");
            string[] arr = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }

            double a = double.Parse(arr[0]);
            double b = double.Parse(arr[1]);

            Form1 form1 = new Form1();
            form1.txbResult.Text = (a - b).ToString("F1", CultureInfo.InvariantCulture);
            form1.ShowDialog();

            File.Delete(@"C:\Assembly Calculator\Input.txt");
            Directory.Delete(@"C:\Assembly Calculator");
            this.Close();
        }

        private void MultiplicacaoButtonClick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Assembly Calculator");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assembly.bat");
            Process.Start(path).WaitForExit();

            string text = File.ReadAllText(@"C:\Assembly Calculator\Input.txt");
            string[] arr = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }

            double a = double.Parse(arr[0]);
            double b = double.Parse(arr[1]);

            Form1 form1 = new Form1();
            form1.txbResult.Text = (a * b).ToString("F1", CultureInfo.InvariantCulture);
            form1.ShowDialog();

            File.Delete(@"C:\Assembly Calculator\Input.txt");
            Directory.Delete(@"C:\Assembly Calculator");
            this.Close();
        }

        private void DivisaoButtonClick(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Assembly Calculator");

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assembly.bat");
            Process.Start(path).WaitForExit();

            string text = File.ReadAllText(@"C:\Assembly Calculator\Input.txt");
            string[] arr = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i].ToString();
            }

            double a = double.Parse(arr[0]);
            double b = double.Parse(arr[1]);

            Form1 form1 = new Form1();
            form1.txbResult.Text = (a / b).ToString("F1", CultureInfo.InvariantCulture);
            form1.ShowDialog();

            File.Delete(@"C:\Assembly Calculator\Input.txt");
            Directory.Delete(@"C:\Assembly Calculator");
            this.Close();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            File.Delete(@"C:\Assembly Calculator\Input.txt");
            Directory.Delete(@"C:\Assembly Calculator");
            Application.Exit();
        }

        private void HelpButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("É necessário utilizar somente números inteiros que se encontram no espaço de 0 a 9 para efetuar as operações.\n\n", "Help");
        }
    }
}
