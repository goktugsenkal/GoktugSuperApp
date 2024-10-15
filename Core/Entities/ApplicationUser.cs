using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }
    public string AvatarImageUrl { get; set; } = "https://placehold.co/128x128?text=User"; 
    
    public List<FuelLog>? FuelLogs { get; set; }
}