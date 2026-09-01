//1690702012 Jirawich Wongthong 129C
using System.Runtime.Intrinsics.Arm;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //===== KIRIN SAVE CONVERTER =====

            Console.WriteLine($"boss: {bossName}" + 
                $"\nRank: {rank}");
            Console.WriteLine($"level: {level}");
            Console.WriteLine($"currentHp/maxHp: {currentHp}/{maxHp}");
            Console.WriteLine($"attackPower: {attackPower}");
            Console.WriteLine($"critMultiplier: {critMultiplier}");
            Console.WriteLine($"isBoss: {isBoss}");
            Console.WriteLine("");
            
            //=====Implicit Conversion: HP as double=====
            double currentHpAsDouble = currentHp;
            Console.WriteLine("===Implicit Conversion: HP as double===");
            Console.WriteLine($"currentHp (double): {currentHpAsDouble}");
            Console.WriteLine("");

            //=====Exact HP Percent=====
            double hpPercentexact = currentHp * 100 / maxHp;
            Console.WriteLine("===Exact HP Percent===");
            Console.WriteLine($"HP Percent: {hpPercentexact}%");
            Console.WriteLine("");

            //=====Explicit Cast: Attack Power -> Display Int=====
            int attackPowerAsInt = (int)attackPower;
            Console.WriteLine("===Explicit Cast: Attack Power -> Display Int===");
            Console.WriteLine($"Attack Power (int): {attackPowerAsInt}");
            Console.WriteLine("");

            //=====Cast vs Convert: Crit Multiplier=====
            int critMultiplierAsInt = Convert.ToInt32(critMultiplier);
            Console.WriteLine("===Cast vs Convert: Crit Multiplier===");
            Console.WriteLine($"Crit Multiplier (int) cast: {(int)1.75}");
            Console.WriteLine($"Crit Multiplier (int): {critMultiplierAsInt}");
        }
    }
}
