using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Windows.Forms;
using System.Data;

namespace BusinessLayer
{
    public class Reservations
    {
        public static List<Reservation> LoadAllReservationsEF(string biblio,string userName)
        {
            return DataAccessLayer.Reservations.LoadAllReservationEF(biblio,userName);

        }
        public static List<GeneralReservation> LoadAllReservationsEF(string userName)
        {
            return DataAccessLayer.Reservations.LoadAllReservationEF( userName);

        }
        public static void LoadReservationEF(string biblio, string userName, ref DataSet oDataSet)
        {
            DataSet oData;

            try
            {
                oData = DataAccessLayer.Reservations.LoadReservationEF(biblio, userName);

                oDataSet = oData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        public static void InsertReservations(string nomLivre, string UserName)
        {
            DataAccessLayer.Reservations.InsertReservations(nomLivre,UserName);
        }
    }
}
