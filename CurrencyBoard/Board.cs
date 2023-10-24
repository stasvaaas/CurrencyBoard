using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyBoard
{

    // "where T : struct" is used to accept only valuable types
    public class Board<T> where T : struct
    {
        public string Name { get; private set; }

        //constructor to get current currency name
        public Board(string name)
        {
            Name = name;
        }

        private List<T> previousRates = new List<T>();

        //method to change rate
        public void ChangeRate(T rate)
        {
            previousRates.Add(rate);
            Console.WriteLine($"current {Name} rate : {rate}");
        }

        //method to display rates history
        public void PrintHistory()
        {
            Console.WriteLine($"{Name} rate history:");
            foreach (T rate in previousRates)
            {
                Console.WriteLine(rate);
            }    
        }
    }
}
