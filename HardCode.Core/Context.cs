using HardCode.Core.Engine;
using HardCode.Core.Types;
using HardCode.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core
{
    public class Context {
        public Storage storage;
        public Instruction [] instructions;
        public Dictionary<String, int> labels;
        public int Pointer = 0;

        public Context() {
            storage = new Storage();
            labels = new Dictionary<string, int>();
        }
        public void Run(string Code) {
            //Restart(this);
            utilities.loadCode(Code, this);
            while(Pointer < instructions.Length) {
                instructions[Pointer++].Execute();
            }
        }
    }
}
