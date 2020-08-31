using System;
using System.Collections.Generic;
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
        public List<string> Maanden = new List<string>()
        {
            "Januari",
            "Februari",
            "Maart",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Augustus",
            "September",
            "Oktober",
            "November",
            "December"
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
        public Werknemer()
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
        }

        public double StartLoon()
        {
            double startLoon = 0;
            startLoon = BrutoLoon / 38 * Uren[TypeContract.ToString()];
            return startLoon;
        }
        public int AantalJarenInDienst()
        {
            int jarenInDienst = DateTime.Now.Year - DatumInDienstTreding.Year + ((DateTime.Now.Day < DatumInDienstTreding.Day) ? -1 : 0);
            return jarenInDienst;
        }
        public virtual double BerekenAncieniteit()
        {
            double loon = StartLoon();
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            Console.WriteLine(jarenInDienst);
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

        public void MaakLoonBrief(string bestandsLocatie)
        {
            string bestandsNaam = bestandsLocatie+$"LOONBRIEF  {Naam} {RijksRegisterNummer} {DateTime.Now.ToString("MM yyyy")}.txt";
            using (StreamWriter writer = new StreamWriter(bestandsNaam))
            {
                writer.WriteLine("-----------------------------------------------------------");
                writer.WriteLine($"LOONBRIEF {Maanden[DateTime.Now.Month+1].ToUpper()} {DateTime.Now.Year} ");
                writer.WriteLine("-----------------------------------------------------------");
                writer.WriteLine($"NAAM                     :{Naam}");
                writer.WriteLine($"RIJKSREGISTERNUMMER      :{RijksRegisterNummer}");
                writer.WriteLine($"GESLACHT                 :{Geslacht}");
                writer.WriteLine($"GEBOORTEDATUM            :{GeboorteDatum.ToShortDateString()}");
                writer.WriteLine($"DATUM INDIENSTTREDING    :{DatumInDienstTreding.ToShortDateString()}");
                writer.WriteLine($"FUNCTIE                  :{FunctieTitel}");
                writer.WriteLine($"AANTAL GEPRESTEERDE UREN :{Uren[TypeContract.ToString()]}/38");
                writer.WriteLine($"BEDRIJFSWAGEN            :{(BedrijfsWagen?"Ja":"Nee")}");
                writer.WriteLine("-----------------------------------------------------------");
                writer.WriteLine($"STARTLOON                :   € {StartLoon()}");
                writer.WriteLine($"ANCIËNNITEIT             : + € {BerekenAncieniteit()}");
                writer.WriteLine($"                             €");
                writer.WriteLine($"SOCIALE ZEKERHEID        : - €");
                writer.WriteLine($"                             €");
                writer.WriteLine($"BEDRIJFSVOORHEFFING      : - €");
                writer.WriteLine($"                             €");
                writer.WriteLine($"NETTOLOON                :   €");

                writer.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
