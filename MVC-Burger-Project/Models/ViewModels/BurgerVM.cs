using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Burger_Project.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace MVC_Burger_Project.ModelVM
{
    public class BurgerVM
    {
        public Burger? Burger { get; set; }
        public Drink? Drink { get; set; }
        public Sauce? Sauce { get; set; }
        public Side? Side { get; set; }
        public SelectList? Categories { get; set; }
        //public int? SelectedCategoryId { get; set; }
        [Display(Name = "Picture")]
        public IFormFile? PictureFile { get; set; }
    }
}
