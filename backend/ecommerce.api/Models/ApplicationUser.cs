using Microsoft.AspNetCore.Identity;

namespace ecommerce.api.Models
{
    public class ApplicationUser : IdentityUser
    {
     public string? FullName{get; set;}
     public SellerProfile? SellerProfile{get;set;}   
    }
     
}