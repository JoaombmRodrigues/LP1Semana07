using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit militar = new MilitaryUnit(3,5,4);
            SettlerUnit settler = new SettlerUnit(3,1);

            militar.Move();
            settler.Move();

            Console.WriteLine($"militar health:{militar.Health}");
            Console.WriteLine($"militar cost:{militar.Cost}\n");

            Console.WriteLine($"settler health:{settler.Health}");
            Console.WriteLine($"settler cost:{settler.Cost}\n");
        }
    }
}