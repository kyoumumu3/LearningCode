using System;
using System.Threading;

namespace Komil {
  // Create an interface to use
  interface Ops {
    void operationsin();
    void operationcos();
    void operationtan();
  }
  
  // Create a class that implement "Ops" interface
  class Umbrella : Ops {
    
    // Declare some fields
    public double a;
    public double b;
    
    // Implement first method
    public void operationsin () {
      // Create the object
      Umbrella n = new Umbrella();
      
      // Start the calculation
      Console.Write("Value : ");
      n.a = Convert.ToDouble(Console.ReadLine());
      n.b = (n.a * (Math.PI)) / 180;
      Console.WriteLine("The value is " + Math.Sin(n.b));
    }
    
    // Implement second method
    public void operationcos () {
      // Create the object
      Umbrella n = new Umbrella();
      
      // Start the calculation
      Console.Write("Value : ");
      n.a = Convert.ToDouble(Console.ReadLine());
      n.b = (n.a * (Math.PI)) / 180;
      Console.WriteLine("The value is : " + Math.Cos(n.b));
    }
    
    // Implement third method
    public void operationtan () {
      // Create the object
      Umbrella n = new Umbrella();
      
      // Start the calculation
      Console.Write("Value : ");
      n.a = Convert.ToDouble(Console.ReadLine());
      n.b = (n.a * (Math.PI)) / 180;
      Console.WriteLine("The value is : " + Math.Tan(n.b));
    }
    
    // Create startup method
    public void startup () {
      
      // Clear the console and start the menu
      Console.Clear();
      Console.WriteLine("Welcome to sin-cos-tan calculator.");
      Console.WriteLine("What do you want to do?");
      
      // The Menu
      Console.WriteLine("1. Sin the value");
      Console.WriteLine("2. Cos the value");
      Console.WriteLine("3. Tan the value");
      Console.WriteLine("4. Quit");
      
      // Insert column for choice
      Console.Write("Choice : ");
    }
  }
  
  // Create real class for starting everything
  class Damnation {
    static void Main (string[] args) {
      // Create value for user input
      string degen;
      
      // Call an object for "Umbrella" class
      Umbrella hunk = new Umbrella();
      
      // Call for startup method (don't forget to create checkpoint)
      tyrell:
      hunk.startup();
      degen = Console.ReadLine();
      
      // Create cases for every user input
      switch (degen) {
        
        // First case
        case "1" :
          
          // Start the calculation
          hunk.operationsin();
          Thread.Sleep(10000);
          
          // Go back to the menu
          goto tyrell;
          
        // Second case
        case "2" :
          
          // Start the calculation
          hunk.operationcos();
          Thread.Sleep(10000);
          
          // Go back to the menu
          goto tyrell;
          
        // First case
        case "3" :
          
          // Start the calculation
          hunk.operationtan();
          Thread.Sleep(10000);
          
          // Go back to the menu
          goto tyrell;
          
        // Fourth case
        case "4" :
          Console.WriteLine("Quitting...");
          Thread.Sleep(2000);
          break;
          
        // Default case (for exception)
        default :
        
          // Create try and catch block
          try {
            
            /* Use throw function to show the custom error.
            I must use try block because otherwise it won't load throw function.
            If I somehow found a way to get around this, I will do it. */
            ArgumentOutOfRangeException err = new ArgumentOutOfRangeException("Cannot process null or out-of-range choice. Try again.");
            throw err;
          }
          
          catch (Exception f) {
            Console.WriteLine(f.Message);
          }
          
          break;
      };
      
      // Create goodbye words
      Console.WriteLine("Goodbye, world.");
    }
  }
}