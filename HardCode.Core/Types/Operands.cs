using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core.Types {
    public class Operand {

        protected float Value;
        //{
        //    get {
        //        return Proc.Get(Value);
        //    }
        //    set{
        //        Proc.Set(value); 
        //    }
        //}
        AddressingMode Proc;

        public float Get() {
            return Proc.Get(Value);
        }
        public void Set(float value) {
            Proc.Set((int)Value, value);
        }

        public Operand(float operand, AddressingMode addressingMode) {
            Value = operand;
            Proc = addressingMode;
        }
    }
    //public class IntOperand {
    //    protected int Value;
    //    public IntOperand(int op) {
    //        Value = op;
    //    }
    //    public float Get() {
    //        return Value;
    //    }
    //}

    //public class DirectOperand {
    //    protected string Value;
    //    public DirectOperand(int op) {
    //        Value = op;
    //    }
    //    public float Get() {
    //        return Value;
    //    }
    //}
}
