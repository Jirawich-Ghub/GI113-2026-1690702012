//1690702012  Jirawich Wongthong 129C
namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(" START NEW ADVENTURE ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Name Your Hero: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Hi {playerName} Welcome To The Game!");

            //DIFFICULTY LEVEL
            Console.WriteLine("---------------------");
            Console.WriteLine("CHOOSE DIFFICULTY LEVEL");
            Console.WriteLine("---------------------");
            Console.WriteLine("SET DIFFICULTY LEVEL(1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int difficultyset);
            Console.WriteLine($"DIFFICULTY SET TO: {difficultyset}");
            Console.WriteLine("");

            //SHOP WITH TryParse
            Console.WriteLine("---------------------");
            Console.WriteLine("     POTION SHOP     ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Potion buy quantity: ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int potionQuantity);
            Console.WriteLine($"ValidInput: {isValidInput}");
            Console.WriteLine($"Potion Recieve: {potionQuantity}");
            Console.WriteLine("");

            //VOLUME
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine("");

            //SAVE FILE
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
