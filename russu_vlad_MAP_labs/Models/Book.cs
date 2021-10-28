using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace russu_vlad_MAP_labs.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        
        public ICollection<Order> Orders { get; set; }

        public ICollection<PublishedBook> PublishedBooks { get; set; }

    }
}
