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
    public partial class IstoriaRomaniei : Form
    {
        public IstoriaRomaniei()
        {
            InitializeComponent();
        }
        int n = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lb1.Text = "2";
            lb1.ForeColor = Color.Lime;
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lb1.Text = "0";
            lb1.ForeColor = Color.Red;
          
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lb1.Text = "0";
            lb1.ForeColor = Color.Red;
         
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Text = "2";
            lb2.ForeColor = Color.Lime;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Text = "0";
            lb2.ForeColor = Color.Red;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lb2.Text = "0";
            lb2.ForeColor = Color.Red;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            lb3.Text = "2";
            lb3.ForeColor = Color.Lime;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            lb3.Text = "0";
            lb3.ForeColor = Color.Red;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            lb3.Text = "0";
            lb3.ForeColor = Color.Red;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            lb4.Text = "2";
            lb4.ForeColor = Color.Lime;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            lb4.Text = "0";
            lb4.ForeColor = Color.Red;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            lb4.Text = "0";
            lb4.ForeColor = Color.Red;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            lb5.Text = "2";
            lb5.ForeColor = Color.Lime;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            lb5.Text = "0";
            lb5.ForeColor = Color.Red;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            lb5.Text = "0";
            lb5.ForeColor = Color.Red;
        }

        private void btnev_Click(object sender, EventArgs e)
        {
            try
            {
                n += Convert.ToInt32(lb1.Text);
                n += Convert.ToInt32(lb2.Text);
                n += Convert.ToInt32(lb3.Text);
                n += Convert.ToInt32(lb4.Text);
                n += Convert.ToInt32(lb5.Text);
                lb1.Visible = true;
                lb2.Visible = true;
                lb3.Visible = true;
                lb4.Visible = true;
                lb5.Visible = true;
                lb7.Text = n + "";
                lb7.ForeColor = Color.Red;
                lb6.Visible = true;
                lb7.Visible = true;
                n = 0;
            }
            catch
            {
                MessageBox.Show("Bifeaza toate grilele!!!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
