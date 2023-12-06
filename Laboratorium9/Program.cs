 namespace Laboratorium9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(){
                Name = "Adam",
                Birth = new DateTime(2000,10,10),
                StudyField = "Informatyka stosowana"};
            Console.WriteLine(student);
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
            public string StudyField { get; set; }
        }
    }
}