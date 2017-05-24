namespace Lab7_Nikishaev.WeaponFactory
{
    /// <summary>
    /// Интерфейс переносимое оружие
    /// </summary>
    interface IWeapon
    {
        void Hit();

        int GetDamage();
    }
}
