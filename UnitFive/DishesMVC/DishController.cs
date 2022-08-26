using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishesMVC
{
    public class DishController
    {
        public List<Dish> DishDb { get; set; } = new List<Dish>()
        {
            new Dish(
                "Lasagna",
                "yummy goodness",
                new List<string>(){ "tomato sauce", "lasagna noodles", "cheese"},
                2000),
            new Dish(
                "PBJ Sandwich",
                "the classic...",
                new List<string>(){ "bread", "peanut butter", "jelly"},
                350)
        };

        public void DishList()
        {
            var view = new DishListView(DishDb);
            view.Display();
        }

        public void DishDetails()
        {
            int selection = GetSelection();
            var view = new DishDetailsView(DishDb[selection - 1]);
            view.Display();
        }

        public int GetSelection()
        {
            Console.WriteLine("Which dish would you like to view? Enter 1-" + DishDb.Count);
            return int.Parse(Console.ReadLine());
        }

        public void Welcome()
        {
            DishList();
            DishDetails();
        }
    }
}
