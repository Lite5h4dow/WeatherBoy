namespace WeatherBoy.Models {
 public class ValidWeatherModel {
  public ValidWeatherModel(bool user, WeatherApiModel weather) {
   ValidUser = user;
   Weather = weather;
  }
  public bool ValidUser { get; set; }
  public WeatherApiModel Weather { get; set; }
 }
}