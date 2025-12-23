using System;
class MultipleOfANumberOnly{
    public static void Main(string[] args){
        // Read the number entered by the user and getting input value for a variable named number below 100
        int number = Convert.ToInt32(Console.ReadLine());
        //Running a for loop backward from i = 100 to i = 1 
        for(int i=100;i>=1;i--){
            //checking that if i is divisble by number or not using if else condition
            if(i%number==0){
                //printing the data of i variable to the output screen after the if i is divisble by number
                Console.WriteLine(i);
                //continue the statmenet if you find 1 divisiblity number of a variable number
                continue;
            }
        }
    }
}