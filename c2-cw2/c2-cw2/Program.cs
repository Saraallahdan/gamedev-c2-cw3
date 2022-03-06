
using System;
class HelloWorld
{
    static void Main()
    {
        string charecterName = "Mario";
        string superPower1 = "double cherry";
        string superPower2 = "cannon box";
        int age = 60;
        int speed = 120;
        int height = 140;
    Console.WriteLine("Hello World");
        Console.WriteLine("My name is {0} ,My  super powers are {1} and {2} , My age {3} , my speed {4}", charecterName, superPower1, superPower2, age, speed);

        int heroAge = 40;
        int heroHeight = 180;
        string heroName = "superman";
        string heroSuperPower1 = "x-ray vision";
        string heroSuperPower2 = "super speed";

        int ageDifference = age - heroAge;

 void heightCheck()
    {
        if (height > heroHeight)
        {
            Console.WriteLine("Mario is taller");
        }
        else if (heroHeight > height)
        {
            Console.WriteLine("superman is taller");
        }

    }
        heightCheck();
        int[] characterPowerValues = {120 , 100 , 90};
        Console.WriteLine(characterPowerValues[1]);

        void powersCheck()
        {
            if (characterPowerValues[0] > characterPowerValues[2])
            {
                Console.WriteLine("Mario is more powerful");
            }
            else if (characterPowerValues[2] > characterPowerValues[0])
            {
                Console.WriteLine("superman is more powerful");
            }
            else
            {
                Console.WriteLine("Neither is more powerful");
            }

        }
        powersCheck();
    }

   
}
