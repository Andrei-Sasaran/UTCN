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

namespace SSR_Laborator2_Exercitiul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\sasar\\Desktop\\UTCN\\II Informatica Industriala\\Laborator2\\SSR_Laborator2_Exercitiul2\\Objects.txt");
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] tempArray = line.Split(' ');
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        listBox1.Items.Add(tempArray[i]);
                    }
                }
            }
        }

        private void MoveListBoxItems(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach(var item in sourceItems)
            {
                destination.Items.Add(item);
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            MoveListBoxItems(listBox1, listBox2);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
