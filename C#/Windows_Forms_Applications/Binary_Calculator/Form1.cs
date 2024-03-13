using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSR_Laborator2_Exercitiul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void additionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_toChange.Text = "+";
            try
            {
                tb_Result.Text = (Convert.ToDouble(tb_X.Text) + Convert.ToDouble(tb_Y.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_toChange.Text = "-";
            try
            {
                tb_Result.Text = (Convert.ToDouble(tb_X.Text) - Convert.ToDouble(tb_Y.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_toChange.Text = "*";
            try
            {
                tb_Result.Text = (Convert.ToDouble(tb_X.Text) * Convert.ToDouble(tb_Y.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void devisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_toChange.Text = "/";
            try
            {
                tb_Result.Text = (Convert.ToDouble(tb_X.Text) / Convert.ToDouble(tb_Y.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }
    }
}
