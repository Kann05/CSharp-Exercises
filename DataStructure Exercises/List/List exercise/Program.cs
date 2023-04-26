using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine("Elements of the List:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }

        numbers.Remove(20);

        Console.WriteLine("Elements of the List after removal:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }
}
