using System.ComponentModel.DataAnnotations;

namespace New_Web_Project.Models.Login
{
    public class User
    {

        [Key]
        public int UserId { get; set; }


        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail giriniz")]
        [Required(ErrorMessage = "Mail adresi alanı zorunludur.")]
        public string UserMail { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Lütfen şifre belirleyiniz")]
        [MaxLength(15, ErrorMessage = "Şifre 15 karakterdan uzun olamaz."),
        MinLength(8, ErrorMessage = "Şifre 8 karakterden kısa olamaz.")]
        public string UserPassword { get; set; }
    }
}
