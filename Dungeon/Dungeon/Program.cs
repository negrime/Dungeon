using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Console.Write("Hello, welcome to the dungeon\n");
            Console.Write("Player 1, please enter your nickname: ");
            p1.name = Console.ReadLine();
            Console.Write("Player 2, please enter your nickname: ");
            p2.name = Console.ReadLine();
            while (p1.name == p2.name)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Player 2, please enter another  nickname: ");
                p2.name = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(p1.name + ", please pick a hero");
            int choose = 0;
            p1.character = new Mage();
            Console.Clear();
            p1.character.position = new Point(5, 0);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 0; i <= 20; i++)
                {
                    if (i < 10)
                        Console.Write(" ");
                    Console.WriteLine(i + " |");
                }

                Console.SetCursorPosition(p1.character.position.x, p1.character.position.y++);
                Console.Write(p1.character.sprite);
                Console.ReadLine();
                p1.character.Chill();
                Console.Clear();

            }


            Console.ReadLine();
        }


    }
}
