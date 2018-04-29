using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeYonetimSistemi_UI.Models
{
    public class UserPassword
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string KullaniciAdi { get; set; }
    
        
        [Required(ErrorMessage = "Lütfen Password Giriniz")]
      
        public string Password { get; set; }
    }
}