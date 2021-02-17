using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class SoldProduct : IEntity
    {
        [Key]
        public int BuyerId { get; set; }
        [RequiredProperty]
        public string BuyerName { get; set; }
        [RequiredProperty]
        public string BuyerSurname { get; set; }
        [RequiredProperty]
        public string BuyerProject { get; set; }
        [RequiredProperty]
        public int BuyerPrice { get; set; }
        [RequiredProperty]
        public int BuyerQuantity { get; set; }
        
        public string BuyerImage { get; set; }



    }
}
