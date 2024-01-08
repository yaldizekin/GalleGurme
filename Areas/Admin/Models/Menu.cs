using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace GalleGurme.Areas.Admin.Models
{
    public class Menu
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string? Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
      

    }
}
