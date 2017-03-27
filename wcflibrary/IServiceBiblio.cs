using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceBiblio" in both code and config file together.
    [ServiceContract]
    public interface IServiceBiblio
    {
        [OperationContract]
        List<clsBiblio> Select_BiblioPrincipale(string user);
        [OperationContract]
        string Select_BiblioPrincipaleAdo(string user);

        [OperationContract]
        List<clsBiblio> GetAll();
    }

    [DataContract]
    public class clsBiblio




    {
        [DataMember]
        public string libellé { get; set; }
       


    }

}

  


