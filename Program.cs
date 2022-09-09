using System;
using System.Net.NetworkInformation;
using ObjectOrientation.src.Entities;

class Program
{
    public static string Sega = "Sega";


     public static void Main(string[] args)
    {
        Character Sonic = new Character("Sonic the Hedgehog", "Urchin", 15, Sega, new List<string> { "Speed" , "SpinDash"});
        Character Tails = new Character("Miles Tails Power", "Fox", 8, Sega, new List<string> { "Fly", "SpinDash" });
        Character Knucles = new Character("Knuckles the Echidna", "Echidna", 17, Sega, new List<string> { "Punch" });
        Character Shadow = new Character("Shadow the Hedgehog", "Urchin", 15, Sega, new List<string> { "Guns", "SpinDash" });
        Character Amy = new Character("Amy Rose", "Urchin", 14, Sega, new List<string> { "Hammer", "SpinDash" });
        Character Tikal = new Character("Tikal the Echidna", "Echidna", 14, Sega, new List<string> { "power of chaos emeralds" });
        Character Fiona = new Character("Fiona Fox", "Fox", 16, Sega, new List<string> { "kick" });
        
        Urchin SonicUrchin = new Urchin(Sonic);
        Fox TailsFox = new Fox(Tails);
        Urchin ShadowUrchin = new Urchin(Shadow);
        Echidna KnuclesEchidna = new Echidna(Knucles);
        Urchin AmyUrchin = new Urchin(Amy);
        Echidna TikalEchidna = new Echidna(Tikal);
        Fox FionaFox = new Fox(Fiona);

        Console.WriteLine(Sonic.ToString());
        Console.WriteLine(Tails.ToString());
        Console.WriteLine(Knucles.ToString());
        Console.WriteLine(Shadow.ToString());
        Console.WriteLine(Amy.ToString());
        Console.WriteLine(Tikal.ToString());
        Console.WriteLine(Fiona.ToString());

        Console.WriteLine(SonicUrchin.Attack());
        Console.WriteLine(TailsFox.Attack());
        Console.WriteLine(KnuclesEchidna.Attack());
        Console.WriteLine(ShadowUrchin.Attack());
        Console.WriteLine(AmyUrchin.Attack());
        Console.WriteLine(TikalEchidna.Attack());
        Console.WriteLine(FionaFox.Attack());

        Console.WriteLine(SonicUrchin.Attack(15));
        Console.WriteLine(ShadowUrchin.Attack(10));

        Console.WriteLine(KnuclesEchidna.Attack(6));
        Console.WriteLine(TikalEchidna.Attack(12));


        //   Console.WriteLine(Functions.Attack(ShadowUrchin));
        // }
        //public static class Functions
        //{
        //public static String Attack(Urchin urchin)
        //{
        //    string skillOutput = "";

        //foreach (var skills in urchin.Skill)
        // {
        //skillOutput += (skillOutput == "" ? "" : "\n") + urchin.Name + " attacks with " + skills;
        //}
        //return skillOutput;
        //}
    }
}




