using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PROIECT_SCOALA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Parola = "Info";
        private void inpct_Click(object sender, EventArgs e)
        {
            panelInregistrare.Visible = true;
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult rezultatDialog = dialog.ShowDialog();
            if(rezultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                var continutfisier = File.ReadAllText(dialog.FileName);
                tbText.Text = continutfisier;
            }
        }
        private void btnSalveazadate_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult rezultatDialog = dialog.ShowDialog();
            if(rezultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                var numeFisier = dialog.FileName;
                File.WriteAllText(numeFisier, tbText.Text);
                MessageBox.Show("Fisierul a fost salvat cu succes!!!", "Informatie pentru tine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tbText.Text = " ";

        }

        private void btnInapoiinpct_Click(object sender, EventArgs e)
        {
            panelInregistrare.Visible = false;  
        }

        private void istoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IstoriaRomaniei f = new IstoriaRomaniei();
            f.Show();
         
           
        }

        private void noileMijloaceDeComunicareITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ///noile mijloace barem 
            NoilemijITbarem l = new NoilemijITbarem();
            l.Show();

        }

        private void istoriaRomânieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///istoria romaniei barem
            IstoriaRomanieibarem a = new IstoriaRomanieibarem();
            a.Show();


        }

        private void reguliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///partea cu reguli
            Reguli h = new Reguli();
            h.Show();
        }

        private void istoriaRomanieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoilemijIT k = new NoilemijIT();
            k.Show();
        }

        private void ApasaEnter(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (tbparola.Text == Parola)
                {
                    panel2.Visible = false;
                }
                else
                {
                    tbparola.Text = " ";
                    MessageBox.Show("Parola gresita!!! Introduceti din nou parola!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
