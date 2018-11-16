using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Meal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }


        public Meal(string name, string description, string ingredients, int number, int price)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Number = number;
            Price = price;
        }

        public Meal()
        {

        }
    }
}
