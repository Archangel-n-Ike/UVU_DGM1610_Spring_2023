using System;

namespace Challenge1c
{
    class ClassChange
    {
        static void Main()
        {
            var charClass = new beginClass();     //credit to stackoverflow for teaching me to call a variable from beginClass and beginlvl in ClassChange
                charClass.className = "Peasant";

            var charlvl = new beginlvl();
                charlvl.charlvl = 0;

            Console.WriteLine("Your current level is " + charlvl.charlvl + ".");
            Console.WriteLine("Your current class is " + charClass.className + ".");
            Console.WriteLine("Increase level? Yes(1) / No(0)");
            int lvlUp = Convert.ToInt32(Console.ReadLine());

            if (lvlUp == 1)
            {
                for (int lvl = 0; lvl < 1; lvl++)
                {
                    Console.WriteLine("Level increased to 1");
                    beginClass[] newClass = {new beginClass(), new beginClass(), new beginClass(), new beginClass()};
                    newClass[0].className = "Fighter";
                    newClass[1].className = "Rogue";
                    newClass[2].className = "Ranger";
                    newClass[3].className = "Mage";
                    foreach (var name in newClass)
                    {
                        Console.WriteLine("Available class: " + name.className);
                    }
                    Console.WriteLine("Class Change! Which Class do you want? (0-3)");
                    int realClass = Convert.ToInt32(Console.ReadLine());
                    if (realClass == 0)
                    {
                        Console.WriteLine("Class change successful! Your new class is Fighter.");
                        break;
                    }
                    if (realClass == 1)
                    {
                        Console.WriteLine("Class change successful! Your new class is Rogue.");
                        break;
                    }
                    if (realClass == 2)
                    {
                        Console.WriteLine("Class change successful! Your new class is Ranger.");
                        break;
                    }
                    if (realClass == 3)
                    {
                        Console.WriteLine("Class change successful! Your new class is Mage.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Humor me, 0-3 answers only, start over!");
                    }
                }
            }
            else if (lvlUp == 0)
            {
                Console.WriteLine("Level up canceled");
            }
            else
            {
                Console.WriteLine("Humor me, 1 or 0 only, start over!");
            }
        }
    }

    public class beginClass
    {
        public string className = "Peasant";
    }

    public class beginlvl
    {
        public int charlvl = 0;
    }
}































