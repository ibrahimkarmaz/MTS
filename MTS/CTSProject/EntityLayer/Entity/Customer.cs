using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string TCNO { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurnama { get; set; }
        public bool CustomerGender { get; set; }
        public DateTime? CustomerDateOfBirth { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerOfficePhone { get; set; }
        public string CustomerMail { get; set; }
        public DateTime? CustomerCreateDate { get; set; }
        public string CustomerCounty { get; set; }
        public string CustomerDistrict { get; set; }

        public string CustomerHomeAddress { get; set; }
        public string CustomerNote { get; set; }
        public bool Archive { get; set; }
    }
}
