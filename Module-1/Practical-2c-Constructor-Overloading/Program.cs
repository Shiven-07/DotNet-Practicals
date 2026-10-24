using System;

namespace ConstructorOverloading
{
    class Student
    {
        public string Name;
        public int Age;
        public string Course;

        // Default constructor
        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Course = "N/A";
            Console.WriteLine("Default constructor called");
        }

        // Parameterized constructor with 1 argument
        public Student(string name)
        {
            Name = name;
            Age = 18;
            Course = "BSc IT";
            Console.WriteLine("1-param constructor called");
        }

        // Parameterized constructor with 2 arguments
        public Student(string name, int age)
        {
            Name = name;

Age = age;
            Course = "BSc IT";
            Console.WriteLine("2-param constructor called");
        }

        // Parameterized constructor with all arguments
        public Student(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
            Console.WriteLine("3-param constructor called");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Constructor Overloading Demo ===");
            Student s1 = new Student();
            s1.Display();

            Student s2 = new Student("Alice");
            s2.Display();

            Student s3 = new Student("Bob", 20);
            s3.Display();

            Student s4 = new Student("Carol", 21, "BCA");
            s4.Display();

            Console.ReadKey();
        }
    }

}
