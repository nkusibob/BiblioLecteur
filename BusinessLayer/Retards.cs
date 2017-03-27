using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Retards
    {
        public static List<BusinessEntity.RetardsUsers> LoadAllRetardsEF(string userName)


        {
            return DataAccessLayer.Retards.LoadAllRetardEF(userName);

        }

        public static List<int?> LoadACountRetardsEF(string userName)
        {
            return DataAccessLayer.Retards.LoadCountRetardUserEF(userName);

        }

        public static List<int?> LoadCountExemplaires(string biblio, string livre)
        {
            return DataAccessLayer.Retards.LoadCountExemplaireBiblio(biblio,livre);
        }
        public static int LoadCountExemplairesADo(string biblio, string livre)
        {
            return DataAccessLayer.Retards.LoadCountExemplaireBiblioAdo(biblio, livre);
        }

        public static int LoadACountRetardsAdo(string userName)
        {
            return DataAccessLayer.Retards.LoadCountRetardUserAdo(userName);
        }
    }
}
