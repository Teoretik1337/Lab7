using System;

namespace Lab7_Nikishaev.WeaponFactory
{
    /// <summary>
    /// Класс реализующий интерфейс переносимого оружия (лук)
    /// </summary>
    class Bow : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Стреляем из лука");
        }

        public int GetDamage()
        {
            return 5;
        }
    }
}
