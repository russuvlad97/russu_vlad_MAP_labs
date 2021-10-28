using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace russu_vlad_MAP_labs.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }

        public Publisher Publisher { get; set; }
        public Book Book { get; set; }
    }
}
