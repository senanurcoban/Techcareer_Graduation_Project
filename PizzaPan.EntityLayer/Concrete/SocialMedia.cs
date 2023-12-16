using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public int SocialMediaName { get; set; }
        public int SocialMediaIcon { get; set; }
        public int SocialMediaUrl { get; set; }
    }
}
