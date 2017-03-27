using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceExemplaires" in both code and config file together.
    public class ServiceExemplaires : IServiceExemplaires
    {

        public DataSet Exemplaire_Solde()

        {
            DataSet
              oData = new DataSet();
            try
            {


                BusinessLayer.Exemplaire.LoadSolde(ref oData);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //aller chercher le champ 



            return oData;
        }
        public DataSet Exemplaire_SoldeRetard()
        {
            DataSet
              oData = new DataSet();

            try
            {
                BusinessLayer.Exemplaire.LoadSoldeRetard(ref oData);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //aller chercher le champ 



            return oData;
        }

        public DataSet GetAll()
        {
            DataSet oData = new DataSet();
            try
            {
                BusinessLayer.Exemplaire.LoadAllCopy(ref oData);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return oData;
        }

        public List<clsexemplaires> GetAllExemBiblio(string biblio)
        {
            List<clsexemplaires> myListSer = new List<clsexemplaires>();

            List<BusinessEntity.ExemplairesLecteurs> myListBus = BusinessLayer.Exemplaire.LoadAllCopyEF(biblio);
            foreach (var item in myListBus)
            {
                clsexemplaires cls = new clsexemplaires
                {
                    code = item.code,
                    IdExem = item.IdExemplaire,
                    auteur=item.auteur,



                };
                myListSer.Add(cls);

            }
            return myListSer;
        }

        public List<clsexemplaires> SearchExemBiblio(string biblio, string nameExempl)
        {
            List<clsexemplaires> myListSer = new List<clsexemplaires>();

            List<BusinessEntity.ExemplairesLecteurs> myListBus = BusinessLayer.Exemplaire.LoadAllCopyEF(biblio,nameExempl);
            foreach (var item in myListBus)
            {
                clsexemplaires cls = new clsexemplaires
                {
                    code = item.code,
                    IdExem = item.IdExemplaire,
                    auteur=item.auteur,



                };
                myListSer.Add(cls);

            }
            return myListSer;
        }

        public DataSet LoadAllCopyCA()
        {
            DataSet oData = new DataSet();
            try
            {
                BusinessLayer.Exemplaire.LoadAllCopyCA(ref oData);

            }
            catch ( Exception ex)
            {

                throw ex;
            }
            return oData;
        }



        public void CreateExemplaire(string code, DateTime achatDt, DateTime empruntdt, int idBiblio, int idLivre)
        {
            BusinessLayer.Exemplaire.CreateExemplaire(code,achatDt,empruntdt,idBiblio,idLivre);
        }

        public void  VerifiNbreExemDispo(string biblio,string livre)
        {
             
            

            try
            {
                 BusinessLayer.Retards.LoadCountExemplaires(biblio, livre);


               


            }
            catch (BusinessError.CustomError ex)
            {

                throw ex;
                
            }

          
        }
        public int VerifiNbreExemDispoAdo(string biblio, string livre)

        {
            return BusinessLayer.Retards.LoadCountExemplairesADo(biblio, livre);
        }

        public DataSet GetCountAll()
        {
            try
            {
                DataSet oData = new DataSet();
                BusinessLayer.Exemplaire.LoadAllCopyCount(ref oData);
                return oData;
            }
            catch (Exception)
            {

                throw;
            }
        
         }

    }
 }

