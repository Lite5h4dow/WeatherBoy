using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WeatherBoy.Models;

namespace WeatherBoy.Pages {
 public class LoginModel : PageModel {
  private readonly ILogger<LoginModel> _logger;

  [BindProperty]
  public UserModel Login { get; set; }

  public LoginModel(ILogger<LoginModel> logger) {
   _logger = logger;
  }

  public void OnGet() {

  }

  public IActionResult OnPost() {
   if (!ModelState.IsValid)
    return new PageResult();

   //this would be where i would make a database request of some form for the login, but here im just testing against this.
   var TheUser = new UserModel("Username", "Password");

   if (TheUser.Password != Login.Password || TheUser.Username != Login.Username)
    return new PageResult();

   return RedirectToPage("/Weather");

  }
 }
}