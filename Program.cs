namespace FireEmblem
{
    class Program 
    {
        class Unit 
        {
            public string name;
            public int age;
            public void Attack() {
                Console.WriteLine("Attacking!!!");
            }
        }  
        static void Main(string[] args)
        {
            Unit Hero = new();
            Hero.name = "Zack";
            Hero.age = 33;
            Console.WriteLine(Hero.name);
            Console.WriteLine(Hero.age);
            Hero.Attack();
        }  
    }
}