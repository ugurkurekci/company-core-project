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
        [RequiredProperty]
        public string NewCustomerName { get; set; }
        [RequiredProperty]
        public string NewCustomerSurname { get; set; }
        [RequiredProperty]
        public int NewCustomerTelephoneNo { get; set; }
        [RequiredProperty]
        public string Mail { get; set; }
        [RequiredProperty]
        public string Adress { get; set; }

    }
}
