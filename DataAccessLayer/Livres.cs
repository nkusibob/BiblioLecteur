using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Livres
    {
        public static void insertLivre(string isbn, string titre,string url,string auteur)
        {


            SqlCommand oUpd
               = new SqlCommand();

            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "Livre_Create";

                SqlParameter oParamIsbn = new SqlParameter("@isbn", isbn);
                SqlParameter oParamTitre = new SqlParameter("@titre", titre);
                SqlParameter oParamImage = new SqlParameter("@image", url);
                SqlParameter oParamAuteurs = new SqlParameter("@auteur", auteur);



                oUpd.Parameters.Add(oParamIsbn);
                oUpd.Parameters.Add(oParamTitre);
                oUpd.Parameters.Add(oParamAuteurs);
                oUpd.Parameters.Add(oParamImage);

                int RowsInserted = oUpd.ExecuteNonQuery();

                if (RowsInserted == 0)
                    throw new BusinessError.CustomError(6);

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

       
        public static string getImageEF(string titre)
        {
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
                try
                {
                    var url = dbcontext.GetImage(titre).FirstOrDefault(); ;
                    return url;
                    
                }
                catch (SqlException exSQL)
                {
                    //roll back avant n'importe quel traitement 
                    //après on renvoie l'erreur business,...
                    //oTrans.Rollback();
                    int IdError = 999;
                    switch (exSQL.Number)
                    {
                        case 18456:
                            IdError = 1;
                            break;
                        case 8152:
                            IdError = 5;
                            break;
                        case 515:
                            IdError = 5;
                            break;
                        case 50000:
                            IdError = 13;
                            break;
                    }
                    throw new BusinessError.CustomError(IdError);
                }
                catch (Exception ex)
                {


                    throw new BusinessError.CustomError(6);

                }
              
                
            }
         
        }

        public static string getImage(string titre)
        {
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "GetImage";
                

                SqlParameter oParamTitre = new SqlParameter("@titre", titre);
                oUpd.Parameters.Add(oParamTitre);
              
                string url = oUpd.ExecuteScalar().ToString();

                if (url == null)
                    throw new BusinessError.CustomError(6);
                return url;

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

    }
}
