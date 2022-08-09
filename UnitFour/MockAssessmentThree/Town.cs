using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessmentThree
{
    public class Town
    {
        public Town()
        {
            Villagers = new List<Villager>()
            {
                new Farmer(),
                new Slacker(),
                new Slacker(),
                new Slacker()
            };
        }

        public List<Villager> Villagers { get; set; }

        public int Harvest()
        {
            int sum = 0;
            foreach (var villager in Villagers)
            {
                sum += villager.Farm();
            }
            return sum;
        }

        public int CalcFoodConsumption()
        {
            int sum = 0;
            foreach (var villager in Villagers)
            {
                sum += villager.Hunger;
            }
            return sum;
        }

        public bool SurviveTheWinter()
        {
            int harvestTotal = Harvest();
            int hungerTotal = CalcFoodConsumption();
            return hungerTotal <= harvestTotal;
        }
    }
}
