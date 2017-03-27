using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class GeneralReservation
    {
        public string livreTitle { get; set; }
        public string biblio { get; set; }

        public Nullable<int> NbrExemplaireDispo { get; set; }


    }
}
