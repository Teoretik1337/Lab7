using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            GetInformation aA = new GetInformationInLibrary();
            aA.TemplateMethod();

            GetInformation aB = new GetInformationInInternet();
            aB.TemplateMethod();

            // Wait for user
            Console.ReadKey();
        }
    }


    /// <summary>
    /// Абстрактный класс, содержащий общее определение
    /// </summary>
    abstract class GetInformation
    {
        public abstract string Step1();
        public abstract string Step2();
        public abstract string Step3();
        public abstract string Step4();

        /// <summary>
        /// Общий метод
        /// </summary>
        public void TemplateMethod()
        {
            Console.WriteLine(Step1() + Step2() + Step3() + Step4());
        }
    }

    /// <summary>
    /// Конкретный класс, определяющий унаследованные методы
    /// </summary>
    class GetInformationInLibrary : GetInformation
    {
        public override string Step1()
        {
            return "Постановка задачи ->";
        }

        public override string Step2()
        {
            return "Подбор литературы ->";
        }

        public override string Step3()
        {
            return "Чтение ->";
        }

        public override string Step4()
        {
            return "Запись ключевой информации";
        }
    }

    /// <summary>
    /// Конкретный класс, определяющий унаследованные методы
    /// </summary>
    class GetInformationInInternet : GetInformation
    {
        public override string Step1()
        {
            return "Постановка задачи ->";
        }

        public override string Step2()
        {
            return "Подбор источников ->";
        }

        public override string Step3()
        {
            return "Проверка достоверности источников ->";
        }

        public override string Step4()
        {
            return "Распечатка ключевой информации";
        }
    }
}


