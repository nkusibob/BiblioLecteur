using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class Biblio
    {
        public static List<BusinessEntity.Biblio> LoadAllLibrary()
        {
            List<BusinessEntity.Biblio> myList = new List<BusinessEntity.Biblio>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<SelectAll_Biblio_Result> maliste = dbcontext.SelectAll_Biblio().ToList();

                foreach (var item in maliste)

                {
                    BusinessEntity.Biblio biblio = new BusinessEntity.Biblio()
                    {

                        // code=item.Code,
                        libellé = item.libellé,
                        //id=item.id




                    };
                    myList.Add(biblio);

                }

            }
            return myList;
        }

        public static string LoadMAjorLibraryAdo(string user)
        {
            string biblio = "";
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "Select_BiblioPrincipale";


                SqlParameter oParamUser = new SqlParameter("@user", user);

               


                oUpd.Parameters.Add(oParamUser);


                biblio = oUpd.ExecuteScalar().ToString(); ;

                return biblio;

            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
                        break;
                    case 8152:
                        IdError = 5;
                        break;
                }

                throw new BusinessError.CustomError(IdError);

            }
            catch (Exception ex)
            {
                int IdError = 999;

                throw new BusinessError.CustomError(IdError);


            }
            finally
            {
                clsDatabase.oDataBase.Close();

            }
        }

        public static List<BusinessEntity.Biblio> LoadMAjorLibrary(string user)
        {
            List<BusinessEntity.Biblio> myList = new List<BusinessEntity.Biblio>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {


                

                foreach (var item in dbcontext.Select_BiblioPrincipale(user).ToList())

                {
                    BusinessEntity.Biblio biblio = new BusinessEntity.Biblio()
                    {

                        // code=item.Code,
                        libellé = item,
                        //id=item.id




                    };
                    myList.Add(biblio);

                }

            }
            return myList;
        }
    }
}
