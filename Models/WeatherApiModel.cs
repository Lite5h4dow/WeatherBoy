using System;
using System.Collections.Generic;

namespace WeatherBoy.Models {
 public class WeatherApiModel {
  public IEnumerable<WeatherModel> consolidated_weather { get; set; }
  public DateTime time { get; set; }
  public DateTime sun_rise { get; set; }
  public DateTime sun_set { get; set; }
  public string timezone_name { get; set; }
  public LocationDataModel parent { get; set; }
  public IEnumerable<SourceModel> sources { get; set; }
  public string title { get; set; }
  public string location_type { get; set; }
  public int woeid { get; set; }
  public string latt_long { get; set; }
  public string timezone { get; set; }
 }

}