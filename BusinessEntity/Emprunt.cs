using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Emprunt
    {
        public int ID { get; set; }

        public int lecteurID { get; set; }
        public Decimal prixEmprunt { get; set; }
        public int exemplaireID { get; set; }
        public DateTime date_retour { get; set; }

    }
}
