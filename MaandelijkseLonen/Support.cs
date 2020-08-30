using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class Support:Werknemer
    {   
        public Support(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, DateTime datumInDienstTreding, double brutoLoon = 2050, ContractTypes typeContract = ContractTypes.Voltijds) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer, datumInDienstTreding, brutoLoon, typeContract)
        {
            ExtraLegaleVoordelen = 50;   
        }
    }
}
