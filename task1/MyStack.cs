using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    public class MyStack
    {
        private int[] array;  
        private int top;       

   
        public MyStack(int size)
        {
            array = new int[size];
            top = -1;  
        }

       
        public void Push(int value)
        {
            if (top == array.Length - 1)
            {
                Console.WriteLine("Стек переполнен. Невозможно добавить элемент.");
            }
            else
            {
                top++;
                array[top] = value;
            }
        }

        
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Стек пуст. Невозможно извлечь элемент.");
                return -1;  
            }
            else
            {
                int poppedValue = array[top];
                top--;
                return poppedValue;
            }
        }
    }
}
