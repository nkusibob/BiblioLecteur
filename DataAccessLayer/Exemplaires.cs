using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Exemplaire
    {


        public static DataSet LoadAllCopy()
        {
            DataSet oData = new DataSet();

            SqlCommand oSelect
                = new SqlCommand();

            SqlDataAdapter oDataAdapter = new SqlDataAdapter();

            try
            {
                clsDatabase.oDataBase.Open();

                oSelect.Connection = clsDatabase.oDataBase;

                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "Exemplaire_SelectAll";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesExemplaires");

                return oData;
            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
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

        public static DataSet LoadSolde()
        {
            DataSet oData = new DataSet();

            SqlCommand oSelect
                = new SqlCommand();

            SqlDataAdapter oDataAdapter = new SqlDataAdapter();

            try
            {
                clsDatabase.oDataBase.Open();

                oSelect.Connection = clsDatabase.oDataBase;

                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "soldeRetour";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesExemplairesSolde");

                return oData;
            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
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

        public static void DeleteFromID(int iD)
        {

            SqlCommand oUpd
                = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "ExemplaireDeleteById";


                SqlParameter oParamID = new SqlParameter("@id", iD);



                oUpd.Parameters.Add(oParamID);

                int RowsDeleted = oUpd.ExecuteNonQuery();

                if (RowsDeleted == 0)
                    throw new BusinessError.CustomError(5);

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

        public static void CreateExemplaire(string code, DateTime date_achat, DateTime date_emprunt, int biblio, int idLivre)
        {
            SqlCommand oUpd
               = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "examplaire_Create";

                SqlParameter oParamCode = new SqlParameter("@code", code);
                SqlParameter oParamAchat = new SqlParameter("@date_achat", date_achat);

                ///oParamAchat.SqlDbType = SqlDbType.DateTime;
                SqlParameter oParamEmprunt = new SqlParameter("@date_emprunt", date_emprunt);

                // oParamEmprunt.SqlDbType = SqlDbType.DateTime;

                SqlParameter oParamIdBiblio = new SqlParameter("id_biblio", biblio);
                SqlParameter oParamIdLivre = new SqlParameter("@id_livre", idLivre);


                oUpd.Parameters.Add(oParamCode);
                oUpd.Parameters.Add(oParamAchat);
                oUpd.Parameters.Add(oParamEmprunt);
                oUpd.Parameters.Add(oParamIdBiblio);
                oUpd.Parameters.Add(oParamIdLivre);

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

        public static DataSet LoadAllCopyCount()
        {
            DataSet oData = new DataSet();

            SqlCommand oSelect
                = new SqlCommand();

            SqlDataAdapter oDataAdapter = new SqlDataAdapter();

            try
            {
                clsDatabase.oDataBase.Open();

                oSelect.Connection = clsDatabase.oDataBase;

                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "NbreExemplaire_SelectAll";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesExemplairesSolde");

                return oData;
            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
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
        
        public static List<ExemplairesLecteurs> LoadAllCopy(string biblio, string nameExempl)
        {
            List<BusinessEntity.ExemplairesLecteurs> myList = new List<BusinessEntity.ExemplairesLecteurs>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<Search_Exemplaire_Biblio_SelectAll_Result> maliste = dbcontext.Search_Exemplaire_Biblio_SelectAll(biblio, nameExempl).ToList();

                foreach (var item in maliste)

                {
                    BusinessEntity.ExemplairesLecteurs exam = new BusinessEntity.ExemplairesLecteurs()

                    {

                        code = item.code,
                        IdExemplaire = item.idExemplaire,
                        auteur=item.auteur,





                    };
                    myList.Add(exam);

                }

            }
            return myList;
        }

        public static List<BusinessEntity.ExemplairesLecteurs> LoadAllCopy(string biblio)
        {
            List<BusinessEntity.ExemplairesLecteurs> myList = new List<BusinessEntity.ExemplairesLecteurs>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<Exemplaire_Biblio_SelectAll_Result> maliste = dbcontext.Exemplaire_Biblio_SelectAll(biblio).ToList();

                foreach (var item in maliste)

                {
                    BusinessEntity.ExemplairesLecteurs exam = new BusinessEntity.ExemplairesLecteurs()

                    {

                        code = item.code,
                        IdExemplaire = item.idExemplaire,
                       auteur=item.auteur,





                    };
                    myList.Add(exam);

                }

            }
            return myList;
        }

        public static DataSet LoadSoldeRetard()
        {
            DataSet oData = new DataSet();

            SqlCommand oSelect
                = new SqlCommand();

            SqlDataAdapter oDataAdapter = new SqlDataAdapter();

            try
            {
                clsDatabase.oDataBase.Open();

                oSelect.Connection = clsDatabase.oDataBase;

                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "Exemplaire_SoldeRetardToday";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesExemplairesSoldeRetards");

                return oData;
            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
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

        public static DataSet LoadAllCopyCA()
        {
            DataSet oData = new DataSet();

            SqlCommand oSelect
                = new SqlCommand();

            SqlDataAdapter oDataAdapter = new SqlDataAdapter();

            try
            {
                clsDatabase.oDataBase.Open();

                oSelect.Connection = clsDatabase.oDataBase;

                oSelect.CommandType = CommandType.StoredProcedure;
                oSelect.CommandText = "CA_Livre";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesExemplairesCA");

                return oData;
            }
            catch (SqlException exSQL)
            {
                int IdError = 999;
                switch (exSQL.Number)
                {
                    case 18456:
                        IdError = 1;
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


        

        public static void UpdateExemplaire(int id, string code, DateTime achat, DateTime emprunt, int idBiblio)
        {

            SqlCommand oUpd
               = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "examplaire_Update";
                SqlParameter oParamId = new SqlParameter("@id", id);
                SqlParameter oParamCode = new SqlParameter("@code", code);
                SqlParameter oParamAchat = new SqlParameter("@date_achat", achat);

                ///oParamAchat.SqlDbType = SqlDbType.DateTime;
                SqlParameter oParamEmprunt = new SqlParameter("@date_emprunt", emprunt);

                // oParamEmprunt.SqlDbType = SqlDbType.DateTime;

                SqlParameter oParamIdBiblio = new SqlParameter("id_biblio", idBiblio);

                oUpd.Parameters.Add(oParamId);

                oUpd.Parameters.Add(oParamCode);
                oUpd.Parameters.Add(oParamAchat);
                oUpd.Parameters.Add(oParamEmprunt);
                oUpd.Parameters.Add(oParamIdBiblio);


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

            finally
            {
                clsDatabase.oDataBase.Close();

            }

        }
    }
}
