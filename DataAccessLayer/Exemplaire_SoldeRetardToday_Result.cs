//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    
    public partial class Exemplaire_SoldeRetardToday_Result
    {
        public string nom { get; set; }
        public decimal prixEmprunt { get; set; }
        public string titre { get; set; }
        public int exemplaireID { get; set; }
        public Nullable<System.DateTime> date_emprunt { get; set; }
        public Nullable<decimal> solde { get; set; }
        public Nullable<System.DateTime> date_de_retour { get; set; }
    }
}
