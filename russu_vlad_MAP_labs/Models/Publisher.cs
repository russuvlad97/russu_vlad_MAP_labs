using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace russu_vlad_MAP_labs.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Publisher Name")]
        [StringLength(50)]
        public string PublisherName { get; set; }

        [StringLength(70)]
        public string Address { get; set; }

        public ICollection<PublishedBook> PublishedBooks { get; set; }
    }
}
