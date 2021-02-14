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
        public string NewProductName { get; set; }
        public int NewProductPrice { get; set; }
        public int NewProductQuantity { get; set; }
        public string NewProductImage { get; set; }
    }
}
