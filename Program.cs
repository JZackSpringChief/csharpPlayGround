namespace FireEmblem
{
    class Program 
    {
        class Unit 
        {
            public string name;
            public int hitpoints;
            public int attack;
            public int magic;
            public int skill;
            public int def;
            public int res;
            public int speed;
            public void Attack() {
                Console.WriteLine("Attacking!!!");
                int dmg = attack - def;
                return dmg;
            }
            public void FMagicAttack(){
                Console.WriteLine("Fire!!!");
                int dmg = magic - res;
                return dmg;
            }

        }  
        static void Main(string[] args)
        {
            Unit Hero = new();
            Hero.name = "Zack";
            Hero.age = 33;
            Console.WriteLine(Hero.name);
            Hero.Attack();
        }  
    }
}