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

        public CustomerSupport(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, DateTime datumInDienstTreding, double brutoLoon = 2050) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer, datumInDienstTreding, brutoLoon)
        {
            ExtraLegaleVoordelen = 50 + 19.5;
        }
    }
}
