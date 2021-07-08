using System;

namespace Dependecies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation of objects
            Course english = new Course("English", 6);
            Course programming = new Course("programming", 9);
            Student paco = new Student("Francisco", 18, 6);
            Student ari = new Student("Ariadna", 28, 10);
            Professor diego = new Professor("Diego V", paco);
            Professor diegoC = new Professor("Diego C", ari);

            diego.teach(english);
            diegoC.teach(programming);
        }
    }

    class Course
    {
        string name;
        int time;

        public Course(string name, int time)
        {
            this.name = name;
            this.time = time;
        }

        public string getKnowledge()
        {
            return $"learning {name} within {time} months";
        }
    }

    class Student
    {
        string name;
        int age;
        double ranking;
        public Student(string name, int age, double ranking)
        {
            this.name = name;
            this.age = age;
            this.ranking = ranking;
        }

        public void remember(string of_course)
        {
            Console.WriteLine($"{name} is {of_course}.");
        }
    }

    class Professor
    {
        string name;
        Student student;

        public Professor(string name, Student student)
        {
            this.name = name;
            this.student = student;
        }

        public void teach(Course course)
        {
            Console.WriteLine($"Thanks to professor {name}.");
            student.remember(course.getKnowledge());
        }
    }
}
