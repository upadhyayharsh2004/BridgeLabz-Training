using System;

class Student{
    // private variable
    private int marks = 85;
    public class Student1{
        public void ShowMarks1{
            Console.WriteLine(2);
        }
    }
    // private method
    private void ShowMarks()
    {
        Console.WriteLine("Marks: " + marks);
    }

    // public method to access private members
    public void Display()
    {
        ShowMarks();   // allowed (same class)
    }
}

class Program
{
    static void Main()
    {
        Student1 s = new Student1();
        s.ShowMarks1();   // allowed

        // ❌ NOT allowed (compile-time error)
        // s.marks;
        // s.ShowMarks();
    }
}
