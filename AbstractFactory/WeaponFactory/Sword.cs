using System;

namespace Lab7_Nikishaev.WeaponFactory
{
    /// <summary>
    /// Класс реализующий интерфейс переносимого оружия (меч)
    /// </summary>
    class Sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }

        public int GetDamage()
        {
            return 10;
        }
    }
}
