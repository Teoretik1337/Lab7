using System;
using Lab7_Nikishaev.HeroFactory;
using Lab7_Nikishaev.Inteface;
using Lab7_Nikishaev.MovementFactory;
using Lab7_Nikishaev.WeaponFactory;

namespace Lab7_Nikishaev
{
    class Program
    {
        static void Main()
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();
            elf.GetInfo();

            Console.WriteLine("");

            Hero voin = new Hero(new WarriorFactory());
            voin.Hit();
            voin.Run();
            voin.GetInfo();

            Console.ReadLine();
        }
    }

    // клиент - сам супергерой
    class Hero
    {
        private readonly IWeapon _weapon;
        private readonly IMovement _movement;

        public Hero(IHeroFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Run()
        {
            _movement.Move();
        }

        public void Hit()
        {
            _weapon.Hit();
        }

        public void GetInfo()
        {
            Console.WriteLine(" Урон = " + _weapon.GetDamage() + " Скорость = " + _movement.GetSpeed());
        }
    }
}
