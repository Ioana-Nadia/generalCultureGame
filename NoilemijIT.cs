using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_SCOALA
{
    public partial class NoilemijIT : Form
    {
        public NoilemijIT()
        {
            InitializeComponent();
        }
        int n = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lb21.Text = "2";
            lb21.ForeColor = Color.Lime;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lb21.Text = "0";
            lb21.ForeColor = Color.Red;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lb21.Text = "0";
            lb21.ForeColor = Color.Red;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            lb22.Text = "2";
            lb22.ForeColor = Color.Lime;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            lb22.Text = "0";
            lb22.ForeColor = Color.Red;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lb22.Text = "0";
            lb22.ForeColor = Color.Red;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            lb23.Text = "2";
            lb23.ForeColor = Color.Lime;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            lb23.Text = "0";
            lb23.ForeColor = Color.Red;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            lb23.Text = "0";
            lb23.ForeColor = Color.Red;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            lb24.Text = "2";
            lb24.ForeColor = Color.Lime;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            lb24.Text = "0";
            lb24.ForeColor = Color.Red;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            lb24.Text = "0";
            lb24.ForeColor = Color.Red;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            lb25.Text = "2";
            lb25.ForeColor = Color.Lime;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            lb25.Text = "0";
            lb25.ForeColor = Color.Red;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            lb25.Text = "0";
            lb25.ForeColor = Color.Red;
        }

        private void btnev2_Click(object sender, EventArgs e)
        {
            try
            {
                n += Convert.ToInt32(lb21.Text);
                n += Convert.ToInt32(lb22.Text);
                n += Convert.ToInt32(lb23.Text);
                n += Convert.ToInt32(lb24.Text);
                n += Convert.ToInt32(lb25.Text);
                lb21.Visible = true;
                lb22.Visible = true;
                lb23.Visible = true;
                lb24.Visible = true;
                lb25.Visible = true;
                lb27.Text = n + "";
                lb27.ForeColor = Color.Red;
                lb26.Visible = true;
                lb27.Visible = true;
                n = 0;
            }
            catch
            {
                MessageBox.Show("Bifeaza toate grilele!!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
            }
        }
    }
}
