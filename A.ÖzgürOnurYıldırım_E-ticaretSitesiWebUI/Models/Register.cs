using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A.ÖzgürOnurYıldırım_E_ticaretSitesiWebUI.Models
{
    public class Register
    {   [Required]
        [DisplayName("Adınız")]
        public string Name{ get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı adı")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Eposta Adresiniz")]
        [EmailAddress(ErrorMessage ="Eposta adresi geçerli değil")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor")]
        public string RePassword { get; set; }


    }
}