//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingSystem_client.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Transaction_Bank = new HashSet<Transaction_Bank>();
        }
    
        public int AccountNo { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage ="This field is required.")]
        public string CustomerName { get; set; }
        public Nullable<int> PhoneNo { get; set; }
        public string Addrss { get; set; }
        public string MailId { get; set; }
        public Nullable<System.DateTime> DtOfOpeningAccnt { get; set; }
        public string AccountType { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "This field is required.")]
        public string Psswrd { get; set; }
        public Nullable<double> Balance { get; set; }

        public string LoginErrorMessage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_Bank> Transaction_Bank { get; set; }
    }
}