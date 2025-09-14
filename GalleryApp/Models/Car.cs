using System.ComponentModel.DataAnnotations;

namespace GalleryApp.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Araba Adı Zorunludur")]
        [StringLength(100, ErrorMessage = "Araba Adı en fazla 100 karakter olabilir")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Marka Zorunludur")]
        [StringLength(50, ErrorMessage = "Marka en fazla 50 karakter olabilir")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Model Zorunludur")]
        [StringLength(50, ErrorMessage = "Model en fazla 50 karakter olabilir")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Yıl Zorunludur")]
        [Range(1900, 2024, ErrorMessage = "Yıl 1900-2024 arasında olmalıdır")]
        public int Year { get; set; }

        [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Motor Tipi Zorunludur")]
        [StringLength(50, ErrorMessage = "Motor Tipi en fazla 50 karakter olabilir")]
        public string EngineType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Motor Gücü Zorunludur")]
        [StringLength(50, ErrorMessage = "Motor Gücü en fazla 50 karakter olabilir")]
        public string Horsepower { get; set; } = string.Empty;

        [Required(ErrorMessage = "Araba Fotoğrafı Zorunludur")]
        public string ImageUrl { get; set; } = string.Empty;

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
