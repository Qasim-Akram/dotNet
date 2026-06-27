using System;
namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter yuor name");
            String name =  Console.ReadLine();

            char symbol = '@';
            Console.WriteLine("please enter your  age:"); 
            int age = Convert.ToInt32(Console.ReadLine());

            double heigh = 5.11;
            const String moto = "Finish what you start! ";
            Console.WriteLine("Hello! My name is " + name + " and I am " + age + " old.\nMy height is " + heigh +
                                ".\nMy Username is " + symbol + name + " and My moto is \n\t" + moto);

            Console.ReadKey();*/
            Console.WriteLine("enter the side a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side b:");
            int b = Convert.ToInt32(Console.ReadLine());

            double c = Math.Sqrt((a*a)+(b*b));
            Console.WriteLine("Your result is : "+c);
        }
    } 
} 