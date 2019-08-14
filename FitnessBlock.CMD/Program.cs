using System;
using FitnessBlock.BL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBlock.BL.Controller;

namespace FitnessBlock.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение FitnessBlock!");
            Console.WriteLine("Введите имя пользователя:");

            var name = Console.ReadLine();

            Console.WriteLine("Введите пол:");
            var gender = Console.ReadLine();
            
            Console.WriteLine("Введите дату рождения:");
            var birthDate = DateTime.Parse(Console.ReadLine()); // TODO: переписать 

            Console.WriteLine("Введите вес:");
            var weight = double.Parse(Console.ReadLine()); // TODO: переписать 

            Console.WriteLine("Введите рост:");
            var height = double.Parse(Console.ReadLine()); // TODO: переписать 

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}
