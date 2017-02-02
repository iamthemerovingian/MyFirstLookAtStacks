using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLookAtStacks
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Calculator()
        {
            string[] args = new string[] { "5", "6", "7", "*", "+", "1", "-" };
            args = new string[] { "5", "2", "+" };
            StackArray<int> stack = new StackArray<int>();

            foreach (var item in args)
            {
                int integerValue;
                if (int.TryParse(item, out integerValue))
                {
                    stack.Push(integerValue);
                }
                else
                {
                    var rhs = stack.Pop();
                    var lhs = stack.Pop();
                    int result = 0;
                    switch (item)
                    {
                        case "*":
                            result = lhs * rhs;
                            stack.Push(result);
                            break;
                        case "+":
                            result = lhs + rhs;
                            stack.Push(result);
                            break;
                        case "-":
                            result = lhs - rhs;
                            stack.Push(result);
                            break;
                        case "%":
                            result = lhs % rhs;
                            stack.Push(result);
                            break;
                        default:
                            throw new Exception("Unacceptable Argument: " + item);
                    }
                }
            }
            Console.WriteLine("Result of the operation is: " + stack.Peek());
        }
    }
}
