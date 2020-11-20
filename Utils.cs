using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
    public static class Utils
    {
        static Utils()
        {

        }


        public static double CalculateCheck(List<Drink> drinks)
        {
            double totalCost = 0.0;
            foreach (Drink drink in drinks)
                totalCost += drink.Cost;
            return totalCost;
        }

    }
}
