using System.ComponentModel.DataAnnotations;

namespace PizzaPan.PresentationLayer.Models
{
    public class RegisterViewModel
    {
       /* [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string Surname { get; set; }*/

        [Required(ErrorMessage = "Email alanı boş geçilemez.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Kullanıcı ad alanı boş geçilemez.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Sifre alanı boş geçilemez.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Sifreler Uyumlu Değil")]
        public string ConfirmPassword { get; set; }
    }
}
