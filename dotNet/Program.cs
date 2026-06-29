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

            Console.ReadKey();
            Console.WriteLine("enter the side a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side b:");
            int b = Convert.ToInt32(Console.ReadLine());

            double c = Math.Sqrt((a*a)+(b*b));
            Console.WriteLine("Your result is : "+c);*/

            /*Console.WriteLine("Enter the number of row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of colums: ");
            int column = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the symbol");
            char symbol = Convert.ToChar(Console.ReadLine());
            //simple rectangle
            for (int i = 0;i <= row;i++)
            {
                for(int j = 0;j < column; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }*/

            //gussing game
            /*Random random = new Random();
            int min=1;
            int max=100;
            bool isplaying = true;
            int guess;
            int number;
            int guesses;
            String response;

            while (isplaying)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max+1);
                Console.WriteLine("Guess the number between " + min + " and " + max + ": ");

                while (guess != number)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine("Guess is too High try smaller number!");
                    }
                    else if(guess < number)
                    {
                        Console.WriteLine("Guess is too small try bigger number!");
                    }
                    guesses++;

                }
                Console.WriteLine("\nConragulations! You Guessed it Right \n You took  " + guesses + " Guesses");
                Console.WriteLine("Do you wanna playagain (Y/N) :");
                response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    isplaying = true;
                }
                else
                {
                    isplaying = false;
                }
            }
            Console.WriteLine("Thanks for Playing!");
            */
            //rock,paper,scissors game

        }
    } 
} 