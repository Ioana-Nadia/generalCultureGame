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
    public partial class NoilemijITbarem : Form
    {
        public NoilemijITbarem()
        {
            InitializeComponent();
            tbbarem1.Text = "                                                                Noile mijloace de comunicare IT - BAREM \r\n" +
                 "\r\n" +
                "1.) Cum se abreviaza sistemul de operare Microsoft Disk Operating System? \r\n" +
                "a.) MS-DOS \r\n" +
                "b.) MDOS                     RASPUNS CORECT: MS-DOS \r\n" +
                "c.) MDO \r\n" +
                "\r\n" +
                "2.) Cum se numesc conventiile de retea? \r\n" +
                "a.) PFC \r\n" +
                "b.) RFC                        RASPUNS CORECT: RFC \r\n" +
                "c.) AFC \r\n" +
                 "\r\n" +
                "3.) Vechiul limbaj de programare din alfabet se numeste...? \r\n" +
                "a.) I \r\n" +
                "b.) K                           RASPUNS CORECT: C \r\n" +
                "c.) C \r\n" +
                 "\r\n" +
                "4.) Care este prescurtarea care desemneaza tehnologiile pentru trasferul rapid de date prin cablu de telefon? \r\n" +
                "a.) CDSL \r\n" +
                "b.) XDSL                      RASPUNS CORECT: XDSL \r\n" +
                "c.) PDSL \r\n" +
                 "\r\n" +
                "5.) Ce reprezinta TxD in domeniul computerelor? \r\n" +
                "a.) Date transferate \r\n" +
                "b.) Date pierdute         RASPUNS CORECT: DATE TRANSMISE \r\n " +
                "c.) Date transmise \r\n";
           
            tbbarem1.Enabled = false;
      }

        private void btbarem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            DialogResult rezultatDialog = dialog.ShowDialog();
            if (rezultatDialog == System.Windows.Forms.DialogResult.OK)
            {
                var numeFisier = dialog.FileName;
                File.WriteAllText(numeFisier, tbbarem1.Text);
                MessageBox.Show("Fisierul a fost salvat cu succes!!!", "Informatie pentru tine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
