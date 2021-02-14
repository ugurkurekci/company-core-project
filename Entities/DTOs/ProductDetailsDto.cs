using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailsDto : IDto
    {       
        public string ProductName { get; set; }
        public string BuyerName { get; set; }

    }
}
