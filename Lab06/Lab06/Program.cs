/*
 * Student ID : 1690702012
 * Name       : Jirawich Wongthong
 * Section    : 129C
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 * -- ป่วย week06 เนื่องจากท้องเสีย (เข้า class online แทน) --
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Your level (1-99): ");
            //bool inputLevel = int.TryParse(Console.ReadLine(), out int level);

            //if (!inputLevel || level <1 || level >99)
            {
                //Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            //if (level <= 0 )
            {
                //Console.WriteLine($"Your level is {level}");
            }
            //else
            {
                //Console.WriteLine("You ALIVE");
            }

            //bool ispoisoned = true;
            //bool haspotion = true;
            //if (ispoisoned == true && haspotion)
            {
                //Console.WriteLine("Got Poisoned You Heal EHEH");
            }
            //else if (ispoisoned == false)
            {
                //Console.WriteLine("You are not poisoned");
            }
            //else if (ispoisoned == true && haspotion == false)
            {
                //Console.WriteLine("You are poisoned and have no potion");
            }
            //else
            {
                //Console.WriteLine("You are not poisoned and have no potion");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            // Class Example
            // Lab06 Game Context
            Console.WriteLine("Your Character Gear Value(1-10): ");
            bool inputGearValue = int.TryParse(Console.ReadLine(), out int gearV);
            if (!inputGearValue || gearV < 1 || gearV > 10)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            if (gearV <= 3)
            {
                Console.WriteLine("Your Gear Value is to low");
            }
            if (gearV >= 4 && gearV <= 6)
            {
                Console.WriteLine($"Your Gear Value is good");
                Console.WriteLine("You are ready to fight boss");
                Console.WriteLine("Choose Character Buff(D,H,S): ");
                bool inputBuff = char.TryParse(Console.ReadLine(), out char buff);
                if (!inputBuff || (buff != 'D' && buff != 'H' && buff != 'S'))
                {
                    Console.WriteLine("Invalid input. Please enter a valid character (D, H, S): ");
                    return;
                }

                if (buff == 'D')
                {
                    Console.WriteLine("Damage +10%");
                }
                else if(buff == 'H')
                {
                    Console.WriteLine("Health +10%");
                }
                else if(buff == 'S')
                {
                    Console.WriteLine("Speed +10%");
                }
                return;
            }

            if (gearV >= 7 && gearV <= 9)
            {
                Console.WriteLine("Stop Smurfing And Go To Your Level");
            }
            else
            {
                Console.WriteLine("WTH Are you doing with this gear at this level you already max gear.");
            }
        }
    }
}
