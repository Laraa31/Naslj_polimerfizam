using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslj_polimerfizam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dessert genericDessert = new Dessert("Cheessecake",500 , 1200);
            Cake cake = new Cake("Red velvet", 600, 1000, false, "formal");
            IceCream icecream = new IceCream("Strawberry punch", 100, 200, "light pink", "jagoda punč");

            Teacher t1 = new Teacher("Ivo ", "Ivić", 40, "ivo.ivic@skole.hr", "Napredno i objektno programiranje", 10000);
            Teacher t2 = new Teacher("Ana", "Anić", 36, "ana.anic@skole.hr","Programiranje mobilnih uređaja", 10000);

            Student s1 = new Student("Jana", "Janjić", 19, "0036312123", (short)2);
            Student s2 = new Student("Karla", "Karlić", 19, "0036387656", (short)1);
            Student s3 = new Student("Ivan", "Ivanović", 20, "0036392357", (short)3);

            UniMastersChef competition = new UniMastersChef(2);

            CompetitionEntry e1 = new CompetitionEntry(t1, genericDessert);
            competition.addEntry(e1);

            Console.WriteLine("Entry 1 rating: " + e1.getRating());
            e1.addEntry(s1, 4);
            e1.addEntry(s2, 5);
            Console.WriteLine("Entry 1 rating: " + e1.getRating());

            CompetitionEntry e2 = new CompetitionEntry(t2, cake);
            e2.addEntry(s1, 2);
            e2.addEntry(s3, 3);
            e2.addEntry(s2, 4);
            competition.addEntry(e2);

            Console.WriteLine("Entry 2 rating: " + e2.getRating());
            Console.WriteLine("Best dessert is: " + competition.getBestDessert().Name);

            Console.ReadKey();
        }
    }
}
