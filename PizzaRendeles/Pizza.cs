using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRendeles
{
    internal class Pizza
    {
        int pizzaId;
        int pizzaAra;
        string pizzaNeve;
        public Pizza(string line)
        {
            string[] sor = line.Split(';');
            pizzaId = int.Parse(sor[0]);
            pizzaNeve = sor[1];
            pizzaAra = int.Parse(sor[2]);           
        }

        public int PizzaId { get => pizzaId; set => pizzaId = value; }
        public int PizzaAra { get => pizzaAra; set => pizzaAra = value; }
        public string PizzaNeve { get => pizzaNeve; set => pizzaNeve = value; }

        public override string ToString()
        {
            return pizzaId.ToString() + " Pizza neve: " + pizzaNeve + " Ára: " + pizzaAra;
        }
    }
}
