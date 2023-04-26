using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        int smallest = numbers[0];
        foreach (int num in numbers) {
            if (num < smallest) {
                smallest = num;
            }
        }
        Console.WriteLine("Smallest element in the List: " + smallest);

        int largest = numbers[0];
        foreach (int num in numbers) {
            if (num > largest) {
                largest = num;
            }
        }
        Console.WriteLine("Largest element in the List: " + largest);
    }
}
