namespace FireEmblem
{
    class Program 
    {
        class Unit {
            public string? name;
            public void Attack() {
                Console.WriteLine("Attacking!!!");
            }
        }  
     public static void Main(string[] args)
        {
            Unit Hero = new();
            // Hero.name = "Zack";
            // Console.WriteLine(name);
            Hero.Attack();
        }  
    }
}