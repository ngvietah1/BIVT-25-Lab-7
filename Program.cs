using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("va", 12);
            Student student = new Student("vq", 11,"misis");
            /*human.Method();
            student.Method();
            human.Print();
            student.Print();*/
            Human s = new Student("abc", 21, "vvv");
            s.Method();
            s.Print();
            Human[] humans = new Human[] { human, student, s };
            for(int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(humans[i] is Student);
            }

        }
    }
    public class Human
    {
        private string _name;
        private int _age;
        public string Name => _name;
        public int Age => _age;
        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }
       public void Method()
        {
            Console.WriteLine("Human method");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name},\nAge: {Age}");
        }
    }
    public class Student : Human
    {
        private string _university;
        public string University => _university;
        public Student(string name, int age, string university) : base(name, age)
        {
            _university = university;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"University: {_university}");
        }
        public void Method()
        {
            Console.WriteLine("Student method");
        }
    }
}
