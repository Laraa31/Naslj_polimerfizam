using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslj_polimerfizam
{
    internal class CompetitionEntry
    {
        Teacher teacher;
        Dessert dessert;
        private Student[] students;
        private int[] ratings;
        private int idx;
        public CompetitionEntry(Teacher teacher, Dessert dessert)
        {
            this.teacher = teacher;
            this.dessert = dessert;
        }

        public bool addEntry(Student student, int number)
        {
            if (idx == 3)
            {
                return false;
            }
            foreach (Student s in students)
            {
                if (s != null && s.Equals(student))
                    return false;
            }
            Students[idx] = student;
            ratings[idx] = number;
            idx++;
            return true;


        }
        public double getRating()
        {
            if (idx == 0) return 0;

            double sum = 0;
            for (int i = 0; i < idx; i++)
                sum += ratings[i];

            return sum / idx;
        }

        internal Teacher Teacher { get => teacher; set => teacher = value; }
        internal Dessert Dessert { get => dessert; set => dessert = value; }
        public int[] Ratings { get => ratings; set => ratings = value; }
        public int Idx { get => idx; set => idx = value; }
        public Student[] Students { get => students; set => students = value; }

    }

}
