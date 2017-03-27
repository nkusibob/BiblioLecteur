using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class exemplaires
    {
        public int IdLivre { get; set; }

        public int IdExemplaire { get; set; }


        public string code { get; set; }

        public DateTime achat { get; set; }
        public DateTime emprunt { get; set; }


        public int id_biblio { get; set; }
       
    }
}
