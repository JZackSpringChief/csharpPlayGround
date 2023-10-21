using System;

namespace FireEmblem
{
   public class Unit 
    {
        public string name = "Clark";
        public static void Main(string[] args)
        {
            Unit Hero = new();
            Console.WriteLine(Hero.name);
        }   
    }
}