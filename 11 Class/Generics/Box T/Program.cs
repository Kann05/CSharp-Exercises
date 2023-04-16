using System;

class Box<T>
{
    private T[] elements;
    private int count;

    public Box()
    {
        elements = new T[10];
        count = 0;
    }

    public void Add(T element)
    {
        if (count < elements.Length)
        {
            elements[count] = element;
            count++;
        }
        else
        {
            Console.WriteLine("Box is full!");
        }
    }

    public T Remove()
    {
        if (count > 0)
        {
            count--;
            T element = elements[count];
            elements[count] = default(T);
            return element;
        }
        else
        {
            Console.WriteLine("Box is empty!");
            return default(T);
        }
    }

    public int Count
    {
        get { return count; }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Box<int> box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        Console.WriteLine(box.Remove());
        box.Add(4);
        box.Add(5);
        Console.WriteLine(box.Remove());
    }
}
