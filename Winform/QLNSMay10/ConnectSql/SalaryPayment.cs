//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNSMay10.ConnectSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalaryPayment
    {
        public int PaymentID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string PaymentMethod { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}