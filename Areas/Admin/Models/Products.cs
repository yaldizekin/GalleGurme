using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace GalleGurme.Areas.Admin.Models
{
    public class Products 
    {
        
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
  

    }
}
