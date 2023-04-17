class Program
{
    public static void Main()
    {
        List<int> nums = new List<int>{ 10, 22, 1, 4};

        nums = nums
        .OrderBy(num => num)
        .ToList();

        foreach(int num in nums)
        {
            System.Console.WriteLine(num);
        }
    }
}