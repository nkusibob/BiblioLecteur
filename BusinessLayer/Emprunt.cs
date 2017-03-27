using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
   public  class Emprunt
    {
       
        public static void InsertEmpruntEF(string titre, string nom, DateTime? dtRetour, decimal prixEmprunt,string biblio)
        {
            try
            {
                DataAccessLayer.Emprunt.InsertEmpruntEF(titre, nom, dtRetour, prixEmprunt, biblio);

            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                message=message.Replace("The transaction ended in the trigger. The batch has been aborted.", "");
                MessageBox.Show(message);
               
            }
        }

        public static void InsertEmprunt(string titre, string nom,  DateTime ? dtRetour, decimal prixEmprunt, string biblio)
        {
            try
            {
                DataAccessLayer.Emprunt.InsertEmprunt(titre, nom, dtRetour, prixEmprunt, biblio);
            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void UpdateEmprunt(int id, DateTime dtRetour)
        {
            DataAccessLayer.Emprunt.UpdateEmprunt(id, dtRetour); ;
        }

        public static void LoadAllEmprunt(ref DataSet oDataSet)
        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Emprunt.LoadAllEmprunt();

                oDataSet = oData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<int?> NbreEmpruntAnnexePrincipal( string user)
        {
            return DataAccessLayer.Emprunt.NbreEmpruntAnnexePrincipal(user);
        }

        public static List<int?> NbreEmpruntAnnexe(string user)
        {
            return DataAccessLayer.Emprunt.NbreEmpruntAnnexe(user);

        }
        public static int NbreEmpruntPrincipalAdo(string user)

        {
            return DataAccessLayer.Emprunt.NbreEmpruntPrincipalAdo(user);
        }

        public static int NbreEmpruntAnnexeAdo(string user)
        {
            return DataAccessLayer.Emprunt.NbreEmpruntAnnexeAdo(user);

        }
    }
}
