namespace WeatherBoy.Models {
 public class UserModel {
  public UserModel() {}
  public UserModel(string user, string pass) {
   Username = user;
   Password = pass;
  }
  public string Username { get; set; }
  public string Password { get; set; }
 }
}