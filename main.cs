using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
  double [] celsius = new double [7];
  double [] Fahrenheit = new double [7];
  
  for (int i=0; i<=6; i++)
  {
    Console.WriteLine ("Enter Tempurature in Celsius");
    celsius [i] =  Convert.ToDouble(Console.ReadLine());   
    Fahrenheit [i] = (celsius [i] * 9)/5 + 32; 
  }

  Console.WriteLine ("Temperature in Fahrenheit");
  Array.Reverse(Fahrenheit);
  for (int i=0; i<=6; i++)
  {
    Console.WriteLine (Fahrenheit[i]); 
  }
  
  
  double average = Fahrenheit.Sum()/ 7;
  Console.WriteLine ("Average weekly temperature is " + average + "degrees Fahrenheit");

     
    

    

    
  

  }
}