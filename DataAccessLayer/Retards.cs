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
    public class Retards

    {
        public static List<RetardsUsers> LoadAllRetardEF(string userName)

        {
            
            List<RetardsUsers> myList = new List<RetardsUsers>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {


                
                List<Exemplaire_SelectAllRetardsUsers_Result> maliste = dbcontext.Exemplaire_SelectAllRetardsUsers(userName).ToList();

                foreach(var item in maliste)

                 {
                    RetardsUsers user = new RetardsUsers() {
                        
                        NomLecteur = item.nom,
                        solde= Convert.ToDecimal( item.solde),
                        tarifParJour=item.tarifParJours,
                        date_emprunt =Convert.ToDateTime( item.date_emprunt),
                        date_retour=Convert.ToDateTime(item.dateRetour),
                        NbrMoisAuto=item.NbrMoisAutorisé,
                        Titre=item.code
                        
                        

                    };
                    myList.Add(user);

                }
              
            }
            return myList;
        }

        public static int LoadCountRetardUserAdo(string userName)
        {
            int nbreRetards = 0;
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "Exemplaire_AllRetardsUser";


                SqlParameter oParamUserName = new SqlParameter("@lecteurNom", userName);
               


                oUpd.Parameters.Add(oParamUserName);
             

                nbreRetards= Convert.ToInt32(oUpd.ExecuteScalar());

                return nbreRetards;

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

        public static List<int?> LoadCountExemplaireBiblio(string biblio, string livre)



        {
            List<int?> mylist = new List<int?>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<VerifieSiDispo_Result> maliste = dbcontext.VerifieSiDispo(biblio, livre).ToList();

                foreach (var item in maliste)

                {








                    mylist.Add(item.NbreDispoNow);

                }

            }
            return mylist;
        }
        //public static List<int?> LoadCountExemplaireBiblioAdo(string biblio, string livre)
        //{
        //    List<int?> mylist = new List<int?>();
        //    try
        //    {
        //        SqlCommand oIns
        //                = null;
        //        oIns = new SqlCommand();
        //        clsDatabase.oDataBase.Open();

        //        oIns.Connection = clsDatabase.oDataBase;
        //        oIns.CommandType = CommandType.StoredProcedure;
        //        oIns.CommandText = "VerifieSiDispo";
        //        SqlParameter oParamBilio = new SqlParameter("@biblio", biblio);

        //        //attention nom des parametres 

        //        SqlParameter oParamLivre= new SqlParameter("@livre", livre);
        //        oIns.Parameters.Add(oParamBilio);
        //        oIns.Parameters.Add(oParamLivre);


        //        int RowsModified = oIns.ExecuteNonQuery();

        //        if (RowsModified == 0)
        //        {
        //            //tout erreur logique il faut aussi faire le commit

        //            throw new BusinessError.CustomError(5);
        //        }

        //    }

        //    catch (SqlException exSQL)
        //    {
        //        //roll back avant n'importe quel traitement 
        //        //après on renvoie l'erreur business,...
        //        //oTrans.Rollback();
        //        if (exSQL.Number == 50000) throw exSQL;
        //        else
        //        {
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
        //        };


        //    }


        //    finally
        //    {
        //        clsDatabase.oDataBase.Close();

        //    }

        //    return mylist;

        //}
        public static int LoadCountExemplaireBiblioAdo(string biblio, string livre)

        {
            int nbreExem = 0;
            SqlCommand oUpd
                    = new SqlCommand();


            try
            {
                clsDatabase.oDataBase.Open();

                oUpd.Connection = clsDatabase.oDataBase;

                oUpd.CommandType = CommandType.StoredProcedure;
                oUpd.CommandText = "VerifieSiDispoAllLibrary";


                SqlParameter oParamBiblio = new SqlParameter("@biblio", biblio);
                SqlParameter oParamLivre = new SqlParameter("@livre", livre);


                oUpd.Parameters.Add(oParamBiblio);
                oUpd.Parameters.Add(oParamLivre);

                nbreExem = Convert.ToInt32(oUpd.ExecuteScalar());

                return nbreExem;

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

        public static List<int?> LoadCountRetardUserEF(string userName)


        {

            List<int?> myList = new List<int?>();
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {



                List<int?> maliste = dbcontext.Exemplaire_AllRetardsUser(userName).ToList();

                foreach (var item in maliste)

                {
                   

                   
                        



                   
                    myList.Add(item.Value);

                }

            }
            return myList;
        }
    }
}
