using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    class Student
    {
        private int id;
        private string name;
        private int age; 
        private static int _studentCount = 0; //+// 

        public int Id
        {
            get { return id; }
            private set { id = value; }

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return _studentCount; }


        }

        public Student()
        {
            Name = "John Doe";
            Age = 16;
            Id = ++_studentCount;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            Id = ++_studentCount;
        }
        public void Display()
        {
            Console.WriteLine($"Student ID: {Id} Name: {Name} age: {Age}");
        } 
        public int GetOlder()
        {

            return Age++; 

        }

        }
    }

