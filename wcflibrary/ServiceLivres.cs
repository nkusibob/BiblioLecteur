using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLivres" in both code and config file together.
    public class ServiceLivres : IServiceLivres
    {

        public string getImage(string titre)
        {
            string url = "";
            try
            {
                url = BusinessLayer.Livres.getImage(titre);
                return url;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        public string getImageEF(string titre)
        {
            string url = "";

            try
            {
                url = BusinessLayer.Livres.getImageEF(titre);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return url;

        }

        public void insertLivre(string isbn, string titre, string url,string auteur)
        {
            BusinessLayer.Livres.InsertLivre(isbn, titre, url,auteur);
        }
    }
}
