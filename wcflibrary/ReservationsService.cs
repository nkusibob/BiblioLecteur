using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessEntity;
using System.Data;
using System.Windows.Forms;

namespace wcflibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservationsService" in both code and config file together.
    public class ReservationsService : IReservationsService
    {
       

        public List<clsReservation> getAllReservations(string biblio,string userName)
        {
            List<clsReservation> oDataList = new List<clsReservation>().ToList();

            List<Reservation> mesReservations = BusinessLayer.Reservations.LoadAllReservationsEF(biblio,userName);

            foreach (var item in mesReservations)
            {
                clsReservation cls = new clsReservation()

                {
                    livreTitle = item.livreTitle,
                  
                   


                };
                oDataList.Add(cls);

            }



            return oDataList;
            
        }

        public List<clsGeneralReservation> getAllUserReservations(string userName)

        {
            List<clsGeneralReservation> oDataList = new List<clsGeneralReservation>().ToList();

            List<GeneralReservation> mesReservations = BusinessLayer.Reservations.LoadAllReservationsEF(userName);

            foreach (var item in mesReservations)
            {
                clsGeneralReservation cls = new clsGeneralReservation()

                {
                    livreTitle = item.livreTitle,
                   
                   
                    NbreLivre=item.NbrExemplaireDispo,
                    biblio = item.biblio,


                };
                oDataList.Add(cls);

            }



            return oDataList;
        }
        public DataSet getReservations(string biblio, string userName)
        {
            DataSet
              oData = new DataSet();

            try
            {
                BusinessLayer.Reservations.LoadReservationEF(biblio, userName, ref oData);
            }
            catch (Exception ex)
            {

                throw ex;
            }


           


            return oData;



           

        }

        public void insertReservation(string nomLivre,string userName)
        {
            try
            {
                BusinessLayer.Reservations.InsertReservations(nomLivre, userName);
               
            }
            catch (BusinessError.CustomError ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
