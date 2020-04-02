using System;

namespace Task_3
{
    class Programmer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public const bool isSleepAtNight = false;

        public Programmer(string _name, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя: " + this.Name);
            Console.WriteLine("Возраст: " + this.Age);
        }

        public void Sleep()
        {
            if(isSleepAtNight)
                Console.WriteLine("Хммммм??? Скорей всего меня уволили! Только так могу поспать!");
            else
                Console.WriteLine("Через час дэдлайн! Я должен сдать проект!");
        }

        public void Doing()
        {
            Console.WriteLine("Пишу код!");
        }

        public void Walk()
        {
            Console.WriteLine("Куда??? САМ ИДИ!!!");
        }
        public void Stay()
        {
            Console.WriteLine("Нет! Я хочу сидеть и писать код!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer prog = new Programmer("Faridun", 17);
            prog.ShowInfo();
            prog.Walk();
            prog.Stay();
            prog.Doing();
            prog.Sleep();
        }
    }
}
