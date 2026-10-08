/*
 * Student ID : 1690702012
 * Name       : Jirawich Wongthong
 * Section    : 129C
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int BossHealth = 100;
            const int PlayerHealth = 100;
            Console.Write("Boss Defense: ");
            int.TryParse(Console.ReadLine(), out int bossDefense);
            Console.WriteLine($"The Dungeon boss is arrived! HP: {BossHealth}, DEF: {bossDefense}");
            Console.WriteLine($"HP: {BossHealth}   DEF: {bossDefense}");
            Console.WriteLine("");
            Console.WriteLine("========= BATTLE MENU =========");
            Console.WriteLine("CHOOSE PLAYER TEMPORARY BUFF");
            Console.WriteLine("1) Will Power Of Sword (+10% SWORD DMG)");
            Console.WriteLine("2) Valley Of Mana Soul (+5% MANA CAPACITY)");
            Console.WriteLine("3) Shield Of Emperror (+9 SHIELD POINTS)");
            Console.WriteLine("4) Wind Of South Sea (+25% SPEED)");
            Console.Write("Choose Buff(1-4): ");
            int.TryParse(Console.ReadLine(), out int buff);

            switch (buff)
            {
                case 1:
                    Console.WriteLine("+10% SWORD DMG");
                    break;
                case 2:
                    Console.WriteLine("+5% MANA CAPACITY");
                    break;
                case 3:
                    Console.WriteLine("+9 SHIELD POINTS");
                    break;
                case 4:
                    Console.WriteLine("+25% SPEED");
                    break;
                default:
                    Console.WriteLine("No More Buff For You");
                    break;
            }
            Console.WriteLine("|-|-|-|-|SKILL|-|-|-|-|");
            Console.WriteLine("1) Dual Blade");
            Console.WriteLine("2) Lightning Bolt");
            Console.WriteLine("3) Protect Shield");
            Console.WriteLine("4) Invisible Slash");
            Console.Write("Choose Skill (1-4): ");
            int.TryParse(Console.ReadLine(), out int skill);

            switch (skill)
            {
                case 1:
                    Console.WriteLine("Charge sword attack \\");
                    break;
                case 2:
                    Console.WriteLine("Pierece the thunder out ~~");
                    break;
                case 3:
                    Console.WriteLine("Gain the armor plate +++");
                    break;
                case 4:
                    Console.WriteLine("Slas through thick fog }}");
                    break;
                default:
                    Console.WriteLine("Wrong Pick You Get Hit");
                    break;
            }
            int power = skill switch
            {
                1 => 9,
                2 => 27,
                4 => 15,
                _ => 0
            };
            int damage = Math.Max(0, power - bossDefense);
            Console.WriteLine($"Damage Dealt: {damage}");
            
            string rating = damage switch
            {
                >= 27 => "Thunder Deal So muchh DMG TT",
                >= 15 => "Stealth Slash Working.",
                > 9 => "Sword Pierece Through!",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");
        }
    }
}
