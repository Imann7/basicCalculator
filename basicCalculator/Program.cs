using System;


    class Calculator

    {
      static void Main()
    {

        double n1 = 0;
        double n2 = 0;
        double result = 0;

        Console.WriteLine("---------------------------");
        Console.WriteLine("   Basic Calculator (C#)");
        Console.WriteLine("---------------------------");

        Console.Write("\nEnter 1st number: ");

        n1 = Convert.ToDouble( Console.ReadLine());

        Console.Write("Enter 2nd number: ");

        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSelect operator: \n");
        Console.WriteLine("\t + : Plus");
        Console.WriteLine("\t - : Minus");
        Console.WriteLine("\t * : Multiply");
        Console.WriteLine("\t / : Divide");


        switch (Console.ReadLine())
        {
            case "+":
                result = n1+ n2;
                Console.WriteLine($"Your result is: {n1} + {n2} = " + result);
                break;
            case "-":
                result = n1 - n2;
                Console.WriteLine($"Your result is: {n1} - {n2} = " + result);
                break;
            case "*":
                result = n1 * n2;
                Console.WriteLine($"Your result is: {n1} * {n2} = " + result);
                break;
            case "/":
                result = n1 / n2;
                Console.WriteLine($"Your result is: {n1} / {n2} = " + result);
                break;
        }


        Console.ReadKey();

    }
}