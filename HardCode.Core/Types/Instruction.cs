using HardCode.Core.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core.Types
{
    public class Instruction
    {
        private Operand[] Operands;
        private Context Engine;
        private Code Code;
        public Instruction(string code, Operand [] operands, Context engine) { 
            Operands = operands;
            Engine = engine;
            Code = Instructions.InstructionsPool[code];
        }
        public void Execute() {
            Code.Run(Operands, Engine);
        }

    }
}
