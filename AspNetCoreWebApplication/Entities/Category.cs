using System.ComponentModel.DataAnnotations;
namespace AspNetCoreWebApplication.Entities
{
    public class Category //3. olarak burayı ekledik
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı"), StringLength(50), Required(ErrorMessage = "Marka Adı Boş Geçilemez!")]

        public string Name { get; set; }
        [Display(Name = "Kategori Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Kategori Resmi"), StringLength(50)]
        public string? Image { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products=new List<Product>();   
        }
    }
}
