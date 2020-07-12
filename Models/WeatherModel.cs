using System;
namespace WeatherBoy.Models {
 public class WeatherModel {
  public Int64 id { get; set; }
  public string weather_state_name { get; set; }
  public string weather_state_abbr { get; set; }
  public string wind_direction_compass { get; set; }
  public DateTime created { get; set; }
  public DateTime applicable_date { get; set; }
  public float min_temp { get; set; }
  public float max_temp { get; set; }
  public float the_temp { get; set; }
  public float wind_speed { get; set; }
  public float wind_direction { get; set; }
  public float air_pressure { get; set; }
  public float humidity { get; set; }
  public float visibility { get; set; }
  public float predictability { get; set; }
 }
}