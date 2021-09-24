using System;
using System.Collections.Generic;
using System.Diagnostics;  // for Debug.WriteLine
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ConsoleApp1.Classes;
using StringLanguageExtensions;

namespace ConsoleApp1
{
    class Program
    {
        // BaseDirectory is the project bin folder and the Release or Debug subfolder
        private static readonly string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "PersonBirthdays.json");
        static void Main(string[] args)
        {
            Debug.WriteLine("Hello World!");
            FindByFirstAndLastName( "John", "Smith");
        }

        private static void FindByFirstAndLastName(string fname, string lname)
        {
            if (File.Exists(_fileName))
            {
                
            }
            else
            {
                FileNotFound();
            }

        }

        private static void FileNotFound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Failed to find ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{ _fileName }");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
