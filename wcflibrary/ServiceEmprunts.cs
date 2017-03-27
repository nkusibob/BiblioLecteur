using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceEmprunts" in both code and config file together.
    public class ServiceEmprunts : IServiceEmprunts
    {


        public DataSet LoadAllEmprunt()
        {
            try
            {
                DataSet oData = new DataSet();

                BusinessLayer.Emprunt.LoadAllEmprunt(ref oData);
                return oData;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void InsertEmprunt(string titre, string nom, DateTime? dtRetour, string biblio)

        {

            try
            {
                BusinessLayer.Emprunt.InsertEmprunt(titre, nom, dtRetour, biblio);

            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
        public void InsertEmpruntEF(string titre, string nom, DateTime? dtRetour,string biblio)

        {

            try
            {
                BusinessLayer.Emprunt.InsertEmpruntEF(titre, nom, dtRetour, biblio);
               
            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
            }
           
        }
        public void UpdateEmprunt(int id,DateTime dtRetour)

        {
            try
            {

                BusinessLayer.Emprunt.UpdateEmprunt(id, dtRetour);
            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
            }
        }

        public void NbreEmpruntAnnexePrincipal( string user)
        {
            try
            {

                BusinessLayer.Emprunt.NbreEmpruntAnnexePrincipal(user);

            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
            }
           
        }

      

        public int NbreEmpruntAnnexePrincipalAdo(string user)
        {
            return BusinessLayer.Emprunt.NbreEmpruntPrincipalAdo(user);
        }

        public int NbreEmpruntAnnexeAdo(string user)
        {
            return BusinessLayer.Emprunt.NbreEmpruntAnnexeAdo(user);
        }
        public void beforeEmprunterAdo(string livre,string biblio,string user)

        {
            try
            {
                BusinessLayer.Retards.beforeEmprunterAdo(livre, biblio, user);

               
            }
            catch (BusinessError.CustomError ex2)
            {
                FaultReason faultReason = new FaultReason(ex2.Message);
                ExceptionContainer fcont = new ExceptionContainer();
                fcont.errorMessage = ex2.Message;

                throw new FaultException<ExceptionContainer>(fcont, faultReason);
               
            }
        }
        public void beforeEmprunter(string livre, string user, string biblio)
        {
            try
            {
                BusinessLayer.Retards.beforeEmprunter(livre, user, biblio);
              
            }
            catch (Exception  ex2)
            {
                FaultReason faultReason = new FaultReason(ex2.Message);
                ExceptionContainer fcont = new ExceptionContainer();
                fcont.errorMessage = ex2.Message;
               
                throw new FaultException<ExceptionContainer>(fcont,faultReason);
             
            }
        }
    }
}
