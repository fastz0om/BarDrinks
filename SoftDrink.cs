using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
    public class SoftDrink : Drink
    {
        public SoftDrink(string name) : base(name)
        {

        }

        public SoftDrink(string name, string description) : base(name, description)
        {

        }

        public SoftDrink(string name, string description = "", double cost = 0, double bulk = 0) : base(name, description, cost, bulk)
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
