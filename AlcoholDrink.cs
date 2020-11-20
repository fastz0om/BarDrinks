using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
    public class AlcoholDrink : Drink
    {
        //Крепость алкоголя
        private double _abv;

        public double ABV
        {
            get { return _abv; }
            set { _abv = value; }
        }

        public AlcoholDrink(string name) : base(name)
        {

        }

        public AlcoholDrink(string name, string description) : base(name, description)
        {

        }

        public AlcoholDrink(string name, string description = "", double cost = 0, double bulk = 0) : base(name, description, cost, bulk)
        {

        }
    }
}
