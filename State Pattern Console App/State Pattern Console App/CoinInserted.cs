//02/28/2023
//written by Qusai
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern_Console_App
{
    internal class CoinInserted: State
    {
        public override void InsertCoin(VendingMachine context)
        {
            Console.WriteLine("You cannot input a second coin");
        }
        public override void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("Coin Returned");
        }
        public override void SelectItem(VendingMachine context)
        {
            context.State = new ItemSold();
            Console.WriteLine("Item is selected");
        }
        public override void DispenseItem(VendingMachine context)
        {
            //we already have a coin inserted, no need to create a new one
            //context.State = new CoinInserted();
            Console.WriteLine("You must select an Item First");
        }
    }
}
