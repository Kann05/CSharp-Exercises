int[] nums = { 1, 2, 3, 4, 5, 6};

int count = nums.Count(x => x % 2 == 1);
System.Console.WriteLine($"Count is : {count}");

    nums = nums
    .Where(num => num % 2 == 0)
    .ToArray(); 

foreach (int num in nums){
    System.Console.WriteLine(num);
}


