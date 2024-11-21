using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_and_method
{
    internal class Program
    {
        //concept of Abstract class and abstract method
        public enum Gender { male = 1, female = 2 }
        public abstract class Person
        {
            public string firstname;
            public string lastname;
            public int age;
            public Gender Gender;
            public abstract void Name();
        }

        public class Student : Person
        {
            public int Roll;
            public float fees;
            public override void Name()
            {
                //using string interpolation to dispaly varibale
                string fullname = this.firstname + " " + this.lastname;
                Console.WriteLine($"student name is {fullname}");
                Console.WriteLine($"student age is {age}");
                Console.WriteLine($"student gender is {Gender}");
                Console.WriteLine($"student roll is {Roll}");
                Console.WriteLine($"student fees is {fees}");
            }


            public class Teacher : Person
            {
                public string Department;
                public float Salary;
                public override void Name()
                {
                    //using string interpolation to dispaly varibale
                    string fullname = this.firstname + " " + this.lastname;
                    Console.WriteLine($"Teacher name is = {fullname}");
                    Console.WriteLine($"Teacher age is = {age}");
                    Console.WriteLine($"Teacher gender is = {Gender}");
                    Console.WriteLine($"Teacher's Department is = {Department}");
                    Console.WriteLine($"Teacher salary is  = {Salary}");

                }

            }
           

            static void Main(string[] args)
            {
                Console.WriteLine("Student Info--");
                Student s = new Student();
                s.firstname = "Al";
                s.lastname = "Murad";
                s.age = 27;
                s.Gender = Gender.male;
                s.Roll = 111;
                s.fees = 670;
                s.Name();
                Console.WriteLine("-------------");
                Console.WriteLine("-------------");
                Console.WriteLine("Teacher Info--");
                Teacher t = new Teacher();
                t.firstname="Abid";
                t.lastname = "Hassan";
                t.age = 36;
                t.Gender = Gender.male;
                t.Department = "Accounting";
                t.Salary = 256000;
                t.Name();
                Console.ReadLine();
            }
        }
    }
}
