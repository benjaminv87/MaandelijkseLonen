using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class CustomerSupport:Support
    {
        public CustomerSupport()
        {
            ExtraLegaleVoordelen = 50 + 19.5;
        }

        public CustomerSupport(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, string iban,DateTime datumInDienstTreding, double brutoLoon = 2050) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer,iban, datumInDienstTreding, brutoLoon)
        {
            ExtraLegaleVoordelen = 50 + 19.5;
            FunctieTitel = "Customer Support";
        }
    }
}
