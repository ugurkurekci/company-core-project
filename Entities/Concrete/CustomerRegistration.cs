using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerRegistration : IEntity
    {
        [Key]
        public int NewCustomerId { get; set; }
        public string NewCustomerName { get; set; }
        public string NewCustomerSurname { get; set; }
        public int NewCustomerTelephoneNo { get; set; }
        public string Mail { get; set; }

    }
}
