using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslj_polimerfizam
{
    internal class Dessert
    {
        private String name;
        private double weight;
        private int calories;

        public Dessert(String name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public String Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }


        public override String ToString()
        {
            String ispis = Name + " weight=" + Weight + ", calories=" + Calories;
            return ispis;
        }

        public String getDessertType()
        {
            return "dessert";
        }
    }


    class Cake : Dessert
    {
        bool containsGluten;
        String cakeType;
        public Cake(String name, double weight, int calories, bool containsGluten, String cakeType) : base(name, weight, calories)
        {
            this.containsGluten = containsGluten;
            this.cakeType = cakeType;
        }

        public bool ContainsGluten { get => this.containsGluten; set => this.containsGluten = value; }
        public String CakeType { get => this.cakeType; set => this.cakeType = value; }

        public override String ToString()
        {
            String ispis = " " + this.ContainsGluten + " " + this.cakeType;
            return ispis;
        }

        public String getDessertType()
        {
            return "cake";
        }

    }

    class IceCream : Dessert
    {
        String flavour;
        String color;

        public IceCream(String name, double weight, int calories, String flavour, String color) : base(name, weight, calories)
        {
            this.flavour = flavour;
            this.color = color;
        }

        public String Flavour { get => this.flavour; set => this.flavour = value; }
        public String Color { get => this.color; set => this.color = value; }

        public override String ToString()
        {
            return base.ToString() + " " + this.flavour + " " + this.color;
        }

        public String getDessertType()
        {
            return "ice cream";
        }

    }


}
