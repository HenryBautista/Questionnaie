using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Career
    {
        [Key]
        public int CareerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float ExpectedResult { get; set; }

    }
}
