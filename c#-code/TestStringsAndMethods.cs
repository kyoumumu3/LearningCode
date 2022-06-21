using System;

namespace Leon {
  class Scott {
    // Create some fields
    string reMake;
    int series;
    
    // Create first method
    static void Ronko () {
      string[] insik = new string[3] {
        "Resistance", 
        "Nadojiko", 
        "Plans"
      };
    }
    
    // Create second method
    public long Neko () {
      long iteration = 10;
      return 10 + iteration;
    }
    
    // Create main method
    static void Main (string[] args) {
      // Declaring another variable
      // ntt series;
      
      // Startup
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
      }
      
      // Create goodbye words
      Console.WriteLine("Thanks, " + noun.Neko() + noun.series);
    }
  }
}