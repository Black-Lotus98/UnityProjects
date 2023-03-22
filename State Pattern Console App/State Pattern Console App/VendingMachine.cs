//02/28/2023
//written by Qusei
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern_Console_App
{
    internal class VendingMachine
    {
        private State state = new NoCoin();
        
        public State State { 
            get { return this.state; }
            set { this.state = value; }
            }

        public VendingMachine()
        {
            this.state = new NoCoin();
        }


        public void InsertCoin()
        {
            this.State.InsertCoin(this);
        }
        public void EjectCoin()
        {
            this.State.EjectCoin(this);

        }
        public void SelectItem()
        {
            this.State.SelectItem(this);
            DispenseItem();
        }
        public void DispenseItem()
        {
            this.State.DispenseItem(this);

        }

    }
}
