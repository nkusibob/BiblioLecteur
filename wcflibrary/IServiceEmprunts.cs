using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceEmprunts" in both code and config file together.
    [ServiceContract]
    public interface IServiceEmprunts
    {
        [OperationContract]
        void InsertEmprunt(string titre, string nom, DateTime? dtRetour, string biblio);

        [OperationContract]
        void UpdateEmprunt(int id, DateTime dtRetour);
        [OperationContract]
        DataSet LoadAllEmprunt();
        [OperationContract]
        void NbreEmpruntAnnexePrincipal(string user);

        [OperationContract]
        [FaultContract(typeof(ExceptionContainer))]
        void beforeEmprunter(string livre, string user, string biblio);
        [OperationContract]
        void beforeEmprunterAdo(string livre, string user, string biblio);

        [OperationContract]
        int NbreEmpruntAnnexePrincipalAdo(string user);
        [OperationContract]
        int NbreEmpruntAnnexeAdo(string user);


        [OperationContract]
        void InsertEmpruntEF(string titre, string nom, DateTime? dtRetour, string biblio);




    }

    [DataContract]
    public class ExceptionContainer

    {
        [DataMember]
        public string errorMessage { get; set; }


    }
    public class clsCountEmprunt
    {
        [DataMember]
        public int NbreEmprunt { get; set; }
        

    }

}

