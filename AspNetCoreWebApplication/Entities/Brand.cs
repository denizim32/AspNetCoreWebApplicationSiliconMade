using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApplication.Entities
{
    public class Brand  //2. oalrak burayı ekledik
    {
        public int Id { get; set; }
        [Display(Name="Marka Adı"), StringLength(50),Required(ErrorMessage="Marka Adı Boş Geçilemez!")]
        
        public string Name { get; set; }
        [Display(Name ="Marka Açıklama")]
        public string? Description { get; set; }
        [Display(Name ="Marka Logosu"), StringLength(50)]
        public string? Logo { get; set; }
        public virtual ICollection<Product> Products { get; set; } //Bunun altındakiler sonra eklendi
        public Brand()
        {
            Products = new List<Product>();
        }
    }
}
