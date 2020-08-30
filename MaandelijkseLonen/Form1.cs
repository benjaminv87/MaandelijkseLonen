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
        public List<Werknemer> mijnWerknemers=new List<Werknemer>()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Werknemer nieuweWerknemer = new Werknemer("Benjamin", Werknemer.Geslachten.Man, new DateTime(1987,11,27), 2,new DateTime(2018,08,31),typeContract: Werknemer.ContractTypes.Voltijds,brutoLoon:2200);
            Console.WriteLine(nieuweWerknemer.StartLoon());
            Console.WriteLine(nieuweWerknemer.BerekenAncieniteit());
        }
    }
}
