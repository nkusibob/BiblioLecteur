using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class RetardsUsers
    {
        public string NomLecteur { get; set; }
        public decimal solde { get; set; }
        public string Titre { get; set; }
        public DateTime date_emprunt { get; set; }
        public DateTime date_retour { get; set; }
        public int NbrMoisAuto { get; set; }
        public decimal tarifParJour { get; set; }


    }
}
