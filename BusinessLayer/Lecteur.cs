using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace BusinessLayer
{
    public class Lecteur
    {
        public static List<BusinessEntity.Lecteur> loadAllReaders(string user, string pass, string biblio)
        {
            return DataAccessLayer.Lecteur.loadAllLecteurs(user, pass, biblio);

        }
    }
}
