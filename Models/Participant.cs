using System.ComponentModel.DataAnnotations;

namespace MVC_CourseRegisterApp.Models
{
    public class Participant
    {
        [Required(ErrorMessage ="Lütfen bir isim giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen bir e-mail adresi giriniz")]
        [EmailAddress(ErrorMessage ="Lütfen doğru bir e-mail adresi giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Lütfen bir telefon numarası giriniz")]
        public string PhoneNumber { get; set; }


    }
}
