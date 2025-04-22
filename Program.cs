int[,] arr = { { 2, 3, 4 }, //Row 0
               { 1, 4, 6 } }; //Row 1

for(int row = 0;  row < arr.GetLength(0); row++)  
{
    for(int col = 0;  col < arr.GetLength(1); col++)
        Console.Write($"| {arr[row, col]} ");
    Console.WriteLine("|");
}