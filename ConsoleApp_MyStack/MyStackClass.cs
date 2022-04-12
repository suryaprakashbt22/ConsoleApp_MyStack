using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MyStack
{
    /*internal class MyStackClass
    {
        int arrSize = 0, top;
        int[] arr=new int[1000];

        public MyStackClass()
        {
            top = -1;
        }
        public int size { get { return arrSize; } }
        public int topElement()
        {
            if(top == -1)
                return -1;
            else { return arr[top]; }
            //return arr[top];    
        } 
        //{ get { return arr[this.top]; } } 
        public void Push(int x)
        {
            //this.arrSize++;
            arr[++top] = x;
            //top++;
            arrSize++;
            
        }
        public void Pop()
        {
            arrSize--;
            top--;
        }
        public void display()
        { 
            for(int i=top;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }*/

    interface ICloneable
    {
        void clone(Stack s);
    }
    class clonedStack : ICloneable
    {
        public void clone(Stack s)
        {
            Stack newClonedStack = new Stack();
            newClonedStack = s;
            newClonedStack.PrintStack();

        }
    } 
    class myStackException : Exception
    {
        public myStackException(string message) : base(message) { 
            //Console.WriteLine(message);
        }
    }
    internal class Stack
    {
        static readonly int MAX = 10000;
        int top,size;
        int[] stack;
        public Stack()
        {
            //top =-1;
        }
        public Stack(int st_size)
        {
            this.size = st_size;
            top = -1;
            stack = new int[size];
        }
        //bool IsEmpty()
        //{
        //    return (top < 0);
        //}
        //public Stack()
        //{
        //    top = -1;
        //}
        internal void Push(int data)
        {
            if (top >= this.size)
            {
                try
                {
                    throw new myStackException("Satck Overflow!!");

                }
                catch (myStackException e)
                {
                    Console.WriteLine(e.Message);
                }
                                //Console.WriteLine("Stack Overflow");
                //return false;
            }
            else
            {
                try
                {
                    stack[++top] = data;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                //return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                try
                {
                    throw new myStackException("Satck Overflow!!");

                }
                catch (myStackException e)
                {
                    Console.WriteLine(e.Message);
                }
                //throw new myStackException("Stack Underflow!!");
                //Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal void Peek()
        {
            if (top < 0)
            {
                try
                {
                    throw new myStackException("Satck Overflow!!");

                }
                catch (myStackException e)
                {
                    Console.WriteLine(e.Message);
                }
                //throw new myStackException("Stack Underflow!!");

                //Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        internal void PrintStack()
        {
            if (top < 0)
            {

                try
                {
                    throw new myStackException("Satck Overflow!!");

                }
                catch (myStackException e)
                {
                    Console.WriteLine(e.Message);
                }
                //Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    try
                    {
                        Console.WriteLine(stack[i]);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
        }
    }
}
