using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Console_App
{
    public abstract class MonsterFactory
    {
        protected abstract Monster CreateMonster();

        public Monster MakeMonster()
        {
            // make a monster
            Monster monster = CreateMonster();
            // set tje x and z location of the monster
            Random rnd = new Random();
            monster.X = rnd.Next(1, 100);
            monster.Z = rnd.Next(1, 100);

            //we can add a whole bunch of other stuff here
            //like adding random armor and weapons and magic items
            //as long as your monster have the ability to have those items
            //for example, a List<MagicItems>

            return monster;

        }
    }
}
