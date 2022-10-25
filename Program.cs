using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Loop_example
{
    internal class Program
    {
        static void Main(string[] args)
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
