using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace GalleGurme.Areas.Admin.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public ICollection<Products>? Products { get; set; }
        public ICollection<Menu>? Menus { get; set; }
        [Required]
        public bool IsActive { get; set; } = false;

    }
}
