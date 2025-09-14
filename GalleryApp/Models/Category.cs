using System.ComponentModel.DataAnnotations;

namespace GalleryApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kategori Adı Zorunludur")]
        [StringLength(50, ErrorMessage = "Kategori Adı en fazla 50 karakter olabilir")]
        public string Name { get; set; } = string.Empty;

        public List<Photo> Photos { get; set; } = new();
        public List<Car> Cars { get; set; } = new();
    }
}