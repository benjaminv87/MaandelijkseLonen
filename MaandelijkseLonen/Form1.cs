using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijkseLonen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemer> mijnWerknemers = new List<Werknemer>()
        {
            new Programmeur("Bart Billiet",Werknemer.Geslachten.Man,new DateTime(1981,02,12),"12028166652",new DateTime(2000,01,01),true,1900),
            new Werknemer("Benjamin Vandevelde", Werknemer.Geslachten.Man, new DateTime(1987,11,27),"333333333",new DateTime(2018,08,31)),
            new ItSupport("Bert Hoorne", Werknemer.Geslachten.Man,new DateTime(1981,02,12),"81021",new DateTime(2011,01,01))
        };

        private void Form1_Load(object sender, EventArgs e)
        {

            lbMijnWerknemers.DataSource = mijnWerknemers;
        }

        private void lbMijnWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMijnWerknemers.SelectedIndex > -1)
            {
                Werknemer geselecteerdeWerknemer = (Werknemer)lbMijnWerknemers.SelectedItem;
                lblMijnWerknemer.Text =Convert.ToString(geselecteerdeWerknemer.BerekenAncieniteit()+geselecteerdeWerknemer.StartLoon());
            }
        }

        private void btnMaakLoonBrieven_Click(object sender, EventArgs e)
        {
            foreach (Werknemer werknemer in mijnWerknemers)
            {
                werknemer.MaakLoonBrief();
            }
        }
    }
}
