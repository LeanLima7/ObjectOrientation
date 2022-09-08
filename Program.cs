using System;
using ObjectOrientation.src.Entities;

class Program 
{

public static void Main(string[] args)
    {
        //Character Sonic = new Character("Sonic the Hedgehog", "Urchin", 15, "Sonic the Hedgehog", "Speed");
        Character Tails = new Character("Miles Tails Prower", "Fox", 8, "Sonic the Hedgehog", "Fly");
        Character Knucles = new Character("Knuckles the Echidna","Echidna", 17, "Sonic the Hedgehog", "Climb");
        Character Shadow = new Character("Shadow the Hedgehog", "Urchin", 15, "Sonic the Hedgehog", "Guns");
        Character Amy = new Character("Amy Rose", "Urchin", 14, "Sonic the Hedgehog", "Hammer");

        Urchin Sonic = new Urchin("Sonic the Hedgehog", "Urchin", 15, "Sonic the Hedgehog", "Speed");

        //Console.WriteLine(Sonic.ToString());
        Console.WriteLine(Tails.ToString());
        Console.WriteLine(Knucles.ToString());
        Console.WriteLine(Shadow.ToString());
        Console.WriteLine(Amy.ToString());

        Console.WriteLine(Urichin.Attack());

    }

}


