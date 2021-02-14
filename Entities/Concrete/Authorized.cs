using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Authorized :IEntity
    {
        [Key]
        public int IdentificationNumber { get; set; }
        public string AuthorizedName { get; set; }
        public string AuthorizedSurname { get; set; }
        public int AuthorizedSalary { get; set; }
        public int AuthorizedDateofStart { get; set; }
        public int AuthorizedDateofOut { get; set; }
    }
}
