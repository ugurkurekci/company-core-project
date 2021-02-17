using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Authorized : IEntity
    {
        [Key]
        public int IdentificationNumber { get; set; }
        [RequiredProperty]
        public string AuthorizedName { get; set; }
        [RequiredProperty]
        public string AuthorizedSurname { get; set; }
        [RequiredProperty]
        public int AuthorizedSalary { get; set; }
        [RequiredProperty]
        public int AuthorizedDateofStart { get; set; }
        [RequiredProperty]
        public int AuthorizedDateofOut { get; set; }
    }
    
    
}
