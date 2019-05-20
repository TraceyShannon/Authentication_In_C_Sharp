using System;

class User {

  public string first_name;
  public string last_name;
  public string user_name;
  public string password;
  public int identifier;
  public static int num_of_users;

  public User() {
    this.identifier = num_of_users;
    num_of_users++;
  }

  public User(string first_name, string last_name, string user_name) {
    this.first_name = first_name;
    this.last_name = last_name;
    this.user_name = user_name;
    this.identifier = num_of_users;
    num_of_users++;
  }

  public int find_identifier() {
    return this.identifier;
  }

  public void print_user() {

    int direct_user = Convert.ToInt32(Console.ReadLine());

    if (direct_user == this.identifier) {
      Console.WriteLine(this.first_name);
      Console.WriteLine(this.last_name);
      Console.WriteLine(this.user_name);
    } else {
      Console.WriteLine("Sorry I dont Recognize That User...");
    }

  }

}
