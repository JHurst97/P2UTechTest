using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2UTechTest
{
    public partial class Form1 : Form
    {
        //elements in order: (0 = GBP, 1 = USD, 2 = AUD, 3 = EUR).
        double[] GBPConv = new double[] { 1.00, 1.32, 1.83, 1.11 };
        double[] USDConv = new double[] { 0.75, 1.00, 1.38, 0.84 };
        double[] AUDConv = new double[] { 0.55, 0.72, 1.00, 0.61 };
        double[] EURConv = new double[] { 0.90, 1.19, 1.65, 1.00 };
        bool logFileExists;
        string logFilePath;

        public Form1()
        {
            InitializeComponent();

            //Check if 'log' file exists.

            // Get the current directory.
            string dirPath = Directory.GetCurrentDirectory();

            //add log file to dir for check.
            logFilePath = dirPath += @"\log.txt";

            //check if file exists or not.
            if (File.Exists(logFilePath))
            {
                Console.WriteLine("file exists");
                logFileExists = true;
                logFilePath = logFilePath;

                using (var tw = new StreamWriter(logFilePath, true))
                {
                    tw.WriteLine("Programme opened at " + DateTime.Now);
                }
            }
            else
            {
                Console.WriteLine("file does not exist");

                logFileExists = false;

                //create new file.
                using (var tw = new StreamWriter(logFilePath, true))
                {
                    tw.WriteLine("File created. Time: " + DateTime.Now);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputAmountTB_TextChanged(object sender, EventArgs e)
        {
            //check for special characters and remove.

            string str = inputAmountTB.Text;
            char[] charArr = str.ToCharArray();
            string newStr = "";
            foreach (char ch in charArr)
            {
                if (Char.IsDigit(ch))
                {
                    newStr += ch;
                }
                Console.WriteLine(ch);
            }
            inputAmountTB.Text = newStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputS = inputAmountTB.Text;

            double inputParsed;
            double.TryParse(inputS, out inputParsed);
            //Console.WriteLine(inputParsed);
            inputParsed = CalculateResult(inputParsed);
            resultTB.Text = inputParsed.ToString();

            //Save to file
            using (var tw = new StreamWriter(logFilePath, true))
            {
                tw.WriteLine("Converted " + inputS + inputCurrencyCB.Text + " to " + outputCurrencyCB.Text + ". Result: " + resultTB.Text + " | Time: " + DateTime.Now);
            }
        }

        public double CalculateResult(double input_)
        {
            string str = inputCurrencyCB.Text;
            //converting from GBP.
            if (str == "GBP")
            {
                if (outputCurrencyCB.Text == "GBP")
                {
                    return input_ * GBPConv[0];
                }
                if (outputCurrencyCB.Text == "USD")
                {

                    return input_ * GBPConv[1];
                }
                if (outputCurrencyCB.Text == "AUD")
                {

                    return input_ * GBPConv[2];
                }
                if (outputCurrencyCB.Text == "EUR")
                {

                    return input_ * GBPConv[3];
                }
            }

            //converting from USD.
            if (str == "USD")
            {
                if (outputCurrencyCB.Text == "GBP")
                {
                    return input_ * USDConv[0];
                }
                if (outputCurrencyCB.Text == "USD")
                {
                    return input_ * USDConv[1];
                }
                if (outputCurrencyCB.Text == "AUD")
                {

                    return input_ * USDConv[2];
                }
                if (outputCurrencyCB.Text == "EUR")
                {

                    return input_ * USDConv[3];
                }
            }

            //converting from AUD.
            if (str == "AUD")
            {
                if (outputCurrencyCB.Text == "GBP")
                {
                    return input_ * AUDConv[0];
                }
                if (outputCurrencyCB.Text == "USD")
                {

                    return input_ * AUDConv[1];
                }
                if (outputCurrencyCB.Text == "AUD")
                {

                    return input_ * AUDConv[2];
                }
                if (outputCurrencyCB.Text == "EUR")
                {

                    return input_ * AUDConv[3];
                }
            }

            //converting from EUR.
            if (str == "EUR")
            {
                if (outputCurrencyCB.Text == "GBP")
                {
                    return input_ * EURConv[0];
                }
                if (outputCurrencyCB.Text == "USD")
                {

                    return input_ * EURConv[1];
                }
                if (outputCurrencyCB.Text == "AUD")
                {

                    return input_ * EURConv[2];
                }
                if (outputCurrencyCB.Text == "EUR")
                {

                    return input_ * EURConv[3];
                }
            }

            return 0; 
        }

        public static void WriteToFile(string s, string fileName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Append, System.IO.FileAccess.Write);
            StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void inputCurrencyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = inputCurrencyCB.Text;
            Console.WriteLine(str);

            //TODO: CHANGE LABELS BASED ON SELECTION

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Log time of closing.
            using (var tw = new StreamWriter(logFilePath, true))
            {
                tw.WriteLine("Programme closed. Time: " + DateTime.Now);
            }
        }
    }
}