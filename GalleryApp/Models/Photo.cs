using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GalleryApp.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık Zorunludur")]
        [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
        public string Title { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Fotoğraf Zorunludur")]
        public string ImageUrl { get; set; } = string.Empty;

        public DateTime UploadDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}