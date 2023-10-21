using System;

namespace FireEmblem;
{
    public class Unit 
    {
        string name = "Clark";
        static void Main(string[] args)
        {
            Unit Hero = new Unit();
            Console.WriteLine(Hero.name);
        }   
    }
}