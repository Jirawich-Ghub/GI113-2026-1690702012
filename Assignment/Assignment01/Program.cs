/*
 * Student ID :1690702012
 * Name       :Jirawich Wongthong
 * Section    :129C
 * No.        :8
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===WELCOME SURVIVOR TO===");
            const string GameName = "Ark Survival Ascended";
            Console.WriteLine($"{GameName}");
            Console.WriteLine("         XXXXXXXX           XXXXXXXXXXX      XXXXX   XXXXX\r\n        XX       X          XX         X     XX  X  XX  X \r\n       XX   XXX   X         XX  XXXX    X    XX  X XX  X  \r\n      XX   X   X   X        XX  X   X    X   XX  XXX  X   \r\n     XX    XXXXX    X       XX  XXXX    X    XX  X   X    \r\n    XXX              X      XX       XXX     XX     X     \r\n   XX    XXXXXXXXX    X     XX  XX   XX      XX  X   X    \r\n  XX    X         X    X    XX  X X    X     XX  XXX  X   \r\n XX    X           X    X   XX  X  X    X    XX  X XX  X  \r\nXX    X             X    X  XX  X   X    X   XX  X  XX  X \r\nXXXXXX               XXXXX  XXXXX    XXXXXX  XXXXX   XXXXX");
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("---Dododex Creature NameCard & Information---");
            Console.WriteLine("");
            Console.WriteLine("");
            //Carcharodontosaurus
            string Carcha = "Carcharodontosaurus";
            var CarchaImage = "                                        \r\n #+*****************=: : @@@        =+*=\r\n +                  :    @@@@@@@@     :=\r\n *                  = @@@@ @ @@@@ @%   =\r\n *                  : @ @@-@@@@@@  @@@ =\r\n *                    @@   *@ @@@ @  @ -\r\n *   . .  @@@ :          -%     =  *@:  \r\n *   . : =@ @   @@=  @@@@@@@@@ = @ =@@@ \r\n *     - @@@@  @@@@ =@ %  @@@@ : +-=  @ \r\n *   :--  @@   *@#@ =@@@@@@@@@= :   @@*.\r\n *         -@@# @@@       @@@@    =   =@\r\n *   @@@@@@  +     @@@    #@ @# .*@@: =@\r\n *   @  @ @ @@::: @= @@@@%    @@*  -  +*\r\n : @@  @ @@       @        @@@#@@@@@ :#@\r\n  -@  @ @  =  = %@.     @@@@@@@  @@@*% @\r\n @@   @@@    .      @@@@@ @ @@@@@ @@@  @\r\n @.@:@*     *     @@@%@ @=@@@@ @@@@@ %@@\r\n @@  *@  @@ @@@@@@@ @@@@@@@@ @@=@@@@@@:@\r\n    @@@@@@@@@ @@ @@@:@@@@@=@ @@@@@@    @\r\n *@@@@ @@@@@@@@@@ @@-@@@:@@@@@@@@     : \r\n =@@@@@@@@@@@@@@@@@@ @@@@@@@@  @@@  @@@@\r\n  @@@@@@@ @@@@@@ @@@@@@@@@: .@@*  @@@@@@\r\n     :@@@@@@ @@@@@@@@%:      @@@@ @@ @@@\r\n *   @@@@@ @@@@@@ =      @@@@@@@@@@@@@@#\r\n *   @@@@@@@@ %                 @@@@@@@#\r\n +    @@@@@@                 :-         \r\n *-=          -===========-:::       .:-\r\n =====+***========================++==-.";
            char SizeCarcha = 'L';
            int CarchaLvl = 1;
            int BaseHealthCarcha = 70000;
            int BaseStaminaCarcha = 480;
            int BaseWeightCarcha = 650;
            int BaseDamageCarcha = 100;
            float XPKillCarcha = 3000.7f;
            double LvlUpCarcha = 7.5;
            bool CarchaLayEgg = true;
            var CarchaBreed = true;
            
            Console.WriteLine($"Creature Name : {Carcha}");
            Console.WriteLine($"{CarchaImage}");
            Console.WriteLine($"Size : {SizeCarcha}");
            Console.WriteLine($"Level : {CarchaLvl}");
            Console.WriteLine($"Base Health : {BaseHealthCarcha}");
            Console.WriteLine($"Base Stamina : {BaseStaminaCarcha}");
            Console.WriteLine($"Base Weight : {BaseWeightCarcha}");
            Console.WriteLine($"Base Damage : {BaseDamageCarcha}");
            Console.WriteLine($"XP Kill : {XPKillCarcha}");
            Console.WriteLine($"Level Up : {LvlUpCarcha}");
            Console.WriteLine($"Lay Egg : {CarchaLayEgg}");
            Console.WriteLine($"Breed : {CarchaBreed}");
            Console.WriteLine("");
            //Convert & Caculating Process
            double CarchaLvlasDouble = CarchaLvl;
            Console.WriteLine($"Carcha Level(Double): {CarchaLvlasDouble}");

            int CarchaSpawnLevel = CarchaLvl + (int)(CarchaLvl * LvlUpCarcha);
            int CarchaSpawnLevelCap = CarchaLvl + Convert.ToInt32(CarchaLvl * LvlUpCarcha);
            Console.WriteLine($"Carcha Spawn Level : {CarchaSpawnLevel}");
            Console.WriteLine($"Carcha Spawn Level Cap: {CarchaSpawnLevelCap}");

        }
    }
}
