﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = MementoDesignPatternTester.StructuralCode;
using Real = MementoDesignPatternTester.RealWorldCode;
using My = MementoDesignPatternTester.MyCode;

namespace MementoDesignPatternTester
{
    /// <summary>
    /// MainApp startup class
    /// Memento Design Pattern
    /// </summary>
    class Program
    {
        // Memento

        // Definition
        // Without violating encapsulation, capture and externalize an object's internal state
        // so that the object can be restored to this state later.

        // Participants
        // The classes and objects participating in this pattern are:
        //  - Memento (Memento)
        //      stores internal state of the Originator object.
        //      The memento may store as much or as little of the originator's internal state as necessary at its originator's discretion.
        //      protect against access by objects of other than the originator.
        //      Mementos have effectively two interfaces.
        //      Caretaker sees a narrow interface to the Memento -- it can only pass the memento to the other objects.
        //      Originator, in contrast, sees a wide interface,
        //      one that lets it access all the data necessary to restore itself to its previous state.
        //      Ideally, only the originator that produces the memento would be permitted to access the memento's internal state.
        //  - Originator (SalesProspect)
        //      creates a memento containing a snapshot of its current internal state.
        //      uses the memento to restore its internal state
        //  - Caretaker (Caretaker)
        //      is responsible for the memento's safekeeping
        //      never operates on or examines the contents of a memento.

        /// <summary>
        /// Entry point into console application
        /// </summary>
        static void Main()
        {
            #region Structural code in C#
            // Structural code in C#
            // This structural code demonstrates the Memento pattern which temporary saves and restores another object's internal state.
            Structural.Originiator o = new Structural.Originiator();
            o.State = "on";

            // Store internal state
            Structural.Caretaker c = new Structural.Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator
            o.State = "off";

            // Restore saved state;0
            o.SetMemento(c.Memento);

            // Wait for user
            Console.ReadKey();
            #endregion

            #region Real-world code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Memento pattern which temporarily saves
            // and then restores the SalesProspect's internal state. 
            Real.SalesProspect s = new Real.SalesProspect();
            s.Name = "Franco Pellegrino";
            s.Phone = "123456789";
            s.Budget = 999999;

            // Store internal state
            Real.ProspectMemory p = new Real.ProspectMemory();
            p.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Mario Pellegrino";
            s.Phone = "987654321";
            s.Budget = 111111;

            // Restore saved state
            s.RestoreMemento(p.Memento);

            // Wait for user
            Console.ReadKey();
            #endregion

            #region My code in C#
            // Real-world code in C#
            // This real-world code demonstrates the Memento pattern which temporarily saves
            // and then restores the SalesProspect's internal state. 
            My.ProspectMemory pm = new My.ProspectMemory();

            My.Dichiarazione d = new My.Dichiarazione(pm);
            d.StatoDichiarazione = My.StatoDichiarazione.Completa;
            d.StatoDichiarazione = My.StatoDichiarazione.Stampata;
            d.StatoDichiarazione = My.StatoDichiarazione.Inviata;

            d.RestoreStatoDichiarazioneFromMemento(pm.Memento);

            // Wait for user
            Console.ReadKey();
            #endregion


        }
    }
}
