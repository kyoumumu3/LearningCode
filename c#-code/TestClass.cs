using System;

namespace Tein {
  class Rein {
    // Create some public attributes
    public int iteration = 50;
    public int vendetta = 100;
    
    static void Main (string[] args) {
      // Clear terminal first
      Console.Clear();
      
      // Call field from class Rein
      Rein Nasdem = new Rein();
      
      // Create user input and calculate it
      Console.WriteLine("Enter the number");
      Console.Write(">>>> ");
      int ronien = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("The calculated number is " + Nasdem.iteration * Nasdem.vendetta + ronien + " moldmeter");
      
      
    }
  }
}