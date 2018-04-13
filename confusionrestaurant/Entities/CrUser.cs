using Microsoft.AspNetCore.Identity;

namespace confusionrestaurant.Entities
{
    public class CrUser : IdentityUser
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }
}