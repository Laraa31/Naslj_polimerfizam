using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslj_polimerfizam
{
    internal class Person
    {
        String name;
        String surname;
        int age;

        public Person()
        {

        }

        public Person(String name, String surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public String Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }
        public String Surname { get => this.surname; set => this.surname = value; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   surname == person.surname &&
                   age == person.age;
        }


        public override String ToString()
        {
            String ispis= this.name + " " + this.surname + " " + this.age;
            return ispis;
        }



    }
    class Student : Person
    {
        String studentid;
        int academicYear;

        public Student(String name, String surname, int age, String studentid, int academicYear) : base(name, surname, age)
        {
            this.studentid = studentid;
            this.academicYear = academicYear;
        }

        public String Studentid { get => this.studentid; set => this.studentid = value; }
        public int AcademicYear { get => this.academicYear; set => this.academicYear = value; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   studentid == student.studentid;
        }

        public override int GetHashCode()
        {
            int ispis = -1980727003 + EqualityComparer<String>.Default.GetHashCode(studentid);
            return ispis;
        }

        public override String ToString()
        {
            String ispis= " " + this.studentid + " " + this.academicYear;
            return ispis;
        }



    }

    class Teacher : Person
    {
        String email;
        String subject;
        double salary;
        public Teacher(String name, String surname, int age, String email, String subject, double salary) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public String Email { get => this.email; set => this.email = value; }
        public String Subject { get => this.subject; set => this.subject = value; }
        public double Salary { get => this.salary; set => this.salary = value; }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   email == teacher.email;
        }

        public override int GetHashCode()
        {
            int ispis= 848330207 + EqualityComparer<String>.Default.GetHashCode(email);
            return ispis;
        }


        public override String ToString()
        {
            return base.ToString() + " " + this.email + " " + this.subject + " " + this.salary;
        }

        public void increaseSalary(int postotak)
        {
            this.salary = this.salary * (1 + (postotak / 100.0));
        }
        static public void increaseSalary(int postotak, params Teacher[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i].increaseSalary(postotak);
            }
        }




    }
    }
