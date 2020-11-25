using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
   public class Order
    {
        private double cost;
        private List<Drink> drinks;
        public Order ()
        {
            this.cost = 0;
            this.drinks = new List<Drink>();
        }

        public Order (List<Drink> drinks) : this()
        {
            this.drinks = drinks;
            foreach(Drink drink in drinks )
            {
                this.cost += drink.Cost;
            }
        }

        public List<Drink> Drinks { get => drinks; set => drinks = value; }
        public double Cost { get => cost; set => cost = value; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   cost == order.cost &&
                   EqualityComparer<List<Drink>>.Default.Equals(drinks, order.drinks);
        }

        public double getAlkDrinkCost()
        {
            double value = 0;
            foreach(Drink drink in drinks)
            {
                if(drink is AlcoholDrink)
                {
                    value += drink.Cost;
                }
            }

           
            return value;
        }



        public override int GetHashCode()
        {
            var hashCode = -1788977986;
            hashCode = hashCode * -1521134295 + cost.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Drink>>.Default.GetHashCode(drinks);
            return hashCode;
        }

        public double getNonAlkDrinkCost()
        {
            double value = 0;
            foreach (Drink drink in drinks)
            {
                if (drink is SoftDrink)
                {
                    value += drink.Cost;
                }
            }


            return value;
        }





    }
}
