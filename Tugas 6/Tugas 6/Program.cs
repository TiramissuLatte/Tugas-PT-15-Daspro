using System;

namespace Daspro_Kelas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the extremely terrible darkness...");
            Console.WriteLine("you will feel a very terrible tension");
            Console.WriteLine("What is your name?");
            Novice Player = new Novice();
            Player.Name = Console.ReadLine();
            Console.Write("Hi"+Player.Name+", preparing to face death? [y/n]");
            string bReady = Console.ReadLine();
            if(bReady=="y"){
                Console.WriteLine(Player.Name+" is entering the world");
                Enemy enemy1 = new Enemy("Bakasura");
                Console.WriteLine(Player.Name+" is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+ " attacking you...");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");
                while (!Player.IsDead && !enemy1.IsDead)
                {
                    string PlayerAction = Console.ReadLine();
                    switch(PlayerAction){
                        case "1" :
                        Console.WriteLine(Player.Name+" is doing single attack");
                        enemy1.GetHit(Player.AttackPower);
                        Player.Experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.Write("Player Health : "+Player.Health+ "| Enemy Health :" +enemy1.Health);
                        break;
                        case "2" :
                        Player.Swing();
                        enemy1.GetHit(Player.AttackPower);
                        Player.Experience += 0.9f;
                        break;
                        case "3" :
                        Player.rest();
                        Console.WriteLine("Energy is being Restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(Player.Name+"is runing away...");
                        break;
                    }

                }

                Console.WriteLine(Player.Name+" get " +Player.Experience+ "experience point");

            }else{
                Console.WriteLine("Goodbye...");
                Console.Read();
            }

        }
    }
    class Novice
    {
            public int Health { get; set; }
            public string Name { get; set; }
            public int AttackPower { get; set; }
            public int SkillSlot { get; set; }
            public bool IsDead { get; set; }
            public float Experience { get; set; }
            Random rnd = new Random();

            public Novice(){
                Health = 100;
                SkillSlot = 0;
                AttackPower = 1;
                IsDead = false;
                Experience = 0f;
                Name = "Danil";
            }
            public void Swing(){
                if(SkillSlot > 0){
                Console.WriteLine("SWINGGGGG!!!");
                AttackPower = AttackPower + rnd.Next(3,11);
                SkillSlot--;
                }else{
                    Console.WriteLine("You do not have energy!");
                }

            }

            public void GetHit(int hitValue){
                Console.WriteLine(Name+" get hit by"+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();
            }

            }

            public void rest(){
                SkillSlot = 3;
                AttackPower = 1;

            }

            public void Die(){
                Console.WriteLine("You are Dead, GAME OVER!!!");
                IsDead = true;

            }
    }

    class Enemy{
        public string Name { get; set; }
        public int Health { get; set;}
        public int AttackPower { get; set;}
        public bool IsDead { get; set;}
        Random rnd = new Random();

        public Enemy(string name){
            Health = 50;
            Name = name;
        }

        public void Attack( int damage){
            AttackPower = rnd.Next(1,10);

        }

        public void GetHit( int hitValue){
            Console.WriteLine(Name+" get hit by"+hitValue);
            Health = Health - hitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }

        }

        public void Die(){
            Console.WriteLine( Name+ " is dead");
            Console.WriteLine("congratulations, you have killed one of the life-taking monsters");
            IsDead = true;

        }
    }
}