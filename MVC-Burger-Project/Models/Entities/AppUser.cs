using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Burger_Project.Models.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public AppRole? AppRole { get; set; }
        public ICollection<Order>? Orders { get; set; }
        
        [NotMapped]
        public ICollection<Bill> Bills { get; set; }
    }
}
