using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class ProductRegistration : IEntity
    {
        [Key]
        public int NewProductId { get; set; }
        [RequiredProperty]
        public string NewProductName { get; set; }
        [RequiredProperty]
        public int NewProductPrice { get; set; }
        [RequiredProperty]
        public int NewProductQuantity { get; set; }
        [RequiredProperty]
        public string NewProductImage { get; set; }
    }
}
