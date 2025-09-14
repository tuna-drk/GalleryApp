using Microsoft.AspNetCore.Identity;

namespace GalleryApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }

        [PersonalData]
        public string? LastName { get; set; }

        [PersonalData]
        public string? ProfilePicture { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime LastLoginDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
