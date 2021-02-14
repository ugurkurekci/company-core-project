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
        public string BuyerName { get; set; }
        public string BuyerSurname { get; set; }
        public string BuyerProject { get; set; }
        public int BuyerPrice { get; set; }
        public int BuyerQuantity { get; set; }
        public string BuyerImage { get; set; }



    }
}
