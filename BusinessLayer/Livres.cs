using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Livres
    {
        public static void InsertLivre(string isbn,string titre, string url,string auteur)
        {
            
            DataAccessLayer.Livres.insertLivre(isbn, titre,url,auteur);
        }

        public static string getImage(string titre)
        {
            string url = "";
            return url=DataAccessLayer.Livres.getImage(titre);
        }

        public static string getImageEF(string titre)
        {
            string url = "";
            return url = DataAccessLayer.Livres.getImageEF(titre);
        }

        
    }
} 
