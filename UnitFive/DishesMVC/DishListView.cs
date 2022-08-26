using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesMVC
{
    public class DishListView
    {
        public DishListView(List<Dish> dishes)
        {
            Dishes = dishes;
        }

        public List<Dish> Dishes { get; set; }

        public void Display()
        {
            Console.WriteLine("Here is our list of dishes:");

            for (int i = 0; i < Dishes.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Dishes[i].Name}");
            }
        }
    }
}
