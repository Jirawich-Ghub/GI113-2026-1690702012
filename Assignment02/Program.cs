/*
 * Student ID : 1690702012
 * Name       : Jirawic Wongtong
 * Section    : 129C
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Vibranium";
            const double SmeltRate = 0.75;
            const double SalvageRate = 0.90;
            const double MaxBatch = 300;

            Console.WriteLine("===================================");
            Console.WriteLine("==        Forging Station        ==");
            Console.WriteLine("===================================");
            Console.WriteLine($" {MaterialName} Smelting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine(" S for Smelt ");
            Console.WriteLine(" B for Salvage ");
            Console.Write(" Smelt or Salvage: ");
            string menuInput = Console.ReadLine();
            bool isMenuParsed = char.TryParse(menuInput, out char menu);
            Console.WriteLine("");
            Console.Write(" How much would you like: ");
            string amountInput = Console.ReadLine();
            bool isAmountParsed = double.TryParse(amountInput, out double amount);
            if (isAmountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuParsed && (menu == 'S' || menu == 's'))
                {
                    double ingot = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
                }
                else if (isMenuParsed && (menu == 'B' || menu == 'b'))
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Enter S or B man don't test the game bruh.");
                }
            }
            else
            {
                Console.WriteLine($"Just add number more than 0 and not more than {MaxBatch}.");
            }
        }
    }
}
