using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, sir! Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your height: ");
            double height = double.Parse(Console.ReadLine());
            // Конакатенация
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Your age: " + age);
            Console.WriteLine("Your city: " + city);
            Console.WriteLine("Your height: " + height);
            // Плейсхолдеры (placeholder)
            Console.WriteLine("Your name: {0}, Your age: {1} , Your city: {2} , Your height: {3}", name, age, city, height);
            // Интерполяция строк 
            Console.WriteLine($"Your name: {name}, Your age: {age} , Your city: {city} , Your height: {height}");
            #region My_Method1
            Print("This is vethid print ");
            #endregion
            #region My_Method2
            int a = Addition(4, 20);
            #endregion

            #region object of Client
            CLient client = new CLient();
            client.Name = "Karim";
            client. orderNumber = 51451351;
            client.ID = 1;

            Console.WriteLine(client);
            #endregion
            #region Fraction
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(2, 3);
            Console.WriteLine(fraction1);

            fraction1.Multiplication(fraction2);
        }
        public static void Print(string str)
        {
            Console.WriteLine(str);

        }
        public static int Addition(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
            int sum = firstNum + secondNum;
            return sum;

        }
    }
    public class CLient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int orderNumber { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} , Name of Client: {Name} , Number of order: {orderNumber}";

        }
    }
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denumenator { get; set; }

        public Fraction(int numerator, int denumenator)
        {
            Numerator = numerator;
            Denumenator = denumenator;

        }
        public Fraction()
        {

        }
        public void Multiplication(Fraction fraction)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * fraction.Numerator;
            result.Denumenator = Denumenator * fraction.Denumenator;

        }
        public override string ToString()
        {
            return $"{Numerator}/{Denumenator}";
        }
    }

}


 

