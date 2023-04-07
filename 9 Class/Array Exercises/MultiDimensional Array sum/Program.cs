Console.WriteLine("Enter the number of rows:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns:");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine("Enter the value for element ({0},{1}):", i, j);
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] rowSums = new int[rows];
int[] colSums = new int[cols];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        rowSums[i] += matrix[i, j];
        colSums[j] += matrix[i, j];
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write("{0} ", matrix[i, j]);
    }
    Console.WriteLine("Row {0} sum = {1}", i, rowSums[i]);
}

for (int j = 0; j < cols; j++)
{
    Console.WriteLine("Column {0} sum = {1}", j, colSums[j]);
}

int totalSum = rowSums.Sum();
Console.WriteLine("Total sum of all elements = {0}", totalSum);
