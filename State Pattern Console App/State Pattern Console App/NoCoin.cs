using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern_Console_App
{
    internal class NoCoin:State
    {
        public override void InsertCoin(VendingMachine context)
        {
            context.State = new CoinInserted();
            Console.WriteLine("Coin Inserted, pick an Item");
        }
        public override void EjectCoin(VendingMachine context)
        {
            //since we dont have a coin inserted we dont need to create it again
            //context.State = new NoCoin();
            Console.WriteLine("You haven't inserted any money");
        }
        public override void SelectItem(VendingMachine context)
        {
            //since we dont have a coin inserted we dont need to create it again
            //context.State = new NoCoin();
            Console.WriteLine("You haven't inserted any money");
        }
        public override void DispenseItem(VendingMachine context)
        {
            //since we dont have a coin inserted we dont need to create it again
            //context.State = new NoCoin();
            Console.WriteLine("You haven't inserted any money");
        }
    }
}
