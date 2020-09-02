using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijkseLonen
{
    public partial class FormGebruikerGegevens : Form
    {
        public FormGebruikerGegevens()
        {
            InitializeComponent();
            btnBevestigen.Text = "Maak werknemer aan";
        }
        public Werknemer actieveWerknemer;
        public FormGebruikerGegevens(Werknemer werknemer)
        {
            InitializeComponent();
            actieveWerknemer = werknemer;
            btnBevestigen.Text = "Wijzigingen bevestigen";
            tbNaam.Text = actieveWerknemer.Naam;
            dtGeboorteDatum.Value = actieveWerknemer.GeboorteDatum;
            cbGeslacht.SelectedItem = actieveWerknemer.Geslacht;
            tbRijksregisterNummer.Text = actieveWerknemer.RijksRegisterNummer;
            tbRekeningNummer.Text = actieveWerknemer.Iban;
            cbFunctie.SelectedItem = actieveWerknemer.FunctieTitel;
            cbTypeContract.SelectedItem = actieveWerknemer.TypeContract;
            numUren.Value = actieveWerknemer.AantalUren;
            numBrutoLoon.Value = (Decimal)actieveWerknemer.BrutoLoon;
            cbBedrijfsWagen.SelectedItem = actieveWerknemer.BedrijfsWagen;
        }

        private void FormGebruikerGegevens_Load(object sender, EventArgs e)
        {
            cbBedrijfsWagen.DataSource = new List<bool>() { true, false };
            cbFunctie.DataSource = new List<string>() { "Werknemer", "Programmeur", "It Support", "Customer Support" };
            cbGeslacht.DataSource = Enum.GetValues(typeof(Werknemer.Geslachten));
            cbTypeContract.DataSource = Enum.GetValues(typeof(Werknemer.ContractTypes));


            dtGeboorteDatum.Format = DateTimePickerFormat.Custom;
            dtGeboorteDatum.CustomFormat = "dd MMM yyyy";
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            UpdateWerknemer();
            DialogResult = DialogResult.OK;
        }
 

        public void UpdateWerknemer()
        {
            actieveWerknemer.Naam = tbNaam.Text;
            actieveWerknemer.GeboorteDatum = dtGeboorteDatum.Value;
            actieveWerknemer.Geslacht = (Werknemer.Geslachten)cbGeslacht.SelectedItem;
            actieveWerknemer.RijksRegisterNummer = tbRijksregisterNummer.Text;
            actieveWerknemer.Iban = tbRekeningNummer.Text;
            actieveWerknemer.FunctieTitel = cbFunctie.SelectedItem.ToString();
            actieveWerknemer.TypeContract = (Werknemer.ContractTypes)cbTypeContract.SelectedItem;
            actieveWerknemer.AantalUren = (int)numUren.Value;
            actieveWerknemer.BrutoLoon = (double)numBrutoLoon.Value;
            actieveWerknemer.BedrijfsWagen = (bool)cbBedrijfsWagen.SelectedItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cbFunctie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFunctie.SelectedItem)
            {
                case "Werknemer":
                    actieveWerknemer = new Werknemer();
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = false;
                    cbTypeContract.Enabled = true;
                    numUren.Enabled = true; 
                    break;
                case "Programmeur":
                    actieveWerknemer = new Programmeur();
                    cbBedrijfsWagen.Enabled = true;
                    cbBedrijfsWagen.SelectedItem = false;
                    cbTypeContract.Enabled = true;
                    numUren.Enabled = true; 
                    break;
                case "It Support":
                    actieveWerknemer = new ItSupport();
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = false;
                    cbTypeContract.Enabled = false;
                    cbTypeContract.SelectedItem = Werknemer.ContractTypes.Voltijds;
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
                case "Customer Support":
                    actieveWerknemer = new CustomerSupport();
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = false;
                    cbTypeContract.Enabled = false;
                    cbTypeContract.SelectedItem = Werknemer.ContractTypes.Voltijds;
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
            }
            numBrutoLoon.Value = (decimal)actieveWerknemer.BrutoLoon;
        }

        private void cbTypeContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeContract.SelectedItem.ToString() == Werknemer.ContractTypes.Voltijds.ToString())
            {
                numUren.Enabled = false;
                numUren.Value = 38;
            }
            else
            {
                numUren.Enabled = true;
                numUren.Maximum = 38;
            }
        }
    }
}
