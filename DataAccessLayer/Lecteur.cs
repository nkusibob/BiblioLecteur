using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace DataAccessLayer
{
    public class Lecteur
    {
        public static List<BusinessEntity.Lecteur> loadAllLecteurs(string userName, string pass, string biblio)

        {
            List<BusinessEntity.Lecteur> myList = new List<BusinessEntity.Lecteur>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<CheckingUser_Result> maliste = dbcontext.CheckingUser(userName, pass, biblio).ToList();

                foreach (var item in maliste)

                {
                    BusinessEntity.Lecteur user = new BusinessEntity.Lecteur()
                    {

                        biblioPrincipale = item.libellé,
                        UserName = item.nom,
                        password = item.motPassword,



                    };
                    myList.Add(user);

                }

            }
            return myList;
        }
    }
}
