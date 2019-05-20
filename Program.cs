using System;

class Program {

  public static int n = 0;
  public static User[] users = new User[2];
  public static int i = 0;

  // ==== User Commands ==== //
  public static string quit = "00";

  // ==== Begin Main Function ==== //
  public static void Main(string[] args) {

    // ==== User Commands ==== //
    string enter_interface = "77";

    string user_input = "zz";

    while (user_input != quit) {

      Console.WriteLine("\n\n \t\t--- Welcome To Blinks! ---");

      Console.WriteLine("\n\n** Please Type 00 To Quit **");
      Console.WriteLine("** Please Type 77 To Enter Interface **\n\n");

      Console.Write("Enter Code: ");
      user_input = Console.ReadLine();

      if (user_input == quit) {
        Console.WriteLine("Bye!");
        return;
      } else if (user_input == enter_interface) {
        Console.WriteLine("Entering Interface.....");
        user_interface();
      } else {
        continue;
      }

    }














  }
  // ==== End Main Function ==== //

  public static void create_user() {

    users[n] = new User();

    Console.WriteLine("\n\nWhat Is Your First Name?: ");
    users[n].first_name = Console.ReadLine();

    Console.WriteLine("What Is Your Last Name?: ");
    users[n].last_name = Console.ReadLine();

    Console.WriteLine("What Would You Like Your Username To Be?: ");
    users[n].user_name = Console.ReadLine();

    Console.WriteLine("Now Enter Your Super Secret Password: ");
    users[n].password = Console.ReadLine();

    users[n].identifier = n;

    Console.WriteLine("\n\n ** Welcome " + users[n].user_name + ", Your Identifier Is { " + users[n].identifier + " } **\n\n");

    n++;
  }

  public static void user_interface() {

    // ==== User Commands ==== //
    string sign_in = "11";
    string register = "22";
    string take_quiz = "33";
    string check_profile = "44";

    string user_input = "zz";

    while (user_input != quit) {

      Console.WriteLine("\n\n** Please Type 00 To Quit **");
      Console.WriteLine("** Please Type 11 To Sign In **");
      Console.WriteLine("** Please Type 22 To Register **");
      Console.WriteLine("** Please Type 33 To Take Quiz **");
      Console.WriteLine("** Please Type 44 To Check Profile **\n\n");

      Console.Write("Enter Code: ");
      user_input = Console.ReadLine();

      if (user_input == quit) {
        break;
      } else if (user_input == sign_in) {
        Console.WriteLine("Taking Your To The Sign In Page....");
        int complete = sign_user_in();
        if (complete > 0) {
          sign_in_interface();
        }
        complete = 0;
      } else if (user_input == register) {
        Console.WriteLine("Taking You To The Register Page....");
        create_user();
      } else if (user_input == take_quiz) {
        Console.WriteLine("Taking You To The Quiz Page....");
      } else if (user_input == check_profile) {
        Console.WriteLine("Taking You To Your Profile....");
        int done = sign_user_in();
        if (done > 0 && n > 0) print_profile();
        i = 0;
      } else {
        continue;
      }
    }

  }

  public static int sign_user_in() {

    int user_input = 911;
    string user_name = "zz";
    string password = "zz";
    int success = 1;
    int fail = 0;

    if (n == 0) {
      Console.WriteLine("\n\n** Sorry There Are No User's Here.... **\n\n");
      return fail;
    }

    try {
      Console.WriteLine("\n\nPlease Enter Your Identifier: ");
      user_input = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e) {
      Console.Write("\n\n** ");
      Console.Write(e.Message);
      Console.Write(" **");
    }
    Console.WriteLine("");

    if (user_input >= n) {
      Console.WriteLine("\n\n** Sorry That User Doesn't Exist.... **\n\n");
      return fail;
    }

    i = user_input;

    while (user_name != users[user_input].user_name) {

      Console.WriteLine("Enter Your Username: ");
      user_name = Console.ReadLine();

      if (user_name == users[user_input].user_name) {
        Console.WriteLine("\n** Perfect! **\n");
        break;
      } else {
        Console.WriteLine("\n\n** Incorrect Username **\n\n");
        continue;
      }
    }

    Console.WriteLine("Enter You Password: ");
    password = Console.ReadLine();

    if (password == users[user_input].password) {
      Console.WriteLine("\n\n** Welcome Back " + users[user_input].user_name + ", Your Have Successfully Signed In **\n\n");
      return success;
    } else {
      Console.WriteLine("\n\n** Incorrect Password **\n\n");
      i = 0;
      return fail;
    }

  }

  public static void sign_in_interface() {

    // ==== User Commands ==== //
    string log_out = "11";
    string take_quiz = "22";
    string check_profile = "33";
    string update_profile = "44";

    string user_input = "zz";

    while (user_input != quit || user_input != log_out) {

      Console.WriteLine("\n\n** Please Type 11 To Log Out **");
      Console.WriteLine("** Please Type 22 To Take Quiz **");
      Console.WriteLine("** Please Type 33 To Check Profile **");
      Console.WriteLine("** Please Type 44 To Update Profile **\n\n");

      Console.Write("Enter Code: ");
      user_input = Console.ReadLine();

      if (user_input == log_out) {
        i = 0;
        Console.WriteLine("\n\n**" + users[i].user_name + " Has Been Successfully Logged Out! **\n\n");
        return;
      } else if (user_input == take_quiz) {
        // do something
      } else if (user_input == check_profile) {
        print_profile();
      } else if (user_input == update_profile) {
        update_user();
      }
      else {
        continue;
      }

    }

  }

  public static void print_profile() {

    for (int j = 0; j < 120; j++) {
      Console.Write("=");
    }
    Console.WriteLine("");

    Console.Write("First Name: { " + users[i].first_name + " }\t||\t");
    Console.Write("Last Name: { " + users[i].last_name + " }\t||\t");
    Console.Write("Username: { " + users[i].user_name + " }\t|| \n");

    for (int j = 0; j < 120; j++) {
      Console.Write("=");
    }
    Console.WriteLine("");

  }

  public static void update_user() {

    // ==== User Commands ==== //
    string first_name = "11";
    string last_name = "22";
    string user_name = "33";
    string password = "44";

    string user_input = "zz";

    while (user_input != quit) {

      Console.WriteLine("\n\n** Please Type 00 To Quit **");
      Console.WriteLine("** Please Type 11 To Update First Name **");
      Console.WriteLine("** Please Type 22 To Update Last Name **");
      Console.WriteLine("** Please Type 33 To Update Username **");
      Console.WriteLine("** Please Type 44 To Update Password **\n\n");

      password = "44";

      Console.Write("Enter Code: ");
      user_input = Console.ReadLine();

      if (user_input == first_name) {
        Console.Write("Enter New First Name: ");
        users[i].first_name = Console.ReadLine();
        Console.WriteLine("** Your First Name Has Been Successfully Updated!! **\n");
      } else if (user_input == last_name) {
        Console.Write("Enter New Last Name: ");
        users[i].last_name = Console.ReadLine();
        Console.WriteLine("** Your Last Name Has Been Successfully Updated!! **\n");
      } else if (user_input == user_name) {
        Console.Write("Enter New Username: ");
        users[i].user_name = Console.ReadLine();
        Console.WriteLine("** Your Username Has Been Successfully Updated!! **\n");
      } else if (user_input == password) {
        Console.WriteLine("** --- Please Enter Your Old Password --- **");
        Console.Write("Enter Old Password: ");
        password = Console.ReadLine();
        if (password == users[i].password) {
          Console.Write("Enter New Password: ");
          users[i].password = Console.ReadLine();
          Console.WriteLine("** Your Password Has Been Successfully Updated!! **\n");
        } else {
          Console.WriteLine("** --- Sorry Incorrect Password --- **");
          continue;
        }
      } else {
        continue;
      }

    }

  }

}
