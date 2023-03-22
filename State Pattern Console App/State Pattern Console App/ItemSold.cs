using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern_Console_App
{
    internal class ItemSold: State
    {
        public override void InsertCoin(VendingMachine context)
        {
            // no need to do anythig here
            //context.State = new ItemSold();
            Console.WriteLine("You cannot input a second coin");
        }
        public override void EjectCoin(VendingMachine context)
        {   
            //context.State = new ItemSold();
            Console.WriteLine("You cannot get you money back while the machine is dipensing");
        }
        public override void SelectItem(VendingMachine context)
        {
            //context.State = new ItemSold();
            Console.WriteLine("You cannot select an item while the machine already is dipensing");
        }
        public override void DispenseItem(VendingMachine context)
        {   
            //context.State = new NoCoin();
            Console.WriteLine("Your item is being dispnsed");
        }
    }
}
