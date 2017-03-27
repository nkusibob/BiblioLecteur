using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceExemplaires" in both code and config file together.
    [ServiceContract]
    public interface IServiceExemplaires
    {
        [OperationContract]
       void VerifiNbreExemDispo(string biblio,string title);

        [OperationContract]
        int VerifiNbreExemDispoAdo(string biblio, string livre);
        [OperationContract]
        DataSet GetCountAll();

        [OperationContract]
        DataSet GetAll();
        //[OperationContract]
        //DataSet Exemplaire_SelectAllretard();
        [OperationContract]
        DataSet Exemplaire_SoldeRetard();
        [OperationContract]
        DataSet Exemplaire_Solde();
        [OperationContract]
        void CreateExemplaire(string code,DateTime achatDt,DateTime empruntdt,int idBiblio,int idLivre);
        [OperationContract]

        DataSet LoadAllCopyCA();
        [OperationContract]
        List<clsexemplaires> GetAllExemBiblio(string biblio);
        [OperationContract]
        List<clsexemplaires> SearchExemBiblio(string biblio, string nameExempl);


    }
    [DataContract]
    public class clsexemplaires
    {
        
        [DataMember]
        public int IdExem { get; set; }

        [DataMember]
        public string code { get; set; }
        [DataMember]
        public DateTime achat { get; set; }
        [DataMember]
        public DateTime date_emprunt { get; set; }

        [DataMember]
        public int id_biblio { get; set; }
        [DataMember]
        public int idLivre { get; set; }


        [DataMember]
        public string auteur { get; set; }



    }


}
