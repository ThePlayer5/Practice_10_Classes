using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_10_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("1984", "Джордж Оруэлл", 328);
            book.PrintInfo();
            Student student1 = new Student("Алиса", 20, "ИС-202");
            student1.ShowInfo();
            Student student2 = new Student("Борис", 19);
            student2.ShowInfo("");
            Car myCar = new Car("Toyota", 5000);
            myCar.Drive(200);
            myCar.ShowMileage();
            Rectangle rect = new Rectangle(5, 10);
            rect.PrintInfo();
            BankAccount myAccount = new BankAccount(1000);
            myAccount.Deposit(500);
            myAccount.Withdraw(200);
            myAccount.ShowBalance();

            Console.ReadKey();
        }
    }
    class Book
    {
        public string Title;
        public string Author;
        public int Pages;
        public Book(string title_book, string author_book, int pages_book)
        {
            Title = title_book;
            Author = author_book;
            Pages = pages_book;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
        }
    }
    class Student
    {
        public string Name;
        public int Age;
        public string Group;
        public Student(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
        }
        public void ShowInfo(string group)
        {
            group = "Неизвестная группа";
            Group = group;
            Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
        }
    }
    class Car
    {
        public string Brand;
        public int Mileage;
        public Car(string brand, int mileage)
        {
            Brand = brand;
            Mileage = mileage;
        }
        public void Drive(int distance)
        {
            Mileage += distance;
        }
        public void ShowMileage()
        {
            Console.WriteLine($"Марка: {Brand}, Пробег: {Mileage} км");
        }
    }
    class Rectangle
    {
        public int Width;
        public int Height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int GetArea()
        {
            return Width * Height;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {GetArea()}");
        }
    }
    class BankAccount
    {
        public int Balance;
        public BankAccount(int balance)
        {
            Balance = balance;
        }
        public void Deposit(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
            }
            else Console.WriteLine("Вы не можете уйти в минус");
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Текущий баланс: {Balance} руб.");
        }
    }
}