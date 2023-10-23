namespace FireEmblem
{
    class Program 
    {
        class Unit {
            public string name = "Clark";
        }  
     public static void Main(string[] args)
        {
            Unit Hero = new();
            Console.WriteLine(Hero.name);
        }  
    }
}