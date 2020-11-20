using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
    public class Cocktail : Drink
    {

        //Список напитков, входящих в коктейль
        private List<Drink> _drinkList = new List<Drink>();

        public List<Drink> DrinkList
        {
            get { return _drinkList; }
            set { _drinkList = value; }
        }


        public Cocktail(string name) : base(name)
        {

        }

        public Cocktail(string name, string description) : base(name, description)
        {

        }

        public Cocktail(string name, string description = "", double cost = 0, double bulk = 0) : base(name, description, cost, bulk)
        {

        }

        public void AddDrink(Drink drink)
        {
            if (!_drinkList.Contains(drink))
            {
                _drinkList.Add(drink);
                RecalculateCost(drink, true);
            }
        }

        public void RemoveDrink(Drink drink)
        {
            if (_drinkList.Contains(drink))
            {
                _drinkList.Remove(drink);
                RecalculateCost(drink, false);
            }
        }

        private void RecalculateCost(Drink drink, bool addDrink)
        {
            if (addDrink)
                Cost += drink.Cost;
            else
                Cost -= drink.Cost;
        }
    }
}
