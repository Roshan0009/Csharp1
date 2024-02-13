//Assignment C#
//Roshan Lamichhane
//C0916262
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_RoseBlanches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much did you receive money ($)? ");
            int totalMoney = int.Parse(Console.ReadLine());

            // Calculating the allocations
            int booksAndSupplies = (int)(0.75 * totalMoney);
            int remainingMoney = totalMoney - booksAndSupplies;
            int portionForEach = remainingMoney / 3;

            // this are the prices
            int coffeePrice = 2;
            int flashComputerPrice = 4;
            int subwayTicketPrice = 3;

            // this is the calculation of quantaties
            int coffees = portionForEach / coffeePrice;
            int flashComputers = portionForEach / flashComputerPrice;
            int subwayTickets = portionForEach / subwayTicketPrice;

            // calculation of remaining money for roses
            int moneyForRoses = remainingMoney - (coffees * coffeePrice + flashComputers * flashComputerPrice + subwayTickets * subwayTicketPrice);

            // dispaying the output
            Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");
            Console.WriteLine("You can then buy:");
            Console.WriteLine($"{coffees} coffees");
            Console.WriteLine($"{flashComputers} Flash Computer Numbers");
            Console.WriteLine($"{subwayTickets} subway Tickets");
            Console.WriteLine($"and you will have {moneyForRoses} dollars for the white roses.");
        
    }
    }
}
