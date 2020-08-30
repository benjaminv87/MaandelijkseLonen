using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class Programmeur:Werknemer
    {
        public bool BedrijfWagen;
        public Programmeur(string naam, Geslachten geslacht, DateTime geboorteDatum, int rijksRegisterNummer, DateTime datumInDienstTreding, bool bedrijfsWagen, double brutoLoon = 2200, ContractTypes typeContract = ContractTypes.Voltijds) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer, datumInDienstTreding,brutoLoon, typeContract)
        {
            BedrijfWagen = bedrijfsWagen;
            BedrijfsVoorheffing = (bedrijfsWagen == true ? 17.30 : 13.68);
        }
    }
}
