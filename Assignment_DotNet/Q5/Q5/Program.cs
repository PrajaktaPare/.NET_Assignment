using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    public interface IStudent
    {
        void DisplayInfo();
    }

    public class Student : IStudent
    {
        public string Name { get; set; }
        private int marks;

        public Student(string name, int marks)
        {
            Name = name;
            this.marks = marks;
        }

        static Student()
        {
            Console.WriteLine("Static constructor of Student called.");
        }

        private Student()
        {
            Name = "Unknown";
            marks = 0;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Marks: {marks}");
        }

        public new void ShowDetails()
        {
            Console.WriteLine("This is a method in the Student class.");
        }
    }

    public class Teacher : Student
    {
        public string Subject { get; set; }

        public Teacher(string name, int marks, string subject)
            : base(name, marks)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
        }

        public new void ShowDetails()
        {
            Console.WriteLine("This is a method in the Teacher class.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("PP", 30);
            s.DisplayInfo();
            s.ShowDetails();

            Teacher t = new Teacher("RK", 25, "Science");
            t.DisplayInfo();
            t.ShowDetails();

            Student stuteacher = new Teacher("SS", 28, "Math");
            stuteacher.ShowDetails(); // This will call Student.ShowDetails() due to reference type

            Console.ReadLine();
        }
    }
}
