using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class exemplaireRetardsUser
    {
        public string UserName { get; set; }


        public string BookTitle { get; set; }
        public DateTime DateRetour { get; set; }
        public DateTime DateEmprunt { get; set; }
        public int NbrMoisAutorise{ get; set; }
        public decimal Solde { get; set; }
        public decimal TarifParJour { get; set; }
    }
}
