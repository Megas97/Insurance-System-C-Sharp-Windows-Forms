//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int Id { get; set; }
        public string LicencePlate { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    
        public virtual Office Office { get; set; }

        public string DisplayName
        {
            get
            {
                return LicencePlate + " - " + Name;
            }
        }
    }
}
