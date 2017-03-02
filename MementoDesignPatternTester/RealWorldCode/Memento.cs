using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class Memento
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Gets or sets phone
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        // Gets or sets budget
        public double Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }

        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this._name = name;
            this._phone = phone;
            this._budget = budget;
        }
    }
}
