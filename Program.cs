namespace FireEmblem
{
    class Program 
    {
        class Unit 
        {
            public string name;
            public int hitpoints;
            public int level;
            public int attack;
            public int magic;
            public int skill;
            public int def;
            public int res;
            public int speed;
            public void Attack() {
                Console.WriteLine("Attacking!!!");
                int dmg = attack - def;
            }
            public void FMagicAttack(){
                Console.WriteLine("Fire!!!");
                int dmg = magic - res;
            }
            public void LevelUp() {
                level++;
            }
            private int status = 0;
            private void Romance(int n) {
                status += n;
            }
        }  
        static void Main(string[] args)
        {
            Unit Hero = new();
            Hero.name = "Zack";
            Hero.level = 1;
            Console.WriteLine(Hero.name);
            Hero.Attack();
        }  
    }
}