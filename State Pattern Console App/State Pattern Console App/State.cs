//02/28/2023
//written by Qusai
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern_Console_App
{
    internal abstract class State
    {
        public abstract void InsertCoin(VendingMachine context);

        public abstract void EjectCoin(VendingMachine context);

        public abstract void SelectItem(VendingMachine context);

        public abstract void DispenseItem(VendingMachine context);

    }
}
