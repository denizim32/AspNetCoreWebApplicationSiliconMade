using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApplication.Entities
{
    public class AppUser //İlk olarak burayı oluşturduk. Entities e sağ tık add class yaptık.
    {
        public int Id { get; set; } //1.adım
        [Display(Name="Kullanıcı Adı"), StringLength(50)]
        public string UserName { get; set; }
        [Display(Name = "Şifre"), StringLength(50)]
        public string Password{ get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string? Name { get; set; } // ? işareti bu alanın nullable yani boş geçilebilir olmasını sağlar
        [Display(Name = "Soyadı"), StringLength(50)]                                  // 
        public string? Surname { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin?")]
        public bool IsAdmin { get; set; }
    }
}
