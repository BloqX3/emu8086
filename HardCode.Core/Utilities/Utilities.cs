using HardCode.Core.Engine;
using HardCode.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HardCode.Core.Utilities {
    internal class utilities {
        public static string[] SplitCode(string code) {
            List<String> res = new List<string>();
            string holder = "";
            int spaceCount = 0;
            foreach(char c in (code + " ")) {

                if (c == ' ') {
                    if (spaceCount > 0 || res.Count() == 0) {
                        continue;
                    }
                    spaceCount++;
                    res.Add(holder.ToUpper());
                    holder = "";
                    continue;
                }
                spaceCount = 0;
                holder += c;
            }
            return res.ToArray();
        }
        static readonly Regex trimmer = new Regex(@"\s\s+");

        public static void loadCode(string code, Context engine) {
            List<Instruction> instructions = new List<Instruction>(); 
            var lines = code.Split(Environment.NewLine);
            int Index = 0;
            foreach(string line in lines) {
                if (line.Replace(" ", "") == "") continue;
                //string[] ops = SplitCode(line);
                string lineProcess = trimmer.Replace(line, " ").ToUpper();
                string[] ops = lineProcess.Split(' ');
                string instruction = ops[0];
                // check if label
                if (instruction.Last() == ':') {
                    engine.labels[instruction[..^1]] = Index;
                    continue;
                }
                // check if instruction
                if (!Instructions.InstructionsPool.ContainsKey(instruction))
                    throw new Exception("ERROR: instruction doesn't exist: " + instruction);
                // check operands length
                if(ops.Length - 1 != Instructions.InstructionsPool[instruction].OperandsCount) 
                    throw new Exception("ERROR: incorrect number of operands");
                Index++;
                Operand [] operands = loadOperands(ops, engine);
                instructions.Add(new Instruction(instruction, operands, engine));
            }
            engine.instructions = instructions.ToArray();
        }
        public static Operand[] loadOperands(string[] ops, Context engine) {
            Operand[] operands = new Operand[ops.Length - 1];
            // loop instructions
            if (Instructions.Loops.Contains(ops[0])) {
                operands[0] = new Operand(engine.labels[ops[1]], new DirectAddressing(engine));
                return operands;
            }
            for (int i=1;i<ops.Length; i++) {
                string op = ops[i];

                // string (not allowed)
                //if (op.Length >= 2 && op[0] == '\"' && op[-1] == '\"') {
                //    opernads[i - 1] = new Operand(ops[i].ToString());
                //}
                // memory
                if(op.Length >= 2 && op[0] == '[' && op.Last() == ']') {
                    string subOP = op.Substring(1, op.Length - 2);
                    // memory indirect
                    if (Storage.RegistersIdicies.ContainsKey(subOP)) {
                        operands[i - 1] = new Operand(float.Parse(subOP), new MemoryIndirectAddressing(engine));
                    }
                    // memory direct
                    else
                        operands[i - 1] = new Operand(float.Parse(subOP), new MemoryAddressing(engine));
                }
                // register addressing
                else if (Storage.RegistersIdicies.ContainsKey(op)) {
                    operands[i - 1] = new Operand(Storage.RegistersIdicies[op], new RegisterAddressing(engine));
                }
                // number
                else {
                    operands[i - 1] = new Operand(float.Parse(op), new DirectAddressing(engine));
                }

            }
            return operands;
        }
    }
}
