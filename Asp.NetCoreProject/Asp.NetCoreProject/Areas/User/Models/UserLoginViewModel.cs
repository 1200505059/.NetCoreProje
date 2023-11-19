using System.ComponentModel.DataAnnotations;

namespace Asp.NetCoreProject.Areas.User.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı adı")]
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz.")]
   public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz.")]
        public string Password { get; set; }




    }
}
