using System;

namespace Leon {
  class Scott {
    // Create some fields
    string reMake;
    int series;
    
    // Create first method
    static string Ronko () {
      /* For the purpose to make this usable.
      At least... */
      
      // Declare variable for WriteLine to return something next time
      string baker;
      
      // Declare an array to use
      string[] insik = new string[3] {
        "Resistance", 
        "Nadojiko", 
        "Plans"
      };
      
      // Assign our sentence to the variable "baker"
      baker = "RE " + insik[0];
      
      // Return the value of "baker"
      return baker;
    }
    
    // Create second method
    public long Neko () {
      // Create something to be calculated at the end
      long iteration = 10;
      return 10 + iteration;
    }
    
    // Create main method
    static void Main (string[] args) {
      // Startup
      Console.Clear();
      Console.WriteLine("Enter the series");
      Console.Write(">>>> ");
      
      // Create first object
      Scott noun = new Scott();
      
      // Grab user input first
      noun.reMake = Console.ReadLine();
      
      // Create case and check statements
      switch (noun.reMake) {
        // First case
        case "Zero":
          noun.series = 0;
          Console.WriteLine("RE" + noun.series);
          break;
        // Second case
        case "Biohazard":
          noun.series = 7;
          Console.WriteLine("RE" + noun.series);
          break;
        // Third case
        case "Village":
          noun.series = 8;
          Console.WriteLine("RE" + noun.series);
          break;
        // Default case
        default:
          noun.series = 9;
          Console.WriteLine(Ronko());
          break;
      }
      
      // Create goodbye words
      Console.WriteLine("Thanks, " + noun.Neko() + noun.series);
    }
  }
}