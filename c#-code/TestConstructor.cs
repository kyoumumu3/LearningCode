using System;

namespace Encio {
  class Ash {
    // Create some fields
    public char grade;
    public int score;
    
    // Create a constructor
    public Ash(char gr, int scr) {
      grade = gr;
      score = scr;
    }
    
    // Create main method
    static void Main(string[] args) {
      // Call the fields from object

      // First object
      Ash tony = new Ash(
         'B', 
          75
        );
      
      // Second object
      Ash redfield = new Ash(
          'A', 
          90
        );
        
      // Third and last object
      Ash nikolai = new Ash(
          'C', 
          65
        );
      
      // Create a string for user input
      string houndwolf;
      
      // Startup
      Console.WriteLine("Hello, ");
      Console.WriteLine("Enter your name");
      Console.Write(">>> ");
      
      // Grab the user input
      houndwolf = Console.ReadLine();
      
      // Create what-if statement from user input
      if (houndwolf == "Tony Redgrave") {
        Console.WriteLine($"Your grade is {tony.grade}.");
        Console.WriteLine($"Your score is {tony.score}.");
      }
      else if (houndwolf == "Carlos Redfield") {
        Console.WriteLine($"Your grade is {redfield.grade}.");
        Console.WriteLine($"Your score is {redfield.score}.");
      }
      else if (houndwolf == "Nikolai Reznov") {
        Console.WriteLine($"Your grade is {nikolai.grade}.");
        Console.WriteLine($"Your score is {nikolai.score}.");
      };
      
      // Create goodbye words
      Console.WriteLine($"Congratulations, {houndwolf}.");
    }
  }
}