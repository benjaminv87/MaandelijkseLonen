using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public partial class Werknemer
    {
        public Dictionary<string, int> Uren = new Dictionary<string, int>()
        {
            {"Voltijds",38 },
            {"Deeltijds",25},
        };

        public string Naam;
        public Geslachten Geslacht;
        public DateTime GeboorteDatum;
        public string RijksRegisterNummer;
        public DateTime DatumInDienstTreding;
        public string Iban;
        public double BrutoLoon;
        public ContractTypes TypeContract;
        public double BedrijfsVoorheffing = 13.68;
        public double ExtraLegaleVoordelen = 0;
        public bool BedrijfsWagen;
        public string FunctieTitel;
        public int AantalUren;
        public Werknemer(double brutoLoon = 1900)
        {
        }

        public Werknemer(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, DateTime datumInDienstTreding, double brutoLoon = 1900, ContractTypes typeContract= ContractTypes.Voltijds)
        {
            FunctieTitel = "Werknemer";
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            RijksRegisterNummer = rijksRegisterNummer;
            BrutoLoon = brutoLoon;
            TypeContract = typeContract;
            DatumInDienstTreding = datumInDienstTreding;
            BedrijfsWagen = false;
            AantalUren = (typeContract == ContractTypes.Voltijds) ? 38 : AantalUren;
        }

        public double StartLoon()
        {
            double startLoon = 0;
            startLoon = BrutoLoon / 38 * Uren[TypeContract.ToString()];
            return Math.Round(startLoon,2);
        }
        public int AantalJarenInDienst()
        {
            int jarenInDienst = DateTime.Now.Year - DatumInDienstTreding.Year + ((DateTime.Now.Month <= DatumInDienstTreding.Month) ? -1 : 0);
            return jarenInDienst;
        }
        public virtual double BerekenAncieniteit()
        {
            double loon = StartLoon();
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            for (int i = 0; i < jarenInDienst; i++)
            {
                ancieniteit *=1.01;
            }
            ancieniteit -= loon;
            return Math.Round(ancieniteit,2);
        }
        public override string ToString()
        {
            return Naam;
        }

        public double MaakLoonBrief(string bestandsLocatie)
        {
            double socialeZekerheid = 200;
            double brutoLoon = StartLoon() + BerekenAncieniteit();
            double bedragBedrijfsvoorheffing = Math.Round(brutoLoon / 100 * BedrijfsVoorheffing,2);
            double nettoLoon = Math.Round(brutoLoon - (bedragBedrijfsvoorheffing) + ExtraLegaleVoordelen,2);
            string bestandsNaam = bestandsLocatie+$"LOONBRIEF  {Naam} {RijksRegisterNummer} {DateTime.Now.ToString("MM yyyy")}.txt";
            using (StreamWriter writer = new StreamWriter(bestandsNaam))
            {
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"LOONBRIEF {DateTime.Now.ToString("MMMM").ToUpper()} {DateTime.Now.Year} ");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"NAAM                     :{Naam}");
                writer.WriteLine($"RIJKSREGISTERNUMMER      :{RijksRegisterNummer}");
                writer.WriteLine($"GESLACHT                 :{Geslacht}");
                writer.WriteLine($"GEBOORTEDATUM            :{GeboorteDatum.ToShortDateString()}");
                writer.WriteLine($"DATUM INDIENSTTREDING    :{DatumInDienstTreding.ToShortDateString()}");
                writer.WriteLine($"FUNCTIE                  :{FunctieTitel}");
                writer.WriteLine($"AANTAL GEPRESTEERDE UREN :{Uren[TypeContract.ToString()]}/38");
                writer.WriteLine($"BEDRIJFSWAGEN            :{(BedrijfsWagen?"JA":"NEE")}");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"STARTLOON                :   €{PrintValue(StartLoon())}");
                writer.WriteLine($"ANCIËNNITEIT             : + €{PrintValue(BerekenAncieniteit())}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon)}");
                writer.WriteLine($"SOCIALE ZEKERHEID        : - €{PrintValue(socialeZekerheid)}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon -socialeZekerheid)}");
                writer.WriteLine($"BEDRIJFSVOORHEFFING      : - €{PrintValue(bedragBedrijfsvoorheffing)}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon -(bedragBedrijfsvoorheffing))}");
                if (ExtraLegaleVoordelen > 0)
                {
                writer.WriteLine($"EXTRALEGALE VOORDELEN    : + €{PrintValue(ExtraLegaleVoordelen)}");
                }
                writer.WriteLine($"NETTOLOON                :   €{PrintValue(nettoLoon)}");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine("Het wordt uitbetaald op: {0}",Iban);
                writer.WriteLine("----------------------------------------------");

            }
            double totaleLoonkost = StartLoon() + BerekenAncieniteit() + ExtraLegaleVoordelen;
            return totaleLoonkost;
        }
        public string PrintValue(double getal)
        {
            string tePrinten = getal.ToString("0.00");
            tePrinten = string.Format("{0,8}", tePrinten);
            
            return tePrinten;
        }
    }
}
