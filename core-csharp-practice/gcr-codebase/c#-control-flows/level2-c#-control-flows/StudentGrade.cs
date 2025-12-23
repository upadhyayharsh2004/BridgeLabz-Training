using System;
class StudentGrade{
    public static void Main(){
        int physics=int.Parse(Console.ReadLine());
        int chemistry=int.Parse(Console.ReadLine());
        int maths=int.Parse(Console.ReadLine());
        double average=(physics+chemistry+maths)/3.0;
        if(average>=80){
            Console.WriteLine("Grade:A");
            Console.WriteLine("Remarks:Level 4,above agency-normalized standards");
        }
        else if(average>=70&&average<=79){
            Console.WriteLine("Grade:B");
            Console.WriteLine("Remarks:Level 3,at agency-normalized standards");
        }
        else if (average>=60&&average<=69){
            Console.WriteLine("Grade:C");
            Console.WriteLine("Remarks:Level 2,below but approaching standards");
        }
        else if (average>=50&&average<=59){
            Console.WriteLine("Grade:D");
            Console.WriteLine("Remarks:Level 1,well below standards");
        }
        else if (average>=40&&average<=49){
            Console.WriteLine("Grade: E");
            Console.WriteLine("Remarks:Level 1-,too below standards");
        }
        else{
            Console.WriteLine("Grade:R");
            Console.WriteLine("Remarks:Remedial standards");
        }
    }
}
