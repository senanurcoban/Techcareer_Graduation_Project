using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class ContactUs
    {
        [Key]
        public int ContactUsID { get; set; }
        public string? Adress { get; set; }
        public string? ImageUrl { get; set; }
        public int? Number { get; set; }
        public string? Email { get; set; }
        public string? OpeningHours { get; set; }
    }
}
