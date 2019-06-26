using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("IELTS - GradeBook");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var result = book.GetStatistics();
            Console.WriteLine($"Average: {result.Average}");
            Console.WriteLine($"Max: {result.Max}");
            Console.WriteLine($"Min: {result.Min}");
        }
    }
}
