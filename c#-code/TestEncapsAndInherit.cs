using System;
using System.Threading;

namespace Rounds {
    class Dumpster {
    // Declare some fields inside "Dumpster" class
    private string username;
    private string password;
    
    // Create properties for the "Dumpster" fields
    public string Username {
      get { return username; }
      set { username = value; }
    }
    
    public string Password {
      get { return password; }
      set { password = value; }
    }
    
    // Create another method fot startup
    public static void Startup() {
      // Put welcome screen and clear the console, put the checkpoint too
      Console.Clear();
      Console.WriteLine("Welcome to menu");
      
      // Put menu list
      Console.WriteLine("1. Register");
      Console.WriteLine("2. Quit");
      Console.Write("Enter choice : ");
    }
  }
  
  class Proto : Dumpster {
    // Create Main method
    static void Main (string[] args) {
      
    // Declare a variable to grab user input
    string regen;
    
    // Call the object from "Dumpster" class
    Dumpster noto = new Dumpster();
    
    // Call for "startup" and start the business
    back:
    Startup();
    regen = Console.ReadLine();
    
    // Create switch statement depends on user input
    switch(regen) {
      
      // First case
      case "1" :
        // Create user input for username
        Console.WriteLine("Enter your username");
        Console.Write(">>> ");
        noto.Username = Console.ReadLine();
        
        // Create user input for password
        Console.WriteLine("Enter your password");
        Console.Write(">>> ");
        noto.Password = Console.ReadLine();
        
        // Create goodbye words
        Console.WriteLine($"Congratulations, Mr. {noto.Username}. You're successfully registered.");
        Thread.Sleep(1000);
        goto back;
      
      // Second and last case
      case "2" :
        break;
      };
    }
  }
}