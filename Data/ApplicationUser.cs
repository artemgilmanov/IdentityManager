using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Data;

public class ApplicationUser : IdentityUser
{
  [Required]
  public string Name { get; set; }
}
