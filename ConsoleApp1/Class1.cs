using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public string Name { get; set; }
        public string Ciphen { get; set; }
        public int Quantity { get; set; }
        public void ShowInforamation()
        {
            Console.WriteLine("Название - {0}", Name);
            Console.WriteLine("Шифр - {0}", Ciphen);
            Console.WriteLine("количество - {0}", Quantity);
        }
        public void CreateInformation()
        {
            Console.WriteLine("Введите название: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите шифр: }");
            Ciphen = Console.ReadLine();
            Console.WriteLine("Введите шифр: ");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
