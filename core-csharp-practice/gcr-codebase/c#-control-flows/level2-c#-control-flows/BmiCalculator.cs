using System;
class BmiCalculator{
    public static void Main(string[] args){
        double weight=Convert.ToDouble(Console.ReadLine());
        double heightCm=Convert.ToDouble(Console.ReadLine());
        // Convert cm to meter
        double heightMeter=heightCm/100;
        // BMI formula
        double bmi=weight/(heightMeter*heightMeter);
        // Determine weight status
        if (bmi<=18.4){
            Console.WriteLine("Status: Underweight");
        }
        else if (bmi>=18.5&&bmi<=24.9){
            Console.WriteLine("Status:Normal");
        }
        else if (bmi>=25.0&&bmi<=39.9){
            Console.WriteLine("Status:Overweight");
        }
        else{
            Console.WriteLine("Status:Obese");
        }
    }
}
