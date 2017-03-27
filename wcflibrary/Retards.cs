using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessEntity;
using System.Windows.Forms;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Retards" in both code and config file together.
    public class Retards : IRetards
    {



        public List<clsRetardsUsers> GetAllRetardsUsers(string userName)

        {
            List<clsRetardsUsers>   oDataList = new List<clsRetardsUsers>().ToList();

            List< RetardsUsers> mesRetards= BusinessLayer.Retards.LoadAllRetardsEF(userName);

            foreach (var item in mesRetards)
            {
                clsRetardsUsers cls = new clsRetardsUsers()
                {
                    solde = (decimal)item.solde,
                    NomLecteur = item.NomLecteur,
                    date_emprunt = Convert.ToDateTime(item.date_emprunt),
                    date_retour = Convert.ToDateTime(item.date_retour),
                    NbrMoisAuto = item.NbrMoisAuto,
                    Titre = item.Titre,
                    tarifParJour=item.tarifParJour
                   


                };
                oDataList.Add(cls);
               
            }



            return oDataList;
        }
        public void beforeEmprunter(string livre ,string user,string biblio)
        {
            try
            {
                BusinessLayer.Retards.beforeEmprunter(livre, user, biblio);
            }
            catch (Exception ex)
            {
                FaultReason faultReason = new FaultReason(ex.Message);
                throw new FaultException<Exception>(ex,faultReason);
            }
        }
        public void GetCountRetardsUsers(string userName)




        {
            List<clsCountRetardsUsers> oDataList = new List<clsCountRetardsUsers>().ToList();
            try
            {

                BusinessLayer.Retards.LoadACountRetardsEF(userName);

            }
            catch (BusinessError.CustomError  ex)
            {

                throw ex;
            }




        
        }

        public int GetCountRetardsUsersAdo(string userName)
        {
            return BusinessLayer.Retards.LoadACountRetardsAdo(userName);

        }
    }

}
