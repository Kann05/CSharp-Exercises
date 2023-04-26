using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        
        Queue<string> names = new Queue<string>();

        names.Enqueue("John");
        names.Enqueue("Mary");
        names.Enqueue("Peter");

        Console.WriteLine("Elements of the Queue:");
        foreach (string name in names) {
            Console.WriteLine(name);
        }

        string removedName = names.Dequeue();
        Console.WriteLine("Removed element from the Queue: " + removedName);

        Console.WriteLine("Elements of the Queue after removal:");
        foreach (string name in names) {
            Console.WriteLine(name);
        }
    }
}
