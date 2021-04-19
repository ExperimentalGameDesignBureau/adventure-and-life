using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarfareSimulator;

namespace WarfareSimulator.old
{
    class Command
    {
        public Unit subjctiveUnit { get; set; }
        public Unit objectiveUnit { get; set; }

        public int commandInitialtive { get; set; }
        public int InitialtiveModifier { get; set; }

        public Command(Unit subjctiveUnit)
        {
            Init(subjctiveUnit);
        }

        private void Init(Unit unit)
        {

            //commandInitialtive = unit.initialtive + InitialtiveModifier;
        }

        public void WriteOutput()
        {
            Console.WriteLine(commandInitialtive);
        }
    }
}
