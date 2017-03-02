using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.StructuralCode
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class Caretaker
    {
        private Memento _memento;

        // Gets or sets memento
        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
