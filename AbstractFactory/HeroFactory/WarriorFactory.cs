using Lab7_Nikishaev.Inteface;
using Lab7_Nikishaev.MovementFactory;
using Lab7_Nikishaev.WeaponFactory;

namespace Lab7_Nikishaev.HeroFactory
{
    // Фабрика создания бегущего героя с мечом
    class WarriorFactory : IHeroFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
