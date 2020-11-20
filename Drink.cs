using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarDrinks
{
    public abstract class Drink
    {
        //Название напитка
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Описание напитка
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //Стоимость за порцию
        private double _cost;
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        //Объем 1-ой порции
        private double _bulk;
        public double Bulk
        {
            get { return _bulk; }
            set { _bulk = value; }
        }

        public Drink(string name)
        {

        }

        public Drink(string name, string description)
        {
            _name = name;
            _description = description;
        }

        //public Drink(string name, string description, double cost, double bulk)
        //{
        //    _name = name;
        //    _description = description;
        //    _cost = cost;
        //    _bulk = bulk;
        //}

        public Drink(string name, string description = "", double cost = 0.0, double bulk = 0.0)
        {
            _name = name;
            _description = description;
            _cost = cost;
            _bulk = bulk;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Drink drink))
                return false;

            return Name.Equals(drink.Name) && Description.Equals(drink.Description)
                    && Cost.Equals(drink.Cost) && Bulk.Equals(drink.Bulk);
        }


        public bool Equals(Drink obj)
        {
            return Name.Equals(obj.Name) && Description.Equals(obj.Description)
                    && Cost.Equals(obj.Cost) && Bulk.Equals(obj.Bulk);
        }

    }
}
