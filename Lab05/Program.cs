namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game Title
            Console.WriteLine("===IHATETHISGAME===");
            Console.WriteLine("Hero vs Monster,Damage Caculator");

            //Hero Stat input HP ATK DEF
            Console.WriteLine("Hero Health: ");
            bool HeroIsHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool HeroIsAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool HeroIsDef = int.TryParse(Console.ReadLine(), out int heroDef);
            Console.WriteLine("----------------------");

            //Monster Stat input
            Console.WriteLine("Monster Health: ");
            bool MonsIsHp = int.TryParse(Console.ReadLine(), out int MonsHp);
            Console.WriteLine("Monster Attack: ");
            bool MonsIsAtk = int.TryParse(Console.ReadLine(), out int MonsAtk);
            Console.WriteLine("Monster Defense: ");
            bool MonsIsDef = int.TryParse(Console.ReadLine(), out int MonsDef);

            //Input Validation
            bool IsHeroIntValid = HeroIsHp && HeroIsAtk && HeroIsDef;
            bool IsMonsIntValid = MonsIsHp && MonsIsAtk && MonsIsDef;
            Console.WriteLine($"Hero Status Valid: {IsHeroIntValid}");
            Console.WriteLine($"Monster Status Valid: {IsMonsIntValid}");

            Console.WriteLine($"[HERO]     HP:{heroHp}   ATK:{heroAtk}   DEF:{heroDef}");
            Console.WriteLine($"[MONSTER]  HP:{MonsHp}   ATK:{MonsAtk}   DEF:{MonsDef}");
            Console.WriteLine("");

            //Compound assignment operators: +=
            int PotionHeals = 8;
            heroHp += PotionHeals;
            Console.WriteLine($"\nHero use health potion +Heals {PotionHeals} Current HP: {heroHp}");
            //Arithmetic operators: +
            int NormalDmg = Math.Max(0, heroAtk - MonsDef);
            Console.WriteLine($"\nHero Attack Monster Damage Dealt : {NormalDmg}");
            //Precedence operators
            int PowerDmg = Math.Max(0, heroAtk * 2 - MonsDef);
            Console.WriteLine($"\nHero Power Attack Monster Damage Dealt : {PowerDmg}");
            //Random, Simple Percent Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101);
            bool isCrit = roll <= 77;
            int CritDmg = NormalDmg + Convert.ToInt32(isCrit) * NormalDmg;
            Console.WriteLine($"\nCrit Roll: {roll} Crit: {isCrit}");
            Console.WriteLine($"\nHero Crit Attack Monster Damage Dealt : {CritDmg}");

        }
    }
}
