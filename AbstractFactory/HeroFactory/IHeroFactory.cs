using Lab7_Nikishaev.MovementFactory;
using Lab7_Nikishaev.WeaponFactory;

namespace Lab7_Nikishaev.Inteface
{
    // класс абстрактной фабрики
    interface IHeroFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
