using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class ProspectMemory
    {
        private MementoDichiarazione _memento;

        // Property
        public MementoDichiarazione Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
