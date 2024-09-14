using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core.Types {

    public interface AddressingMode {
        //public Context engine;
        //public AddressingMode(Context engine) {
        //    this.engine = engine;
        //}
        public float Get(float op);
        public void Set(int op, float value);
    }
    public class DirectAddressing : AddressingMode {
        public Context engine;
        public DirectAddressing(Context engine){
            this.engine = engine;
        }

        public float Get(float op) {
            return op;
        }

        public void Set(int op, float value) {
            throw new Exception("You're Writing into a static Value, EX: mov 3, Ax");
        }
    }
    public class RegisterAddressing : AddressingMode {
        public Context engine;
        public RegisterAddressing(Context engine) {
            this.engine = engine;
        }

        public float Get(float op) {
            return engine.storage.Registers[(int)op];
        }

        public void Set(int op, float value) {
            engine.storage.Registers[(int)op] = (short)value;
        }
    }

    public class MemoryAddressing : AddressingMode {
        public Context engine;
        public MemoryAddressing(Context engine) {
            this.engine = engine;
        }
        public float Get(float op) {
            return engine.storage.Memory[(int)op];
        }

        public void Set(int op, float value) {
            engine.storage.Memory[op] = (byte)value;
        }
    }
    public class MemoryIndirectAddressing : AddressingMode {
        public Context engine;
        public MemoryIndirectAddressing(Context engine) {
            this.engine = engine;
        }
        public float Get(float op) {
            return engine.storage.Memory[engine.storage.Registers[(int)op]];
        }

        public void Set(int op, float value) {
            engine.storage.Memory[engine.storage.Registers[op]] = (byte)value;
        }
    }


    //public class AddressingModes {
    //    public static float DirectAddressing(float op, Context context) {
    //        return op;
    //    }
    //    public static float MemoryAddressing(float op, Context context) {
    //        return context.storage.Memory[(int)op];
    //    }
    //    public static float RegisterAddressing(float op, Context context) {
    //        return context.storage.Registers[(int)op];
    //    }

    //}

    //public abstract class Addresser<T, V> {
    //    public T Value { get; set; }
    //    protected string AdressType;
    //    protected Addresser(T value, string addressType) {
    //        Value = value;
    //        AdressType = addressType;
    //    }
    //    //string operand;
    //    //public Addresser(string operand) {
    //    //    this.operand = operand;
    //    //}
    //    //
    //    //public static IDictionary<string, Func<T, V>> ValueFinders = new Dictionary<string, Func<T, V>>(){
    //    //    {"DIRECT", DirectAddressing},
    //    //};
    //    //public static V DirectAddressing(T op) {
    //    //    return op;
    //    //}
    //    //public T Get() {
    //    //    return ValueFinders[AdressType](Value);
    //    //}


    //}

    //public class IntOperand : Addresser<int, int> {
    //    public IntOperand(int value) : base(value) { }
    //}
}
