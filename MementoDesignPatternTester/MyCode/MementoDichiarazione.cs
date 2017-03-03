using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    class MementoDichiarazione
    {
        private List<StatoDichiarazione> _lstStatoDichiarazione;

        // Constructor
        public MementoDichiarazione()
        {
            this._lstStatoDichiarazione = new List<StatoDichiarazione>();
        }

        public void AddStato(StatoDichiarazione statoDichiarazione)
        {
            this._lstStatoDichiarazione.Add(statoDichiarazione);
        }

        public StatoDichiarazione GetFirstStatoDichiarazione()
        {
            return this._lstStatoDichiarazione[0];
        }

    }
}
