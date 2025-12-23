using System;   // Used for input and output

class SwitchCaseOperation{
    static void Main(string[] args){
        // Declare two double variables
        double first, second;
        // Declare a string variable for operator
        string op;
        // Take first number input
        first = Convert.ToDouble(Console.ReadLine());
        // Take second number input
        second = Convert.ToDouble(Console.ReadLine());
        // Take operator input (+, -, *, /)
        op = Console.ReadLine();
        for (int i = 1; i < 2; i++){
            // Switch case to perform calculation
            switch (op){
                case "+":
                    Console.WriteLine("Result: " + (first + second));
                    break;

                case "-":
                    Console.WriteLine("Result: " + (first - second));
                    break;

                case "*":
                    Console.WriteLine("Result: " + (first * second));
                    break;

                case "/":
                    Console.WriteLine("Result: " + (first / second));
                    break;

                default:
                    // If operator is invalid
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
