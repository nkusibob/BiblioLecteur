using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReservationsService" in both code and config file together.
    [ServiceContract]
    public interface IReservationsService
    {
        [OperationContract]
        List<clsGeneralReservation> getAllUserReservations(string userName);
        [OperationContract]
        List<clsReservation> getAllReservations(string code, string userName);
        [OperationContract]
        DataSet getReservations(string biblio, string userName);
        [OperationContract]
         void insertReservation(string nomLivre, string userName);


    }
     [DataContract]
    public class clsReservation
    {
        [DataMember]
        public string livreTitle { get; set; }
       

    }
    [DataContract]
    public class clsGeneralReservation

    {
        [DataMember]
        public string livreTitle { get; set; }
        [DataMember]
        public Nullable<int> NbreLivre { get; set; }
        [DataMember]
        public string biblio { get; set; }



    }
}

