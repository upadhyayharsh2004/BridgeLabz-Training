using System;
class SpringSeason{
    public static void Main(string[]args){
        //taking integer month as input and as a variable
        int month=Convert.ToInt32(Console.ReadLine());
        //taking integer day as input and as a variable
        int day=Convert.ToInt32(Console.ReadLine());
        //checking that the season is a spring season or not using month and date
        if(((month==03 && day>=20)||(month==04))||(month==05)||(month==06 && day<=20)){
            //printing that the season is a spring season
            Console.WriteLine("Its a Spring Season");
        }
        else{
            //printing that the season is not a spring season
            Console.WriteLine("Not a Spring Season");
        }
    }
}