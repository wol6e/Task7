// Задайте двумерный массив размером mxn, заполненный случайными 
// вещественными числами
//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");

double[,] array = GetArray(m,n);
PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            arr[i,j] =new Random().NextDouble()*10 + new Random().Next(-100,100);
            arr[i,j] = Math.Round(arr[i,j], 2);
        }
    }
    return arr;
    
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void PrintArray(double[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
