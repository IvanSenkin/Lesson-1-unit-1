using System;

namespace Lesson_1_unit_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.


            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст : ");
            var age = Console.ReadLine();
            Console.Write("Введите ваш рост: ");
            var height = Console.ReadLine();
            Console.Write("Введите ваш вес: ");
            var weigt = Console.ReadLine();

            Console.WriteLine("a)" + " Имя: " + name + " Фамилия: " + surname + " возраст: " + age + " рост: " + height + " вес: " + weigt);
            Console.WriteLine("б) Имя: {0} Фамилия: {1} возраст: {2} рост: {3} вес: {4}", name, surname, age, height, weigt);
            Console.WriteLine($"в) Имя: {name} Фамилия: {surname} возраст: {age} рост: {height} вес: {weigt}");
           
        }
    }
}
