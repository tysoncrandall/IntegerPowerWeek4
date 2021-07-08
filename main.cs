using System;

class MainClass{ 

    public static int IntegerPower(int num_base, int exponent)
    {
      int counter = 0;
      int power = 1;
      while(counter < exponent)
      {
        power = power * num_base;
        counter++;
      }
      return power;
    }
    
    public static void Main (string[] args) {

      Console.WriteLine("Enter the base number: ");
      int num_base = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the exponent value: ");
      int exponent = Convert.ToInt32(Console.ReadLine());

      int answer = IntegerPower(num_base, exponent);

      Console.WriteLine("The base is: " + num_base);
      Console.WriteLine("The exponent is: " + exponent);
      Console.WriteLine("The answer is: " + answer);
      
    
    }  

  }