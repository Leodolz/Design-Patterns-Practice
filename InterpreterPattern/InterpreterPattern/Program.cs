using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InterpreterTerminal interpreter = new InterpreterTerminal();
            while (true)
            {
                interpreter.InterpretExpression(Console.ReadLine());
            }
        }
    }
}
