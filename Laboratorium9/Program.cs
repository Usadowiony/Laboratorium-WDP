 namespace Laboratorium9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InheritanceDemo();
            Rectangle r = new Rectangle() { Height = 23, Width = 5, Color = 5};
            r.Draw();
        }

        public abstract class Shape{
            public int Color {  get; set; }
            public abstract double Area { get; }
            public abstract void Draw();
        }
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double Area => throw new NotImplementedException();

            public override void Draw()
            {
                Console.WriteLine($"Rectangle {Width} x {Height}");
            }
        }

        private static void InheritanceDemo()
        {
            Student student = new Student()
            {
                Name = "Adam",
                Birth = new DateTime(2000, 10, 10),
                StudyField = "Informatyka stosowana"
            };
            Console.WriteLine(student);
            student.ToString();
            //Student s = new Student("Ewa", DateTime.Parse("2000-10-10"), "Ekonomia");
            object studentAsObject = student;
            Person studentAsPerson = student;
            Console.WriteLine(studentAsPerson.Name);
            Console.WriteLine(studentAsObject.ToString());
            Console.WriteLine("******Polimorfizm******");
            Random random = new Random();
            Person[] people = {
                new Person() { Name = "Karol" },
                student, random.NextDouble() < 0.5 ? new Person() { Name = "Beata" } : new Pracownik() { Name = "Robert" }
            };
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
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

        public class Pracownik : Person
        {
            public override string? ToString()
            {
               return $"Pracownik{{Name:{Name}, Birth: {Birth}}}";
            }
        }
    }
}