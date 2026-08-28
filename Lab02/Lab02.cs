//1690702012 Jirawich Wongthong SEC129C
namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 's';
            int level = 7;
            int maxhp = 240;
            int currenthp = 175;
            float attackpower = 42.5f;
            double critmultiplier = 1.75;
            bool isboss = true;

            Console.WriteLine("===BOSS STATUS: INITIAl===");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"CurrentHP: {currenthp} / {maxhp}");
            Console.WriteLine($"AttackPower: {attackpower}");
            Console.WriteLine($"CritMultiplier: {critmultiplier}");
            Console.WriteLine($"IsBoss: {isboss}");
            Console.WriteLine();

            int hpPercent = currenthp * 100 / maxhp;
            Console.WriteLine($"hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            currenthp = currenthp - 60;
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER DAMAGE");
            Console.WriteLine($"CurrentHP: {currenthp} / {maxhp}");
            hpPercent = currenthp * 100 / maxhp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();


            //=====Jerbao=====
            string bossName5 = "Jerbao";
            char Tier4 = 'S';
            string element4 = "None"; 
            int size4 = 500;
            int damage4 = 90;
            double ragecrit4 = 1.35;
            float HP4 = 11000f;
            double sizemultiplier4 = 1.99;
            bool ragemode4 = true;
            int itemdropchance = 1;
            double mythicdropchance = 155;

            Console.WriteLine($"Name: {bossName5}");
            Console.WriteLine($"Tier: {Tier4}");
            Console.WriteLine($"Element: {element4}");
            Console.WriteLine($"Size: {size4}");
            Console.WriteLine($"HP: {HP4}");
            Console.WriteLine($"SizeMultiplier: {sizemultiplier4}");
            Console.WriteLine($"RageMode: {ragemode4}");
            double sizeResult4 = size4 * sizemultiplier4;
            Console.WriteLine($"Size Result: {sizeResult4}");
            Console.WriteLine();
            Console.WriteLine("Jerbao makes 90 damage!");
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER HIT===");
            Console.WriteLine($"damage: {damage4} * {ragecrit4}");
            double rageDamage4 = damage4 * ragecrit4;
            Console.WriteLine($"Hit Damage: {rageDamage4}");
            Console.WriteLine();
            mythicdropchance = itemdropchance * 100 / mythicdropchance;
            Console.WriteLine($"Mythic Drop Chance: {mythicdropchance}%");
            Console.WriteLine();
            Console.WriteLine();


            //=====Rathalos=====
            string bossName2 = "Rathalos";
            char Tier = 'A';
            string element = "Fire"; 
            int size = 150;
            int damage = 40;
            double ragecrit = 1.25;
            float HP = 4500f;
            double sizemultiplier = 1.5;
            bool ragemode = true;

            Console.WriteLine($"Name: {bossName2}");
            Console.WriteLine($"Tier: {Tier}");
            Console.WriteLine($"Element: {element}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"SizeMultiplier: {sizemultiplier}");
            Console.WriteLine($"RageMode: {ragemode}");
            Console.WriteLine();

            double sizeResult = size * sizemultiplier;
            Console.WriteLine($"Size Result: {sizeResult}");
            Console.WriteLine("Rathalos makes 40 damage!");
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER HIT===");
            Console.WriteLine($"damage: {damage} * {ragecrit}");
            double rageDamage = damage * ragecrit;
            Console.WriteLine($"Hit Damage: {rageDamage}");
            Console.WriteLine();
            Console.WriteLine();


            //=====Vaal Hazak=====
            string bossName3 = "Vaal Hazak";
            char Tier2 = 'S';
            string element2 = "Dragon,Fire"; 
            int size2 = 250;
            int damage2 = 60;
            double ragecrit2 = 1.65;
            float HP2 = 9000f;
            double sizemultiplier2 = 1.5;
            bool ragemode2 = true;

            Console.WriteLine($"Name: {bossName3}");
            Console.WriteLine($"Tier: {Tier2}");
            Console.WriteLine($"Element: {element2}");
            Console.WriteLine($"Size: {size2}");
            Console.WriteLine($"HP: {HP2}");
            Console.WriteLine($"SizeMultiplier: {sizemultiplier2}");
            Console.WriteLine($"RageMode: {ragemode2}");
            double sizeResult2 = size2 * sizemultiplier2;
            Console.WriteLine($"Size Result: {sizeResult2}");
            Console.WriteLine();
            Console.WriteLine("Vaal Hazak makes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER HIT===");
            Console.WriteLine($"damage: {damage2} * {ragecrit2}");
            double rageDamage2 = damage2 * ragecrit2;
            Console.WriteLine($"Hit Damage: {rageDamage2}");
            Console.WriteLine();
            Console.WriteLine();


            //=====Deviljho=====
            string bossName4 = "Deviljho";
            char Tier3 = 'A';
            string element3 = "Dragon"; 
            int size3 = 170;
            int damage3 = 70;
            double ragecrit3 = 1.95;
            float HP3 = 8200f;
            double sizemultiplier3 = 1.15;
            bool ragemode3 = true;

            Console.WriteLine($"Name: {bossName4}");
            Console.WriteLine($"Tier: {Tier3}");
            Console.WriteLine($"Element: {element3}");
            Console.WriteLine($"Size: {size3}");
            Console.WriteLine($"HP: {HP3}");
            Console.WriteLine($"SizeMultiplier: {sizemultiplier3}");
            Console.WriteLine($"RageMode: {ragemode3}");
            double sizeResult3 = size3 * sizemultiplier3;
            Console.WriteLine($"Size Result: {sizeResult3}");
            Console.WriteLine();
            Console.WriteLine("Deviljho makes 70 damage!");
            Console.WriteLine();
            Console.WriteLine("===BOSS STATUS: AFTER HIT===");
            Console.WriteLine($"damage: {damage3} * {ragecrit3}");
            double rageDamage3 = damage3 * ragecrit3;
            Console.WriteLine($"Hit Damage: {rageDamage3}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}