using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLecteur" in both code and config file together.
    [ServiceContract]
    public interface IServiceLecteur
    {
        [OperationContract]
        List<clsLecteur> getAll(string user,string pass,string biblio);

    }
    [DataContract]
    public class clsLecteur
    {
        [DataMember]
        public int id { get; set; }


        [DataMember]
        public string userName { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string biblioPrincipale { get; set; }
        

    }
}
