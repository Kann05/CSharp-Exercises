using System;

public class Stack
{
    private int[] elements; 
    private int count; 

    public Stack()
    {
        elements = new int[4];
        count = 0;
    }

    public int Capacity
    {
        get { return elements.Length; }
    }

   
    public int Count
    {
        get { return count; }
    }

    public void Push(int element)
    {
        if (count == elements.Length)
        {
            Grow(); 
        }
        elements[count] = element;
        count++; 
    }


    public int Pop()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty"); 
        }
        count--; 
        return elements[count];
    }

   
    private void Grow()
    {
        int[] newElements = new int[elements.Length * 2];
        Array.Copy(elements, newElements, count); 
        elements = newElements; 
    }


    public int[] ToArray()
    {
        int[] array = new int[count];
        Array.Copy(elements, array, count); 
        return array;
    }
    public class Program{
        public static void Main(){
            Stack stack = new Stack();
            stack.Push(4);
            stack.Pop();
            stack.ToArray();
        }
    }
}
