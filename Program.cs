using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loop_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Using nested ifs find the smallest of the 3 numbers.
            //Using nested ifs find the largest of the 3 numbers.
            //Get the average of all 3 numbers
            //You will need to keep track of all three numbers, and variables to keep track of which is the current min
            //and max value.Feel free to google this one.
            //Display Results
            //User enter 1, 2, and 3
            //Lowest is 1
            //Largest is 3
            //Average is 2

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());


            Console.Write("Enter number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;

            if(num1 > num2) // Num1 is greater num2
            {
                if(num1 > num3) // Num1 is greater than num3
                {
                    max = num1;
                }
                else // Num3 is greater than num 1
                {
                    max = num3;
                }
            }
            else // Num2 is greater than num1
            {
                if(num2 > num3)
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
            }

            Console.WriteLine($"{max} is the largest number");
        }

        public static void AlgrebraScaresMe()
        {
            //            Linda was selling tickets for the school play.
            //            She sold 10 more adult tickets than children tickets and
            //            she sold twice as many senior tickets as children tickets.
            try
            {
                int childrensTickets = 0;
                Console.Write("How much money was made: ");
                double total = double.Parse(Console.ReadLine());
            topOfCalculation:;

                int adultTickets = childrensTickets + 10;
                int seniorTickets = childrensTickets * 2;

                //Adult tickets cost $5,
                //children's tickets cost $2, and
                //senior tickets cost $3.
                //Linda made $700.
                double adultPrice = 5;
                double childrensPrice = 2;
                double seniorPrice = 3;


                double adultTotal = adultTickets * adultPrice;
                double seniorTotal = seniorPrice * seniorTickets;
                double childrenTotal = childrensTickets * childrensPrice;

                double ticketTotal = adultTotal + seniorTotal + childrenTotal;

                if (ticketTotal < total)
                {
                    childrensTickets++;
                    goto topOfCalculation;
                }

                Console.WriteLine($"Childrens Tickets Sold: {childrensTickets}");
                Console.WriteLine($"Lindas Total {total}");
                Console.WriteLine($"Our Total {ticketTotal}");
                Console.WriteLine();

            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }



            //
            //
            //Write an equation to represent the total ticket sales.
            //How many children's tickets were sold for the play? How many adult tickets were sold? How many senior tickets were sold?

        }
    }
}
