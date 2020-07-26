using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProjekt
{
    class Program
    {
        static bool noNumbers = false;
        static void Main(string[] args)
        {
            ChooseNumber(); // text that asks you to what number you want to count, which you can also enter
            Console.WriteLine(); // just to create a paragraph 

            if (noNumbers == false)
            {
                Calculate();
            }
            
            Console.ReadKey();

        }

        static int iCountNumber;
        public static int ChooseNumber()
        {
            Console.WriteLine("To which number do you want to count?");
            string sChooseNumber;
            
            // checks if the entered characters are numbers
            try
            {
                sChooseNumber = Console.ReadLine();
                // +1 because the for loop in the calculate() method checks if the variable is less than the choosen number
                iCountNumber = Convert.ToInt32(sChooseNumber) + 1;
            }
            catch
            {
                Console.Write("\n\nPlease enter only a number.\nThe Program will now be terminated.");
                noNumbers = true;
            }

            return iCountNumber;

        }

        public static void Calculate()
        {
            Console.WriteLine("Counting:");
            // counts from 1 to the choosen number
            for(int i = 1; i  < iCountNumber; i++)
            {
                // checks if the current number can be divided by 3
                if(i % 3 == 0)
                {
                    /* 
                    if the number can be divided by 15 then it outputs "fizzbuzz" if not just "fizz"
                    */
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }

                    else
                    {
                        Console.WriteLine("fizz");
                    }

                }

                // checks if the current number can be divided by 5

                else if (i % 5 == 0)
                {
                    /* 
                    if the number can be divided by 15 then it outputs "fizzbuzz" if not just "fizz"
                    */
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else
                    {
                        Console.WriteLine("buzz");
                    }

                }

                // if it can't be divided by 3, 5 (or 15) then just output the number itself 
                else
                {
                    Console.WriteLine(i);
                }

            }


        }

       
    }


}
