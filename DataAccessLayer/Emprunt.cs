using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace DataAccessLayer
{
    public class Emprunt
    {
        public static DataSet LoadAllEmprunt()
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
                oSelect.CommandText = "Emprunt_SelectAll";

                oDataAdapter.SelectCommand = oSelect;

                oDataAdapter.Fill(oData, "MesEmprunt");

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

     

        //public static void SaveAll(List<BusinessEntity.Emprunt> listEmp, List<BusinessEntity.Emprunt> listToAdd, List<int> toDel)
        //{
        //    {
        //        SqlCommand oUpd
        //           = null;


        //        SqlCommand oIns
        //          = null;
        //        SqlCommand oDel
        //         = null;
        //        SqlTransaction oTrans = null;

        //        try
        //        {
        //            clsDatabase.oDataBase.Open();
        //            oTrans = clsDatabase.oDataBase.BeginTransaction();
        //            //delete
        //            foreach (var ID in toDel)
        //            {

        //                oDel = new SqlCommand();
        //                oDel.Connection = clsDatabase.oDataBase;
        //                oDel.Transaction = oTrans;
        //                oDel.CommandType = CommandType.StoredProcedure;
        //                oDel.CommandText = "EmpDeleteById";
        //                SqlParameter oParamID = new SqlParameter("@id", ID);



        //                oDel.Parameters.Add(oParamID);

        //                int RowsDeleted = oDel.ExecuteNonQuery();

        //                if (RowsDeleted == 0)
        //                    throw new BusinessError.CustomError(5);


        //            }
        //            //uodate
                 


        //            foreach (var emp in listEmp)
        //            {
        //                oUpd = new SqlCommand();
        //                oUpd.Connection = clsDatabase.oDataBase;
        //                oUpd.Transaction = oTrans;
        //                oUpd.CommandType = CommandType.StoredProcedure;
        //                oUpd.CommandText = "UpdateEmpruntByID";
        //                SqlParameter oParamID = new SqlParameter("@id", emp.ID);
        //                SqlParameter oParamlecteurID = new SqlParameter("@lecteurID", emp.lecteurID);
        //                SqlParameter oParamprixEmprunt = new SqlParameter("@prixEmprunt", emp.prixEmprunt);

                       
        //                SqlParameter oParamexemplaireID = new SqlParameter("@exemplaireID", emp.exemplaireID);
        //                SqlParameter oParamDt = new SqlParameter("@date_de_retour", emp.date_retour);
        //                oUpd.Parameters.Add(oParamID);
        //                oUpd.Parameters.Add(oParamlecteurID);
        //                oUpd.Parameters.Add(oParamprixEmprunt);
        //                oUpd.Parameters.Add(oParamexemplaireID);

        //                oUpd.Parameters.Add(oParamDt);
        //                int RowsModified = oUpd.ExecuteNonQuery();

        //                if (RowsModified == 0)
        //                {
        //                    //tout erreur logique il faut aussi faire le commit
        //                    oTrans.Commit();
        //                    throw new BusinessError.CustomError(5);
        //                }


        //            }
        //            oIns = new SqlCommand();
        //            oIns.Connection = clsDatabase.oDataBase;
        //            //insert
        //            foreach (var emp in listToAdd)
        //            {

        //                oIns.Transaction = oTrans;
        //                oIns.CommandType = CommandType.StoredProcedure;
        //                oIns.CommandText = "Emprunt_Create";
                       
        //                SqlParameter oParamlecteurID = new SqlParameter("@lecteurID", emp.lecteurID);
        //                SqlParameter oParamprixEmprunt = new SqlParameter("@prixEmprunt", emp.prixEmprunt);


        //                SqlParameter oParamexemplaireID = new SqlParameter("@exemplaireID", emp.exemplaireID);
        //                SqlParameter oParamDt = new SqlParameter("@date_de_retour", emp.date_retour);


        //                oIns.Parameters.Add(oParamlecteurID);
        //                oIns.Parameters.Add(oParamprixEmprunt);
        //                oIns.Parameters.Add(oParamexemplaireID);
        //                oIns.Parameters.Add(oParamDt);

        //                int RowsModified = oIns.ExecuteNonQuery();

        //                if (RowsModified == 0)
        //                {
        //                    //tout erreur logique il faut aussi faire le commit
        //                    oTrans.Commit();
        //                    throw new BusinessError.CustomError(5);
        //                }

        //            }
        //             oTrans.Commit();

        //        }

        //        catch (SqlException exSQL)
        //        {
        //            //roll back avant n'importe quel traitement 
        //            //après on renvoie l'erreur business,...
        //            //oTrans.Rollback();
        //            int IdError = 999;
        //            switch (exSQL.Number)
        //            {
        //                case 18456:
        //                    IdError = 1;
        //                    break;
        //                case 8152:
        //                    IdError = 5;
        //                    break;
        //                case 50000:
        //                    IdError = 13;
        //                    break;
        //            }

        //            throw new BusinessError.CustomError(IdError);

        //        }


        //        finally
        //        {
        //            clsDatabase.oDataBase.Close();

        //        }

        //    }
        //}

        public static List<int?> NbreEmpruntAnnexe(string user)
        {
            List<int?> mylist = new List<int?>();
            using (bibliothequeEntities context = new bibliothequeEntities())

            {
                List<int?> mylistresult = context.NbreEmpruntAnnexe(user).ToList();
                mylist = mylistresult;
            }
           
            return mylist;
        }

        public static List<int?> NbreEmpruntAnnexePrincipal( string user)
        {
            List<int?> mylist = new List<int?>();
            using (bibliothequeEntities context = new bibliothequeEntities())

            {
                List<int?> mylistresult = context.Principal_Annexe(user).ToList();
                mylist = mylistresult;
            }
           
            return mylist;
        }
        public static int NbreEmpruntAnnexeAdo(string user)
        {
            int nbreEmpruntAnnexe = 0;
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "NbreEmpruntAnnexe";


                SqlParameter oParamUserName = new SqlParameter("@user", user);



                oUpd.Parameters.Add(oParamUserName);


                nbreEmpruntAnnexe = Convert.ToInt32(oUpd.ExecuteScalar());

                return nbreEmpruntAnnexe;

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

        public static int NbreEmpruntPrincipalAdo(string user)
        {
            int nbreEmpruntAnnexe = 0;
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "Principal_Annexe";


                SqlParameter oParamUserName = new SqlParameter("@user", user);



                oUpd.Parameters.Add(oParamUserName);


                nbreEmpruntAnnexe = Convert.ToInt32(oUpd.ExecuteScalar());

                return nbreEmpruntAnnexe;

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
        public static void UpdateEmprunt(int id, DateTime dtRetour)
        {
            try
            {
                SqlCommand oIns
                        = null;
                oIns = new SqlCommand();
                clsDatabase.oDataBase.Open();

                oIns.Connection = clsDatabase.oDataBase;
                oIns.CommandType = CommandType.StoredProcedure;
                oIns.CommandText = "UpdateEmpruntByID";
                SqlParameter oParamId = new SqlParameter("@id", id);
                
                //attention nom des parametres 
               
                SqlParameter oParamDt = new SqlParameter("@date_de_retour", dtRetour);
                oIns.Parameters.Add(oParamId);
               
                oIns.Parameters.Add(oParamDt);

                int RowsModified = oIns.ExecuteNonQuery();

                if (RowsModified == 0)
                {
                    //tout erreur logique il faut aussi faire le commit

                    throw new BusinessError.CustomError(5);
                }

            }

            catch (SqlException exSQL)
            {
                //roll back avant n'importe quel traitement 
                //après on renvoie l'erreur business,...
                //oTrans.Rollback();
                if (exSQL.Number == 50000) throw exSQL;
                else
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
                        case 50000:
                            IdError = 13;
                            break;
                    }

                    throw new BusinessError.CustomError(IdError);
                };


            }


            finally
            {
                clsDatabase.oDataBase.Close();

            }

        }

        public static void InsertEmpruntEF(string titre, string nom, DateTime? dtRetour, decimal prixEmprunt,string biblio)
        {
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
                try
                {
                    dbcontext.CustomEmprunt_Create(prixEmprunt, titre, nom, biblio, dtRetour);
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

                    throw ex.InnerException;
                    throw new BusinessError.CustomError(6);

                }

            }
        }

        public static void UpdateEmprunt(int id,string titre, string nom, DateTime? dtRetour, decimal? prixEmprunt)
        {
            try
            {
                SqlCommand oIns
                        = null;
                oIns = new SqlCommand();
                clsDatabase.oDataBase.Open();

                oIns.Connection = clsDatabase.oDataBase;
                oIns.CommandType = CommandType.StoredProcedure;
                oIns.CommandText = "UpdateEmpruntByID";
                SqlParameter oParamId = new SqlParameter("@id", id);
                SqlParameter oParamprixEmprunt = new SqlParameter("@prixEmprunt", prixEmprunt);
                SqlParameter oParamexemplaireName = new SqlParameter("@lecteurNom", titre);
                //attention nom des parametres 
                SqlParameter oParamlecteurNom = new SqlParameter("@exemplaireName", nom);
                SqlParameter oParamDt = new SqlParameter("@date_de_retour", dtRetour);
                oIns.Parameters.Add(oParamId);
                oIns.Parameters.Add(oParamlecteurNom);
                oIns.Parameters.Add(oParamprixEmprunt);
                oIns.Parameters.Add(oParamexemplaireName);
                oIns.Parameters.Add(oParamDt);

                int RowsModified = oIns.ExecuteNonQuery();

                if (RowsModified == 0)
                {
                    //tout erreur logique il faut aussi faire le commit

                    throw new BusinessError.CustomError(5);
                }

            }

            catch (SqlException exSQL)
            {
                //roll back avant n'importe quel traitement 
                //après on renvoie l'erreur business,...
                //oTrans.Rollback();
                if (exSQL.Number == 50000) throw exSQL;
                else
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
                        case 50000:
                            IdError = 13;
                            break;
                    }

                    throw new BusinessError.CustomError(IdError);
                };
                

            }


            finally
            {
                clsDatabase.oDataBase.Close();

            }


        }

        public static void InsertEmprunt(string titre, string nom, DateTime ?dtRetour, decimal prixEmprunt, string biblio)
        {
            try
            {
                SqlCommand oIns
                        = null;
                oIns = new SqlCommand();
                clsDatabase.oDataBase.Open();

                oIns.Connection = clsDatabase.oDataBase;
                oIns.CommandType = CommandType.StoredProcedure;
                oIns.CommandText = "CustomEmprunt_Create";
                SqlParameter oParamprixEmprunt = new SqlParameter("@prixEmprunt", prixEmprunt);
                SqlParameter oParamlecteurNom = new SqlParameter("@userName", nom);
                SqlParameter oParamexemplaireName = new SqlParameter("@exemplaireName", titre);

                SqlParameter oParamDt = new SqlParameter("@date_de_retour", dtRetour);
                SqlParameter oParamBiblio = new SqlParameter("@biblio", biblio);

                oIns.Parameters.Add(oParamlecteurNom);
                oIns.Parameters.Add(oParamprixEmprunt);
                oIns.Parameters.Add(oParamexemplaireName);
                oIns.Parameters.Add(oParamDt);
                oIns.Parameters.Add(oParamBiblio);
                int RowsModified = oIns.ExecuteNonQuery();

                if (RowsModified == 0)
                {
                    //tout erreur logique il faut aussi faire le commit

                    throw new BusinessError.CustomError(5);
                }

            }

            catch (SqlException exSQL)
            {
                //roll back avant n'importe quel traitement 
                //après on renvoie l'erreur business,...
                //oTrans.Rollback();
                if (exSQL.Number == 50000) throw exSQL;
                else
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
                        case 515:
                            IdError = 13;
                            break;
                    }

                    throw new BusinessError.CustomError(IdError);
                }
            }

            finally
            {
                clsDatabase.oDataBase.Close();

            }


        }

       
    }
}
