using System;
class YoungestFriends{
    public static void Main(string[] args){
        //Take user input for the age of first friends and storing in it a firstAgeVariable 
        int firstAgeVariable = Convert.ToInt32(Console.ReadLine());
        //Take user input for the age of second friends and storing in it a secondAgeVariable
        int secondAgeVariable = Convert.ToInt32(Console.ReadLine());
        //Take user input for the age of third friends and storing in it a thirdAgeVariable
        int thirdAgeVariable = Convert.ToInt32(Console.ReadLine());
        //Take user input for the height of first friends and storing in it a firstHeightVariable 
        int firstHeightVariable = Convert.ToInt32(Console.ReadLine());
        //Take user input for the height of second friends and storing in it a secondHeightVariable
        int secondHeightVariable = Convert.ToInt32(Console.ReadLine());
        //Take user input for the height of third friends and storing in it a thirdHeightVariable
        int thirdHeightVariable = Convert.ToInt32(Console.ReadLine());
        //Finding the smallest of the 3 ages to find the youngest friend 
        if(firstAgeVariable<secondAgeVariable && firstAgeVariable<thirdAgeVariable){
            Console.WriteLine("The smallest age of younger friends out of 3 is"+" "+firstAgeVariable);
        }
        else if(firstAgeVariable>secondAgeVariable && secondAgeVariable<thirdAgeVariable){
            Console.WriteLine("The smallest age of younger friends out of 3 is"+" "+secondAgeVariable);
        }
        else if(firstAgeVariable>thirdAgeVariable && secondAgeVariable>thirdAgeVariable){
            Console.WriteLine("The smallest age of younger friends out of 3 is"+" "+thirdAgeVariable);
        }
        //Find the largest of the 3 heights to find the tallest friend 
        if(firstHeightVariable>secondHeightVariable && firstHeightVariable>thirdHeightVariable){
            Console.WriteLine("The largest height of younger friends out of 3 is"+" "+firstHeightVariable);
        }
        else if(firstHeightVariable<secondHeightVariable && secondHeightVariable>thirdHeightVariable){
            Console.WriteLine("The largest height of younger friends out of 3 is"+" "+secondHeightVariable);
        }
        else if(firstHeightVariable<thirdHeightVariable && secondHeightVariable<thirdHeightVariable){
            Console.WriteLine("The largest height of younger friends out of 3 is"+" "+thirdHeightVariable);
        }
    }
}
