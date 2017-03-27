using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBiblio" in both code and config file together.
    public class ServiceBiblio : IServiceBiblio
    {
       

        public List<clsBiblio> GetAll()
        {
            try
            {

                List<clsBiblio> oDataList = new List<clsBiblio>().ToList();

                List<BusinessEntity.Biblio> mesBiblio = BusinessLayer.Biblio.LoadAllLIbrary();

                foreach (var item in mesBiblio)
                {
                    clsBiblio cls = new clsBiblio()

                    {
                        //id =item.id,
                        //code = item.code,

                        libellé = item.libellé,



                    };
                    oDataList.Add(cls);

                }



                return oDataList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<clsBiblio> Select_BiblioPrincipale(string user)
        {
            try
            {
                List<clsBiblio> oDataList = new List<clsBiblio>().ToList();

                List<BusinessEntity.Biblio> mesBiblio = BusinessLayer.Biblio.LoadMAjorLibrary(user);

                foreach (var item in mesBiblio)
                {
                    clsBiblio cls = new clsBiblio()

                    {
                        //id =item.id,
                        //code = item.code,

                        libellé = item.libellé,



                    };
                    oDataList.Add(cls);

                }



                return oDataList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string Select_BiblioPrincipaleAdo(string user)
        {
            try
            {
                return BusinessLayer.Biblio.LoadMAjorLibraryAdo(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
     }
    }

