using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSR_Laborator2_Exercitiul1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = tb_User.Text;
            string password = tb_Password.Text;
            string line = string.Empty;
            bool isUser = false;
            bool isPassword = false;
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul1\\Passwords.txt");
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    if (tempArray[0] == user)
                        isUser = true;
                    if (tempArray[1] == password)
                        isPassword = true;
                }
            }
            /* parte din testare
             * MessageBox.Show(Convert.ToString(isUser), "User");
            MessageBox.Show(Convert.ToString(isPassword), "Password");*/
            if ((isUser && isPassword) == true)
            {
                Form2 form2 = new Form2();
                form2.setUsername(tb_User.Text);
                form2.Show();
            }
        }
    }
}
