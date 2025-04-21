int[][] arr = { [2,3,4], [1,4,6] };


foreach (int[] row in arr)
{
    foreach (int num in row)
        Console.Write($"| {num} ");
    Console.WriteLine("|");
}