using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core.Engine {

    public class Storage {
        public static readonly Dictionary<string, Int16> RegistersIdicies = new Dictionary<string, Int16>() {
            {"AX", 0},
            {"BX", 1},
            {"CX", 2},
            {"DX", 3},
        };
        public Dictionary<string, bool> FLAGS = new Dictionary<string, bool>() {
            {"S", false },
            {"Z", false },
        };
        public Int16 [] Registers;
        public byte[] Memory;
        public Stack<float> Pool;
        
        public Storage() {
            Registers = new Int16[] {
                0,
                0,
                0,
                0
            };
            Memory = new byte[64000];
            Pool = new Stack<float>();

        }
    }
}
