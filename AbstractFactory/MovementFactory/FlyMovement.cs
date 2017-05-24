using System;

namespace Lab7_Nikishaev.MovementFactory
{
    /// <summary>
    /// Класс, реализующий интерфейс движения(полёт)
    /// </summary>
    class FlyMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Летим");
        }

        public int GetSpeed()
        {
            return 50;
        }
    }
}
