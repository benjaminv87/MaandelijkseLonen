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
        public Werknemer actieveWerknemer = null;
        public FormGebruikerGegevens(Werknemer werknemer)
        {
            InitializeComponent();
            actieveWerknemer = werknemer;
         }

        private void FormGebruikerGegevens_Load(object sender, EventArgs e)
        {
            cbBedrijfsWagen.DataSource = new List<string>() { "Ja", "Nee" };
            cbFunctie.DataSource = new List<string>() { "Werknemer", "Programmeur", "It Support", "Customer Support" };
            cbGeslacht.DataSource = Enum.GetValues(typeof(Werknemer.Geslachten));
            cbTypeContract.DataSource = Enum.GetValues(typeof(Werknemer.ContractTypes));
            dtGeboorteDatum.Format = DateTimePickerFormat.Custom;
            dtGeboorteDatum.CustomFormat = "dd MMM yyyy";

            if (actieveWerknemer != null)
            {

                ActiveForm.Text = "Gegevens wijzigen";
                btnBevestigen.Text = "Wijzigingen bevestigen";
                tbNaam.Text = actieveWerknemer.Naam;
                dtGeboorteDatum.Value = actieveWerknemer.GeboorteDatum;
                cbGeslacht.SelectedItem = actieveWerknemer.Geslacht;
                tbRijksregisterNummer.Text = actieveWerknemer.RijksRegisterNummer;
                tbRekeningNummer.Text = actieveWerknemer.Iban;
                cbFunctie.SelectedItem = actieveWerknemer.FunctieTitel;
                cbTypeContract.SelectedItem = actieveWerknemer.TypeContract;
                numUren.Value = actieveWerknemer.AantalUren;
                numBrutoLoon.Value = Convert.ToDecimal(actieveWerknemer.BrutoLoon);
                cbBedrijfsWagen.SelectedItem = actieveWerknemer.BedrijfsWagen ? "Ja" : "Nee";
            }
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            UpdateWerknemer();
            DialogResult = DialogResult.OK;
        }


        public void UpdateWerknemer()
        {
            switch (cbFunctie.SelectedItem)
            {
                case "Werknemer":
                    actieveWerknemer = new Werknemer();
                    break;
                case "Programmeur":
                    actieveWerknemer = new Programmeur();
                    break;
                case "It Support":
                    actieveWerknemer = new ItSupport();
                    break;
                case "Customer Support":
                    actieveWerknemer = new CustomerSupport();
                    break;
            }

            actieveWerknemer.Naam = tbNaam.Text;
            actieveWerknemer.GeboorteDatum = dtGeboorteDatum.Value;
            actieveWerknemer.Geslacht = (Werknemer.Geslachten)cbGeslacht.SelectedItem;
            actieveWerknemer.RijksRegisterNummer = tbRijksregisterNummer.Text;
            actieveWerknemer.Iban = tbRekeningNummer.Text;
            actieveWerknemer.FunctieTitel = cbFunctie.SelectedItem.ToString();
            actieveWerknemer.TypeContract = (Werknemer.ContractTypes)cbTypeContract.SelectedItem;
            actieveWerknemer.AantalUren = (int)numUren.Value;
            if (numBrutoLoon.Value != 0)
            {
                actieveWerknemer.BrutoLoon = Convert.ToDouble(numBrutoLoon.Value);
            }
            actieveWerknemer.BedrijfsWagen = (cbBedrijfsWagen.SelectedItem.ToString() == "Ja" ? true : false);
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
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = "Nee";
                    cbTypeContract.Enabled = true;
                    numUren.Enabled = true;
                    break;
                case "Programmeur":
                    cbBedrijfsWagen.Enabled = true;
                    cbBedrijfsWagen.SelectedItem = "Nee";
                    cbTypeContract.Enabled = true;
                    numUren.Enabled = true;
                    break;
                case "It Support":
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = "Nee";
                    cbTypeContract.Enabled = false;
                    cbTypeContract.SelectedItem = Werknemer.ContractTypes.Voltijds;
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
                case "Customer Support":
                    cbBedrijfsWagen.Enabled = false;
                    cbBedrijfsWagen.SelectedItem = "Nee";
                    cbTypeContract.Enabled = false;
                    cbTypeContract.SelectedItem = Werknemer.ContractTypes.Voltijds;
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
            }
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
                numUren.Value = 37;
            }
        }

        private void numUren_ValueChanged(object sender, EventArgs e)
        {
            if (numUren.Value == 38)
            {
                cbTypeContract.SelectedItem = Werknemer.ContractTypes.Voltijds;
            }

        }
    }
}
