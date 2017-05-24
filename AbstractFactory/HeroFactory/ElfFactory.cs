using Lab7_Nikishaev.Inteface;
using Lab7_Nikishaev.MovementFactory;
using Lab7_Nikishaev.WeaponFactory;

namespace Lab7_Nikishaev.HeroFactory
{
    // Фабрика создания летящего героя с арбалетом
    class ElfFactory : IHeroFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Bow();
        }
    }
}
