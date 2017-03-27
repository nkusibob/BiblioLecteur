using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRetards" in both code and config file together.
    [ServiceContract]
    public interface IRetards
    {
        [OperationContract]
        int GetCountRetardsUsersAdo(string userName);

        [OperationContract]
         void GetCountRetardsUsers(string userName);
       

        [OperationContract]
        List<clsRetardsUsers> GetAllRetardsUsers(string userName);
       


    }

    public class clsCountRetardsUsers
    {
        [DataMember]
        public int NbreRetards { get; set; }
        [DataMember]
        public int NbreExemDispo { get; set; }

    }

    [DataContract]
     public class clsRetardsUsers
    {
        [DataMember]
        public string NomLecteur { get; set; }
        [DataMember]
        public decimal solde { get; set; }
        [DataMember]
        public decimal tarifParJour { get; set; }
        [DataMember]
        public decimal tarifRetard { get; set; }
        [DataMember]
        public decimal tarifEmprunt { get; set; }

        [DataMember]
        public int exemplaireID { get; set; }


        [DataMember]
        public string Titre { get; set; }
        [DataMember]
        public DateTime date_emprunt { get; set; }
        [DataMember]
        public DateTime date_retour { get; set; }
        [DataMember]
        public int NbrMoisAuto { get; set; }
       

    }
}
