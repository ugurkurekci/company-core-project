using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class AboutMe : IEntity
    {
        [Key]
        public int aboutid { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public string Surname { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
        [RequiredProperty]
        public string Job { get; set; }
        [RequiredProperty]
        public string context { get; set; }
        [RequiredProperty]
        public string linkedin { get; set; }
        [RequiredProperty]
        public string github { get; set; }

    }
    public class RequiredPropertyAttribute : Attribute
    {

    }
}
