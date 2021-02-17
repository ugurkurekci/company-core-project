using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Region : IEntity
    {
        [RequiredProperty]
        public int RegionId { get; set; }
        [RequiredProperty]
        public string RegionDescription { get; set; }       
    }
}
