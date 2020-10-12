using System;

namespace fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fighter1 = "Anduin";
            string fighter2 = "Sylvanas";

            Random generator = new Random();

            int fighter1HP = 150;
            int fighter2HP = 150;

            Console.WriteLine("Hello and welcome to this amazing *interractive* game!");

            while (fighter1HP >= 0 && fighter2HP >= 0)
            {
                int dmg = generator.Next(5, 21);
                int dmg2 = generator.Next(5, 21);

                fighter1HP = fighter1HP - dmg;
                fighter2HP = fighter2HP - dmg2;

                Console.WriteLine(fighter1 + " now have" + (fighter1HP) + " hp");
                Console.WriteLine(fighter2 + " now have" + (fighter2HP) + " hp");
                Console.ReadLine();
            }

            if(fighter1HP <= 0 && fighter2HP > 0)
            {
                Console.WriteLine("Sylvanas Defeated Anduin! FOR THE HORDE!");
                Console.ReadLine();
            }

            else if (fighter2HP <= 0 && fighter1HP > 0)
            {
                Console.WriteLine("Anduin defeated Sylvanas! FOR THE ALLIANCE!");
                Console.ReadLine();
            }

            else if (fighter1HP == 0 || fighter2HP == 0)
            {
                Console.WriteLine("Its a draw, FOR THE BOTH!");
            }
            Console.ReadLine();
        }
    }
}
