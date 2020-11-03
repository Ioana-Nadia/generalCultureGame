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
    public partial class IstoriaRomanieibarem : Form
    {
        public IstoriaRomanieibarem()
        {
            InitializeComponent();
            tbbarem2.Text = "                                       Istoria Romaniei - BAREM \r\n" +
            "\r\n" +
            "1.) Revolutia Romana a avut loc in anul? \r\n" +
            "a.) 1984 \r\n" +
            "b.) 1989                                                                      RASPUNS CORECT: 1989\r\n" +
            "c.) 1988 \r\n" +
             "\r\n" +
            "2.) Regele Carol I al Romaniei a domnit in perioada...? \r\n" +
            "a.) aprilie 1866 - 10 octombrie 1914 \r\n" +
            "b.) aprilie 1866 - 10 octombrie 1900                          RASPUNS CORECT:APRILIE 1866 - 10 OCTOMBRIE 1914 \r\n" +
            "c.) aprilie 1866 - 10 octombrie 1910 \r\n" +
             "\r\n" +
            "3.) Razboiul de Independenta al Romaniei a avut loc intre anii? \r\n" +
            "a.) 1877-1878 \r\n" +
            "b.) 1818-1819                                                             RASPUNS CORECT: 1877-1878 \r\n" +
            "c.) 1593-1601 \r\n" +
             "\r\n" +
            "4.) Mihai Viteazul a domnit in Tara Romaneasca intre anii...? \r\n" +
            "a.) 1600-1603 \r\n" +
            "b.) 1593-1601                                                             RASPUNS CORECT: 1593-1601   \r\n" +
            "c.) 1599-1600 \r\n" +
             "\r\n" +
            "5.) La data de 1 Decembrie 1918 a avut loc...? \r\n" +
            "a.) Revolutia Romana \r\n" +
            "b.) Primul Razboi Mondial                                          RASPUNS CORECT: MAREA UNIRE DE LA ALBA IULIA    \r\n" +
            "c.) Marea Unire de la Alba Iulia ";
            tbbarem2.Enabled = false;


        }

        private void btbarem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult rezultatDialog = dialog.ShowDialog();
            if (rezultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                var numeFisier = dialog.FileName;
                File.WriteAllText(numeFisier, tbbarem2.Text);
                MessageBox.Show("Fisierul a fost salvat cu succes!!!", "Informatie pentru tine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
