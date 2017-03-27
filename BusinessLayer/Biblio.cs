using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Biblio
    {
        public static List<BusinessEntity.Biblio> LoadAllLIbrary()
        {
            return DataAccessLayer.Biblio.LoadAllLibrary();
        }

        public static List<BusinessEntity.Biblio> LoadMAjorLibrary(string user)
        {
            return DataAccessLayer.Biblio.LoadMAjorLibrary(user);

        }
        public static string LoadMAjorLibraryAdo(string user)
        {
            return DataAccessLayer.Biblio.LoadMAjorLibraryAdo(user);

        }
    }
}
