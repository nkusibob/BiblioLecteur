using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Reservations
    {
        //elle charge les reservations par user  et non les retards 
        //testing entity that was the purpose
        public static List<Reservation> LoadAllReservationEF(string nomBiblio,string userName)

        {
            List<Reservation> malisteReservation = new List<Reservation>();

            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
                

                List<User_ReservationParBiblio_Select_Result> maliste = dbcontext.User_ReservationParBiblio_Select(nomBiblio,userName).ToList();
                var x = from p in maliste
                        select new Reservation
                        {
                           livreTitle=p.code,
                           
                           
                          
                        };
                foreach (var item in x)
                {
                    malisteReservation.Add(item);
                }


            }
            return malisteReservation;
        }

        public static void InsertReservations(string nomLivre,string UserName)
        {
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
                try
                {
                    dbcontext.InsertReservations(nomLivre, UserName);
                }
                catch (SqlException exSQL)
                {
                    int IdError = 999;
                    switch (exSQL.Number)
                    {
                        case 18456:
                            IdError = 1;
                            break;
                    }

                    throw new BusinessError.CustomError(IdError);

                }
                catch (Exception ex)
                {
                    int IdError = 999;

                    throw new BusinessError.CustomError(IdError);


                }
            }
        }

        public static List<GeneralReservation> LoadAllReservationEF( string userName)

        {
            List<GeneralReservation> malisteReservation = new List<GeneralReservation>();

            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
                

                List<NbreExemplaireParBiblio_SelectAll_Result> maliste = dbcontext.NbreExemplaireParBiblio_SelectAll(userName).ToList();

                var x = from p in maliste
                        select new GeneralReservation
                        {
                           biblio=p.biblio,
                           NbrExemplaireDispo=p.NbreDispoNow,
                           livreTitle=p.titre


                        };
                foreach (var item in x)
                {
                    malisteReservation.Add(item);
                }


            }
            return malisteReservation;
        }
        public static DataSet LoadReservationEF(string nomBiblio, string userName)


        {
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;


            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "titre";
            table.Columns.Add(column);
            DataSet ds = new DataSet();
            ds.Tables.Add(table);
            using (bibliothequeEntities dbcontext = new bibliothequeEntities())
            {
               

                List<User_ReservationParBiblio_Select_Result> maliste = dbcontext.User_ReservationParBiblio_Select(nomBiblio, userName).ToList();
                var x = from p in maliste
                        select new Reservation

                        {
                           livreTitle=p.nom,
                           
                          


                        };
                foreach (var item in x)
                {
                    row = table.NewRow();
                    row["id"] = item.idLivre;
                    row["titre"] = item.livreTitle;
                   
                    ds.Tables[0].Rows.Add(row);
                }


            }
            return ds;
        }


    }
}
