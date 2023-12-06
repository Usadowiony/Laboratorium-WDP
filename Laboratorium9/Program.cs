 namespace Laboratorium9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Person {
            public string Name { get; set; }
            public DateTime Birth { get; set; }

            public int GetAge(DateTime now)
            {
                return now.Year - Birth.Year;
            }
        }
        public class Student:Person{ 
        }
    }
}