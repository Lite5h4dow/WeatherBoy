using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WeatherBoy.Pages {
 public class LoginModel : PageModel {
  private readonly ILogger<LoginModel> _logger;

  public LoginModel(ILogger<LoginModel> logger) {
   _logger = logger;
  }

  public void OnGet() {

  }
 }
}