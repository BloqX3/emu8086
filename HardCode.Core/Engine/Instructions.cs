using HardCode.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCode.Core.Engine {
    struct Code {
        public Action<Operand[], Context> Run;
        public int OperandsCount;
        public Code(Action<Operand[], Context> Executer, int NumberOfOperands) {
            Run = Executer;
            OperandsCount = NumberOfOperands;
        }
    }
    class Instructions {
        public static string[] Loops = new string[] {
            "LOOP",
            "JMP",
            "JE",
            "JNE",
            "JB",
            "JBE",
            "JL",
            "JLE",
        };
        public static Dictionary<string, Code> InstructionsPool = new Dictionary<string, Code>() {
            { "MOV", new Code(MOV, 2) },
            { "ADD", new Code(ADD, 2) },
            { "SUB", new Code(SUB, 2) },
            { "MUL", new Code(MUL, 1) },
            { "DIV", new Code(DIV, 1) },
            { "INC", new Code(INC, 1) },
            { "DEC", new Code(DEC, 1) },
            { "PUSH", new Code(PUSH, 1) },
            { "POP", new Code(POP, 1) },
            { "CMP", new Code(CMP, 2) },
            { "LOOP", new Code(LOOP, 1) },
            { "JMP", new Code(JMP, 1) },
            { "JE", new Code(JE, 1) },
            { "JNE", new Code(JNE, 1) },
            { "JB", new Code(JB, 1) },
            { "JBE", new Code(JBE, 1) },
            { "JL", new Code(JL, 1) },
            { "JLE", new Code(JLE, 1) },
        };
        public static void MOV(Operand[] operands, Context context) {
            operands[0].Set(operands[1].Get());
        }
        public static void ADD(Operand[] operands, Context context) {
            operands[0].Set(operands[0].Get() + operands[1].Get());
        }
        public static void SUB(Operand[] operands, Context context) {
            operands[0].Set(operands[0].Get() - operands[1].Get());
        }
        public static void MUL(Operand[] operands, Context context) {
            context.storage.Registers[Storage.RegistersIdicies["AX"]]
                = (short)(context.storage.Registers[0] * operands[0].Get());
        }
        public static void DIV(Operand[] operands, Context context) {
            context.storage.Registers[Storage.RegistersIdicies["AX"]]
                = (short)(context.storage.Registers[0] / operands[0].Get());
        }
        public static void INC(Operand[] operands, Context context) {
            operands[0].Set(operands[0].Get() + 1);
        }
        public static void DEC(Operand[] operands, Context context) {
            operands[0].Set(operands[0].Get() - 1);
        }
        public static void PUSH(Operand[] operands, Context context) {
            context.storage.Pool.Push(operands[0].Get());
        }
        public static void POP(Operand[] operands, Context context) {
            operands[0].Set(context.storage.Pool.Pop());
        }
        public static void CMP(Operand[] operands, Context context) {
            float res = operands[0].Get() - operands[1].Get();
            context.storage.FLAGS["S"] = res < 0;
            context.storage.FLAGS["Z"] = res == 0;
        }
        public static void LOOP(Operand[] operands, Context context) {
            context.Pointer = (int)operands[0].Get();
        }
        public static void JMP(Operand[] operands, Context context) {
            context.Pointer = (int)operands[0].Get();
        }
        public static void JE(Operand[] operands, Context context) {
            if (context.storage.FLAGS["Z"])
                context.Pointer = (int)operands[0].Get();
        }
        public static void JNE(Operand[] operands, Context context) {
            if (!context.storage.FLAGS["Z"])
                context.Pointer = (int)operands[0].Get();
        }
        public static void JB(Operand[] operands, Context context) {
            if (!context.storage.FLAGS["S"])
                context.Pointer = (int)operands[0].Get();
        }
        public static void JBE(Operand[] operands, Context context) {
            if (!context.storage.FLAGS["S"] || context.storage.FLAGS["Z"])
                context.Pointer = (int)operands[0].Get();
        }

        public static void JL(Operand[] operands, Context context) {
            if (context.storage.FLAGS["S"])
                context.Pointer = (int)operands[0].Get();
        }
        public static void JLE(Operand[] operands, Context context) {
            if (context.storage.FLAGS["S"] || context.storage.FLAGS["Z"])
                context.Pointer = (int)operands[0].Get();
        }
    }
}
