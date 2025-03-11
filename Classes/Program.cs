using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Класс - задумка, чертёж, шаблон у него есть атрибуты
            // Объект - класс со всеми атрибутами, который спроектировали по классу
            // Есть три принципа: инкапсулация, наследование, полиморфизм, (абстракция)
            // Инкапсулация - скрытие самого класса или методов класса для скрытия части функционала кода, чтобы пользователь его не сломал
            // Наследование - наследование свойств одного класса другому

            Car car = new Car("Toyota", 300);
            Car colorCar = new Car("Toyota", 300, "red");
            Car speedCar = new Car(100);
            //car.brand = "Toyota";
            //car.speed = 200;
            //car.brand = "Mazda";
            //car.speed = 100;
            speedCar.Drive();
            //car.Drive();
            //colorCar.Drive("zzzzz");

            Console.ReadKey();
        }
    }
    class Car
    {
        // Поля
        public string Brand;
        public int Speed;
        public string Color;
        public Car(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public Car(string brand, int speed, string color)
        {
            Brand = brand;
            Speed = speed;
            Color = color;
        }
        public Car(int speed)
        {
            Speed = speed;
            Speed *= 5;
        }
        public void Drive()
        {
            Console.WriteLine($"{Brand} едет со скоростью {Speed} км/ч");
        }
        public void Drive(string cl)
        {
            Color = cl;
            Console.WriteLine($"{Brand} едет со скоростью {Speed} км/ч с цветом {cl}");
        }
    }   
}
