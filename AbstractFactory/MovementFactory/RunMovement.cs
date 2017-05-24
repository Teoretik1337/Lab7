using System;

namespace Lab7_Nikishaev.MovementFactory
{
    /// <summary>
    /// Класс, реализующий интерфейс движения(бег)
    /// </summary>
    class RunMovement : IMovement
    {
        public void Move()
        {
            Console.WriteLine("Бежим");
        }

        public int GetSpeed()
        {
            return 25;
        }
    }
}
