using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercisesClient
{
    public partial class Form1 : Form
    {
        srExercises.wsExercisesSoapClient soapClient = new srExercises.wsExercisesSoapClient();
        Boolean temp;
        Boolean currency;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Date.Enabled = true;
        }

        private void textBox_Celsius_TextChanged(object sender, EventArgs e)
        {
            temp = true;
        }

        private void textBox_Fahrenheit_TextChanged(object sender, EventArgs e)
        {
            temp = false;
        }

        private void textBox_Euro_TextChanged(object sender, EventArgs e)
        {
            currency = true;
        }

        private void textBox_Ron_TextChanged(object sender, EventArgs e)
        {
            currency=false;
        }

        private void button_PrintList_Click(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            list = soapClient.Build5ItemList();
            foreach (String item in list)
            {
                listBox_5Elements.Items.Add(item);
            }
        }

        private void button_ConvertTemp_Click(object sender, EventArgs e)
        {
            if (temp)
            {
                textBox_ResultTemperature.Text = soapClient.ConvertCF(Double.Parse(textBox_Celsius.Text)).ToString("00.0000");
                textBox_Fahrenheit.Clear();
            } else
            {
                textBox_ResultTemperature.Text = soapClient.ConvertFC(Double.Parse(textBox_Fahrenheit.Text)).ToString("00.0000");
                textBox_Celsius.Clear();
            }
        }

        private void button_ConvertMoney_Click(object sender, EventArgs e)
        {
            if(currency)
            {
                textBox_ResultMoney.Text = soapClient.ConvertEuroToRon(Double.Parse(textBox_Euro.Text)).ToString("00.0000");
                textBox_Ron.Clear();
            } else
            {
                textBox_ResultMoney.Text = soapClient.ConvertRontoEuro(Double.Parse(textBox_Ron.Text)).ToString("00.0000");
                textBox_Euro.Clear();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Date.Text = soapClient.DateTimeNow().ToString();
        }
    }
}
