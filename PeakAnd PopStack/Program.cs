﻿using System;

namespace PeakAnd_PopStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }
}

