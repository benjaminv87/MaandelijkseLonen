﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijkseLonen
{
    public class Programmeur:Werknemer
    {
        public Programmeur(string naam, Geslachten geslacht, DateTime geboorteDatum, string rijksRegisterNummer, DateTime datumInDienstTreding, bool bedrijfsWagen=false, double brutoLoon = 2200, ContractTypes typeContract = ContractTypes.Voltijds) : base(naam, geslacht, geboorteDatum, rijksRegisterNummer, datumInDienstTreding,brutoLoon, typeContract)
        {
            BedrijfsWagen = bedrijfsWagen;
            BedrijfsVoorheffing = (bedrijfsWagen == true ? 17.30 : 13.68);
        }
    }
}
