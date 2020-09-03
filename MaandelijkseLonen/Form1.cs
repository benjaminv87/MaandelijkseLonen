using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            new ItSupport("Bert Hoorne", Werknemer.Geslachten.Man,new DateTime(1981,02,12),"81021",new DateTime(2011,01,01)),
            new CustomerSupport("Ruben De Groote", Werknemer.Geslachten.Man,new DateTime(1981,02,12),"81021",new DateTime(2011,01,01))
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
            }
        }

        private void btnMaakLoonBrieven_Click(object sender, EventArgs e)
        {
            MaakLoonBrieven();
        }
        private void MaakLoonBrieven()
        {
            double totaleLoonkost = 0;
            string BestandsLocatie = Environment.CurrentDirectory + $"\\LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy").ToUpper()}\\";
            if (!Directory.Exists(BestandsLocatie))
            {
                Directory.CreateDirectory(BestandsLocatie);
            }

            foreach (Werknemer werknemer in mijnWerknemers)
            {
                totaleLoonkost+= werknemer.MaakLoonBrief(BestandsLocatie);
            }
            string loonKostCheck = File.ReadAllText("loonkosten.txt");
            if (!loonKostCheck.Contains(DateTime.Now.ToString("MMMM yyyy").ToUpper()))
            {
                using (StreamWriter writer = new StreamWriter("loonkosten.txt", true))
                {
                    writer.WriteLine($"Loonkost voor de maand {DateTime.Now.ToString("MMMM yyyy").ToUpper()}: €{totaleLoonkost}");
                }
            }

        }

        private void btnGebruikerWijzigen_Click(object sender, EventArgs e)
        {
            Werknemer actieveWerknemer = (Werknemer)lbMijnWerknemers.SelectedItem;
            using(FormGebruikerGegevens newForm = new FormGebruikerGegevens(actieveWerknemer))
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    actieveWerknemer = newForm.actieveWerknemer;
                }
            }
            lbMijnWerknemers.DataSource = null;
            lbMijnWerknemers.DataSource = mijnWerknemers;
        }

        private void btnNieuweWerknemer_Click(object sender, EventArgs e)
        {
            Werknemer nieuweWerknemer;
            using (FormGebruikerGegevens newForm = new FormGebruikerGegevens())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    nieuweWerknemer = newForm.actieveWerknemer;
                    mijnWerknemers.Add(nieuweWerknemer);
                    lbMijnWerknemers.DataSource = null;
                    lbMijnWerknemers.DataSource = mijnWerknemers;
                }
            }
        }
    }
}
