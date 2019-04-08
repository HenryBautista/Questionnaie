using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Domain
{
    public class Site
    {
        [Key]
        public int SiteId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string url { get; set; }

        public Career Career { get; set; }
        public int CareerId { get; set; }
    }
}
