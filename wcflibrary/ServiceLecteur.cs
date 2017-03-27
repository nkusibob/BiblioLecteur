using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLecteur" in both code and config file together.
    public class ServiceLecteur : IServiceLecteur
    {
       
        public List<clsLecteur> getAll(string user,string pass,string biblio)
        {
            List<clsLecteur> res = new List<clsLecteur>();
            List<BusinessEntity.Lecteur> lis = BusinessLayer.Lecteur.loadAllReaders(user,pass,biblio);
            foreach (var lec in lis)
            {
                clsLecteur cl = new clsLecteur()
                {
                    id=lec.id,
                    userName = lec.UserName,
                    password = lec.password,
                    biblioPrincipale = lec.password,
                };
                res.Add(cl);

            }
            return res;
        }
    }
}
