using System;
using System.ComponentModel.DataAnnotations;

namespace ToplantıKatılımUygulaması.Models
{
    public class ApplyModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen adınız ve soyadınızı girin.")]
        [StringLength(100, ErrorMessage = "Adınız ve soyadınız en fazla 100 karakter olabilir.")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi girin.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi girin.")]
        [StringLength(100, ErrorMessage = "E-posta adresiniz en fazla 100 karakter olabilir.")]
        [Display(Name = "E-Posta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numaranızı girin.")]
        [StringLength(15, ErrorMessage = "Telefon numaranız en fazla 15 karakter olabilir.")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen cevaplayın.")]
        [Display(Name = "Başvuru")]
        public bool Answer { get; set; }
    }
}
