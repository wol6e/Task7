// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается 
// элемент входных данных


int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int minValue = Prompt("Введите число минимального диапазона: ");
int maxValue = Prompt("Введите число максимального диапазона: ");

int[,] array = GetArray(rows,columns,minValue,maxValue);
PrintArray(array);
Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i =0; i<arr.GetLength(0); i++)  
    {
        for(int j=0; j<arr.GetLength(1); j++)   
        {
            Console.Write(arr[i,j]+ " ");
        }
        Console.WriteLine();
    } 
}

 int[] GetRowArray(int[,] inArray)
 {
     int[] result = new int[inArray.Length];
     int index = 0;
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            result[index]= inArray[i,j];
            index++;
        }
    }
    return result;
 }

 void SortArray(int[] inArray)
 {
    for(int i=0; i<inArray.Length; i++)
    {
        for(int j=i+1; j<inArray.Length; j++)
        {
            if (inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
 } 

 void PrintData(int[] inArray)
 {
    int el=inArray[0];
    int count = 1;
    for(int i=1; i<inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
 }


