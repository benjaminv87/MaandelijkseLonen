using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class ItSupport:Support
    {
        public ItSupport(string naam, Geslachten geslacht, DateTime geboorteDatum, int rijksRegisterNummer, DateTime datumInDienstTreding, double brutoLoon = 2050) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer, datumInDienstTreding, brutoLoon)
        {
            TypeContract = ContractTypes.Voltijds;
        }

        public override double BerekenAncieniteit()
        {
            double loon = StartLoon()*0.94;
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            Console.WriteLine(jarenInDienst);
            for (int i = 0; i < jarenInDienst; i++)
            {
                ancieniteit *= 1.01;
            }
            ancieniteit -= loon;
            return Math.Round(ancieniteit, 2);
        }
    }
}
