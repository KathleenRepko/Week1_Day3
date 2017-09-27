using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    // Do something
            //    Console.WriteLine("You have broken math. Good job.");
            //}
            //else
            //{
            //    // Do something else.
            //    Console.WriteLine("That makes sense.");
            //}



            //Console.WriteLine("What day is today?");
            //string userAnswer = Console.ReadLine();

            //if(userAnswer == "Monday")
            //{
            //    Console.WriteLine("Back to work.");
            //}
            //else if (userAnswer == "Friday")
            //{
            //    Console.WriteLine("TGIF!");
            //}
            //else
            //{
            //    Console.WriteLine("Bloop");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if(userAge > 1 && userAge <4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}
            //else if(userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood.");
            //}
            //else if(userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}
            //else if(userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement.");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age.");
            //}

            //Console.WriteLine("How many points did you earn?");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("You lose.");
            //        break;
            //    case 1:
            //        Console.WriteLine("Needs practice.");
            //        break;
            //    case 2:
            //        Console.WriteLine("On target.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Superstar.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Overachiever.");
            //        break;
            //    case 5:
            //        Console.WriteLine("You cheated.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid score entered.");
            //        break;
            //}

            //Kathleen's solution:
            //Console.WriteLine("Each of you will pay $13.00.");
            //Console.WriteLine("How many guests are in your party?");
            //int dinerCount = int.Parse(Console.ReadLine());

            //int dinerPayment = dinerCount * 13;
            //Console.WriteLine("Your total bill is $" + dinerPayment + ".");

            ////Daniel's solution:
            //int billPortion = 13;
            //int dinnerNumber = 4;
            //int billTotal = billPortion * dinnerNumber;
            //Console.WriteLine(billTotal);

            //Returning to the above problem,replace
            //hard-coded values of 4 (# of diners) and
            //13(cost per diner) with vaulues proficed by the user.

            Console.WriteLine("How much will each of you pay?");
            int dinerPay = int.Parse(Console.ReadLine());

            Console.WriteLine("How many guests are in your party?");
            int dinerCount = int.Parse(Console.ReadLine());

            int dinerPayment = dinerPay * dinerCount;
            Console.WriteLine("Your total bill is $" + dinerPayment + ".");

            //Customer Appreciation Week - $50+ = 10% discount; otherwise 5% discount

            Console.WriteLine("It's Customer Appreciation Week!");

            double newBill;

            if (dinerPayment >= 50)
            {
                newBill = dinerPayment * 0.9;
                Console.WriteLine("Your discounted total is $" + newBill + ".");
            }

           else
            {
                newBill = dinerPayment * 0.95;
                Console.WriteLine("Your discounted total bill is $" + newBill + "."); 
            }
            

         
         







        }
    }
}
