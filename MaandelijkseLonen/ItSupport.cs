using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class ItSupport:Support
    {
        
        public ItSupport() 
        {
        }
        public ItSupport(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, string iban, DateTime datumInDienstTreding, double brutoLoon = 2050) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer,iban, datumInDienstTreding, brutoLoon)
        {
            TypeContract = ContractTypes.Voltijds;
            FunctieTitel = "It Support";
        }

        public override double BerekenAncieniteit()
        {
            double loon = StartLoon()*0.94;
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            for (int i = 0; i < jarenInDienst; i++)
            {
                ancieniteit *= 1.01;
            }
            ancieniteit -= loon;
            return Math.Round(ancieniteit, 2);
        }
    }
}
