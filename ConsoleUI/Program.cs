using ClassLibrary.Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            var result=bookManager.Add();
            Console.WriteLine(result);
        }
    }
}
