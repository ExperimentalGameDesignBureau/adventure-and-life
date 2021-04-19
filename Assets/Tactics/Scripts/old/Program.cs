using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarfareSimulator.old
{
    class Program
    {
        static Command[] commandFlow = new Command[2];
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.ExecuteCommands(commandFlow);
            Console.ReadLine();
        }

        private void Test()
        {
            Unit testUnit1 = new Unit();
            Unit testUnit2 = new Unit();
            Attack testAttack1 = new Attack(testUnit1);
            Attack testAttack2 = new Attack(testUnit2);
            commandFlow[0] = testAttack1;
            commandFlow[1] = testAttack2;
        }

        private void ExecuteCommands(Command[] commands)
        {
            foreach (Command c in commands)
            {
                c.WriteOutput();
            }
        }
    }
}
