using System;
using System.Collections.Generic;
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
        public int RijksRegisterNummer;
        public DateTime DatumInDienstTreding;
        public string Iban;
        public double BrutoLoon;
        public ContractTypes TypeContract;
        public double BedrijfsVoorheffing = 13.68;
        public double ExtraLegaleVoordelen = 0;
        public Werknemer()
        {
        }

        public Werknemer(string naam, Geslachten geslacht, DateTime geboorteDatum, int rijksRegisterNummer, DateTime datumInDienstTreding, double brutoLoon = 1900, ContractTypes typeContract= ContractTypes.Voltijds)
        {
            Naam = naam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            RijksRegisterNummer = rijksRegisterNummer;
            BrutoLoon = brutoLoon;
            TypeContract = typeContract;
            DatumInDienstTreding = datumInDienstTreding;
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
    }
}
