using System;
using System.Collections.Specialized;
class Task1
{
   public static void Q1()
    {
            Console.WriteLine("ENter Numbr TO Check if it is Even or odd");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
                Console.WriteLine("Number is Even", Number);
            else
                Console.WriteLine("Number is odd", Number);
        
        }
    public static void Q2()
    {
        Console.WriteLine("Enter Your Hight \"in cm\"");
        
        int Hight = Convert.ToInt32(Console.ReadLine());
      
            Console.WriteLine("Your Hight is", Hight);

    }
    
    public static void Q3()
    {
        // find largest NO of three No
        Console.WriteLine("Enter three numbers  ");
    
        int No1 = Convert.ToInt32(Console.ReadLine());
        int No2 = Convert.ToInt32(Console.ReadLine());
        int No3 = Convert.ToInt32(Console.ReadLine());
        int largest;
        if (No1 >= No2 && No1 >= No3) largest = No1;
        else if (No2 > No1 && No2 > No3) largest = No2;
        else largest = No3;
        Console.WriteLine("The Largest number is "+ largest);

    }
    public static void Main(string[] args)
    {
        Q1(); 
        Q2();
        Q3();

    }
}
