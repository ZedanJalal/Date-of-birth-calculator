using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Date_of_birth_calculator_
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int year = 2021;
            Console.WriteLine("Please enter your age");
            int age =int.Parse(Console.In.ReadLine());
            int YearOfBirth = year - age;
            Console.WriteLine("YearOfBirth is " + YearOfBirth);
        }
    }
}
