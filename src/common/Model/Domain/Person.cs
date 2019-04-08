using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Person
    {
        [Key]
        public long PersonId { get; set; }
        public string Name { get; set; }
    }
}
