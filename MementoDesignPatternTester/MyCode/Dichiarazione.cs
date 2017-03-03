using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    class Dichiarazione
    {
        private StatoDichiarazione _statoDichiarazione;
        private ProspectMemory _prospectMemory;

        public Dichiarazione(ProspectMemory prospectMemory)
        {
            this._prospectMemory = prospectMemory;
            prospectMemory.Memento = new MementoDichiarazione();
            this._statoDichiarazione = StatoDichiarazione.Errata;
        }

        // Gets or sets name
        public StatoDichiarazione StatoDichiarazione
        {
            get { return _statoDichiarazione; }
            set
            {
                this._prospectMemory.Memento.AddStato(_statoDichiarazione);
                StatoDichiarazione appoStatoDichiarazione = _statoDichiarazione;
                _statoDichiarazione = value;
                Console.WriteLine("StatoDichiarazione passa da " + appoStatoDichiarazione + " a " + _statoDichiarazione);
            }
        }

        // Restores memento
        public void RestoreStatoDichiarazioneFromMemento(MementoDichiarazione memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this._statoDichiarazione = memento.GetFirstStatoDichiarazione();
            Console.WriteLine("\nStatoDichiarazione = " + this._statoDichiarazione + "\n");
        }
    }
}
