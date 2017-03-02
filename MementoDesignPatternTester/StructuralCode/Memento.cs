using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class Memento
    {
        private string _state;

        // Gets or sets state
        public string State
        {
            get
            {
                return _state;
            }
        }

        public Memento(string state)
        {
            this._state = state;
        }
    }
}
