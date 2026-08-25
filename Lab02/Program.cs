namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char Rank = 's';
            int Level = 7;
            int MaxHp = 240;
            int CurrentHP = 175;
            float AttackPower = 42.5f;
            double CritMultiplier = 1.75;
            bool IsBoss = true;


            Console.WriteLine("===BOSS STATUS: INITIAl===");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {Rank}");
            Console.WriteLine($"CurrentHP: {CurrentHP} / {MaxHp}");
            Console.WriteLine($"AttackPower: {AttackPower}");
            Console.WriteLine($"CritMultiplier: {CritMultiplier}");
            Console.WriteLine($"IsBoss: {IsBoss}");
            Console.WriteLine();

            int hpPercent = CurrentHP * 100 / MaxHp;
            Console.WriteLine($"hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            CurrentHP = CurrentHP - 60;
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER DAMAGE");
            Console.WriteLine($"CurrentHP: {CurrentHP} / {MaxHp}");
            hpPercent = CurrentHP * 100 / MaxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

        }
    }
}
