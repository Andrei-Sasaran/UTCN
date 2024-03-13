using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SSR_Laborator2_Exercitiul4
{
    public partial class Form1 : Form
    {
        Image e30 = Image.FromFile("C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul4\\Ex4_Photos\\bmw_e30.jpg");
        Image e34 = Image.FromFile("C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul4\\Ex4_Photos\\bmw_e34.jpg");
        Image e36 = Image.FromFile("C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul4\\Ex4_Photos\\bmw_e36.jpg");
        Image e39 = Image.FromFile("C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul4\\Ex4_Photos\\bmw_e39.jpg");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            BMW_Models.Items.Add("e 30");
            BMW_Models.Items.Add("e 34");
            BMW_Models.Items.Add("e 36");
            BMW_Models.Items.Add("e 39");
            BMW_Models.SelectedIndexChanged += BMW_Models_SelectedIndexChanged;
            textBox1.Text = "Please select one Radio from each Group";
        }
        private void BMW_Models_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BMW_Models.SelectedIndex != -1)
            {
                string selectedItem = BMW_Models.SelectedItem.ToString();

                switch(selectedItem)
                {
                    case "e 30":
                        pictureBox1.Image = e30;
                        break;
                    case "e 34":
                        pictureBox1.Image = e34;
                        break;
                    case "e 36":
                        pictureBox1.Image = e36;
                        break;
                    case "e 39":
                        pictureBox1.Image = e39;
                        break;
                    default:
                        pictureBox1.Image = null;
                        break;
                }
            }
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked)
            {
                textBox1.Text = "You selected Radio1 from Group_A and Radio1 from Group_B";
            }
            else if (radioButton1.Checked && radioButton4.Checked)
            {
                textBox1.Text = "You selected Radio1 from Group_A and Radio2 from Group_B";
            }
            else if (radioButton2.Checked && radioButton3.Checked)
            {
                textBox1.Text = "You selected Radio2 from Group_A and Radio1 from Group_B";
            }
            else if (radioButton2.Checked && radioButton4.Checked)
            {
                textBox1.Text = "You selected Radio2 from Group_A and Radio2 from Group_B";
            }
            else
            {
                textBox1.Text = "Please select one Radio from each Group";
            }
        }
    }
}
