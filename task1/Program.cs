using System;
using task1;

class Program
{
    static void Main()
    {
        MyStack myStack = new MyStack(5);

        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        Console.WriteLine(myStack.Pop());  
        Console.WriteLine(myStack.Pop());  
    }
}