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
            student.ToString();
            Student s = new Student("Ewa", DateTime.Parse("2000-10-10"), "Ekonomia");
            object studentObject = student;
            Person studentAsPerson = student;
        }
        public class Person {
            public string Name { get; set; }
            public DateTime Birth { get; set; }

            public Person(string name, DateTime birth) {
                Name = Name;
                Birth = Birth;
            }
            public Person() { }

            public int GetAge(DateTime now)
            {
                return now.Year - Birth.Year;
            }

            public override string? ToString()
            {
                return $"Person{{Name:{Name}, Birth: {Birth}}}";
            }
        }
        public class Student:Person{
            public string StudyField { get; set; }

            public override string? ToString()
            {
                return $"Student{{Name:{Name}, Birth: {Birth}, StudyField: {StudyField}}}";
            }
        }
    }
}