using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class Programmeur : Werknemer
    {
        
        public Programmeur(double brutoLoon = 2200):base (brutoLoon)
        {
            BedrijfsVoorheffing = (BedrijfsWagen ? 17.30 : 13.68);
        }
        public Programmeur(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, string iban, DateTime datumInDienstTreding, bool bedrijfsWagen=false, double brutoLoon = 2200, ContractTypes typeContract = ContractTypes.Voltijds) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer,iban, datumInDienstTreding,brutoLoon, typeContract)
        {
            BedrijfsWagen = bedrijfsWagen;
            BedrijfsVoorheffing = (bedrijfsWagen ? 17.30 : 13.68);
            FunctieTitel = "Programmeur";
        }
    }
}
