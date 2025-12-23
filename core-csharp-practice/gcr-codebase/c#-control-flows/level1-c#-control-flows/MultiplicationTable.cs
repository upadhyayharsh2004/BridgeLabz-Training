using System;
class MultiplicationTable{
    public static void Main(string[] args){
        // Read the number entered by the user
        int number = Convert.ToInt32(Console.ReadLine());
        // Loop from 6 to 9
        for (int i = 6; i <= 9; i++){
            // Print the multiplication result in the given format
            Console.WriteLine(number + "*" + i + "=" + (number*i));
        }
    }
}
