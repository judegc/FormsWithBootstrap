using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesMVC
{
    public class DishDetailsView
    {
        public DishDetailsView(Dish dish)
        {
            Dish = dish;
        }

        public Dish Dish { get; set; }

        public void Display()
        {
            string ingredients = "";
            Dish.Ingredients.ForEach(i => ingredients += i + ", ");

            Console.WriteLine("Name: " + Dish.Name);
            Console.WriteLine("Description: " + Dish.Description);
            Console.WriteLine("Ingredients: " + ingredients);
            Console.WriteLine("Calories: " + Dish.Calories);
        }
    }
}
