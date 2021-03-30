using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackRealization.StackFolder
{
    class Stack
    {
        private char[] stack { get; set; }
        private int length => stack.Length;
        private int MaxLength { get; set; }
        private int tail { get; set; } 

        public Stack(int maxlength)
        {
            MaxLength = maxlength;
        }

        public void Push(char element)
        {
            if (length < MaxLength)
            {
                stack.Append(element);
                tail = stack[stack.Length - 1];
            }
            else throw new ArgumentOutOfRangeException(nameof(element));
        }

        public bool IsEmpty()
        {
            if (length == 0) return true;
            else return false;
        }
    }
}
