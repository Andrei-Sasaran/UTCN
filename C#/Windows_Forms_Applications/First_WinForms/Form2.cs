using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSR_Laborator2_Exercitiul1
{
    public partial class Form2 : Form
    {
        private string Username;
        public Form2()
        {
            InitializeComponent();
        }

        public void setUsername(string username)
        {
            this.Username = username;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            tb_message.Text = "Hell0 " + Username + " !"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
