using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        
        Queue<int> numbers = new Queue<int>();

        numbers.Enqueue(10);
        numbers.Enqueue(20);
        numbers.Enqueue(30);

        int first = numbers.Peek();
        Console.WriteLine("First element in the Queue: " + first);

        int last = 0;
        foreach (int num in numbers) {
            last = num;
        }
        Console.WriteLine("Last element in the Queue: " + last);
    }
}
