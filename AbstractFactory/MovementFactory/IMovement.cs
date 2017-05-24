namespace Lab7_Nikishaev.MovementFactory
{
    /// <summary>
    /// Интерфейс способ передвижений
    /// </summary>
    interface IMovement
    {
        void Move();

        int GetSpeed();
    }
}
