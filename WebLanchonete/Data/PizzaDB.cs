using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PizzaDB
    {
        private ConnectionDB conn;
        public void Insert(Pizza pizza)
        {
            string sql = string.Format("INSERT INTO PIZZA (discription, individualvalue) VALUES ('{0}, {0}')");
        }
    }
}
