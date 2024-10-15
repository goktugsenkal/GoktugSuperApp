using Api.Dtos;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
public class AccountController(UserManager<ApplicationUser> userManager) : ControllerBase
{
    [HttpPost("myregister")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(registerDto);
        }

        var user = new ApplicationUser
        {
            Email = registerDto.Email,
            UserName = registerDto.Email,
            FullName = registerDto.FullName,
            AvatarImageUrl = "https://placehold.co/256/orange/white/png?text=SuperApp\nKullanıcısı&font=roboto"
        };

        var result = await userManager.CreateAsync(user, registerDto.Password);
        
        if (result.Succeeded)
        {
            // Additional steps, like sending a confirmation email
            return Ok(new { Message = "User registered successfully" });
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error.Description);
        }

        return BadRequest(ModelState);
    }
    
}