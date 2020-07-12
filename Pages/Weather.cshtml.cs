using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WeatherBoy.Models;

namespace WeatherBoy.Pages {
 public class WeatherModel : PageModel {
  private readonly ILogger<WeatherModel> _logger;

  [BindProperty]
  public WeatherApiModel APIResult { get; set; }

  public WeatherModel(ILogger<WeatherModel> logger) {
   _logger = logger;
  }

  public void OnGet() {
   WebRequest request = WebRequest.Create("https://www.metaweather.com/api/location/44544/");
   request.Method = "GET";
   HttpWebResponse response = (HttpWebResponse)request.GetResponse();

   string result;

   using(Stream stream = response.GetResponseStream()) {
    StreamReader sr = new StreamReader(stream);
    result = sr.ReadToEnd();
    sr.Close();
   }
   APIResult = JsonConvert.DeserializeObject<WeatherApiModel>(result);
  }
 }
}