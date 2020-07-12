using System;
using System.Collections.Generic;

namespace WeatherBoy.Models {
 public class LocationDataModel {
  public string title { get; set; }
  public string location_type { get; set; }
  public int woeid { get; set; }
  public string latt_long { get; set; }
 }

}