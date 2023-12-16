using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }
        public string ImageUrl { get; set; }
    }
}
