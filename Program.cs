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

            // public Unit (string Name, int HitPoints, int Level, int Attack, int Magic, int Skill, int Def, int Res, int Speed)
            // {
            //     Name = name;
            //     HitPoints = hitpoints;
            //     Level = level;
            //     Attack = attack;
            //     Magic = magic;
            //     Skill = skill;
            //     Def = def;
            //     Res = res;
            //     Speed = speed;
            // }
            public string getname ()
            {
                return name;
            }
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
            private int status = 0; // encapsulatin to hide data.
            // public void relationshipup(int n) {

            // }
             // public void relationshipdown(int n) {

            // } //implement to affect romance;
            private void Romance(int n) {
                status += n;
            }
        }  
        static void Main(string[] args)
        {
            // Unit Hero = new("Zack", 23, 1, 8, 2, 10, 9, 3, 12);
            // Console.WriteLine(Hero.getname());
            Unit Hero = new();
            
            Hero.name = "Zack";
            Hero.level = 1;
            Console.WriteLine(Hero.name);
            Hero.Attack();
        }  
    }
}