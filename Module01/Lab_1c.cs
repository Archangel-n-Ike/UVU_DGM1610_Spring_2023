using System;

namespace Lab1c
{
    class Program
    {        
        static void Main()
        {
            string[] cars = {"Mustang", "Camaro", "Hellcat", "Corvette", "Viper", "McLaren"};
            Console.WriteLine(cars.Length);
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[5]);
        }
    }
    class Program2
    {
        static void Main()
        {
            string[] cars = {"Mustang", "Camaro", "Hellcat", "Corvette", "Viper", "McLaren"};
            Console.WriteLine(cars.Length);
            foreach (var car in cars)
            {
                Console.WriteLine("I love my " + car + ".");
            }
        }
    }

    class Program3
    {
        static void Main()
        {
            string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
            //playerTypes[1] = "Queen";

            for (var i = 0 ; i < playerTypes.Length ; i++) 
            {
                playerTypes[i] = "Queen";
            }

            foreach (var playerType in playerTypes)
            {
                Console.WriteLine(playerType);
            }
        }
    }

    class Program4
    {
        static void Main()
        {
            weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon()};
            weaponsObjs[1].weaponName = "Sword";
            weaponsObjs[2].weaponName = "Hammer";
            for (var i = 0 ; i < weaponsObjs.Length ; i++)
            {
                weaponsObjs[i].powerLevel = 2;
            }
            foreach (var item in weaponsObjs)
            {
                Console.WriteLine(item.weaponName);
                Console.WriteLine(item.powerLevel);
            }
        }
    }

    public class weapon
    {
        public string weaponName = "Axe";
        public int powerLevel = 1;
    }

    class Program5
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    
    class Program6
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
    }

    class Program7
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;  // break and continue can also be used in while loops
                }
                Console.WriteLine(i);
            }
        }
    }
}