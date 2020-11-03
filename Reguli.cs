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
    public partial class Reguli : Form
    {
        public Reguli()
        {
            InitializeComponent();
            tbr1.Text = "Acest program consta intr-un joc cu teste de cultura generala \r\n" +
                "Regulile sunt unele simple.\r\n" +
                " Se bifeaza fiecare raspuns( in caz ca va razganditi se sterge mai intai bifa dupa care se alege noul raspuns) \r\n" +
                "Dupa rezolvarea celor 5 intrebari se apasa butonul 'evalueaza!!!', programul afisand nota finala \r\n" +
                "Punctajul poate fi retinut intr-un fisier \r\n" +
                "SUCCES!!";
            tbr1.Enabled = false;

        }
    }
}
