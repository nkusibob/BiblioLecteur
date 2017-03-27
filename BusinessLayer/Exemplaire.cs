using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BusinessEntity;
using DataAccessLayer;

namespace BusinessLayer
{
    public class Exemplaire
    {
        public static void CreateExemplaire(string code, DateTime achatDt, DateTime empruntdt, int idBiblio, int idLivre)
        {
         
                try
                {
                DataAccessLayer.Exemplaire.CreateExemplaire(code, achatDt, empruntdt, idBiblio, idLivre);
                 }
                catch (SqlException e)
                {
                    int IdError = 999;
                    switch (e.Number)
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
                }

            
        }

        public static void LoadSolde(ref DataSet oDataSet)

        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Exemplaire.LoadSolde();



                oDataSet = oData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<ExemplairesLecteurs> LoadAllCopyEF(string userName)


        {
            return DataAccessLayer.Exemplaire.LoadAllCopy(userName);
        }

        public static List<ExemplairesLecteurs> LoadAllCopyEF(string biblio, string nameExempl)
        {
            return DataAccessLayer.Exemplaire.LoadAllCopy(biblio,nameExempl);
        }


        public static void LoadSoldeRetard(ref DataSet oDataSet)

        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Exemplaire.LoadSoldeRetard();


                oDataSet = oData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LoadAllCopy(ref List<BusinessEntity.exemplaires> pExemp)
        {
            DataView oDataView = new DataView();

            LoadAllCopy(ref oDataView);

            foreach (DataRowView oRow in oDataView)
            {
                BusinessEntity.exemplaires oExemp= new BusinessEntity.exemplaires();

                int ID = Convert.ToInt32(oRow["id"].ToString());
                string code = oRow["code"].ToString();
                DateTime achat = Convert.ToDateTime(oRow["achat"]);
                DateTime emprunt = Convert.ToDateTime(oRow["emprunt"]);

                if (oExemp.code.Length < 5)
                    throw new BusinessError.CustomError(3);

              

                pExemp.Add(oExemp);

            }

        }

        
        public static void LoadAllCopyCA(ref DataSet oDataSet)
        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Exemplaire.LoadAllCopyCA();

                oDataSet = oData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        public static void LoadAllCopy(ref DataTable oDataTable)
        {
            DataSet oDataBis = new DataSet();

            LoadAllCopy(ref oDataBis);

            oDataTable = oDataBis.Tables[0];
        }

        public static void LoadAllCopy(ref DataView oDataView)
        {
            DataTable oDataBis = new DataTable();

            LoadAllCopy(ref oDataBis);

            oDataView = oDataBis.DefaultView;
        }

        public static void LoadAllCopyCount(ref DataSet oDataSet)
        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Exemplaire.LoadAllCopyCount();

                oDataSet = oData;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void LoadAllCopy(ref DataSet oDataSet)
        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Exemplaire.LoadAllCopy();

                oDataSet = oData;
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

