Console.Clear();

int m = GetNumberFromUser("Введите m: ");
int n = GetNumberFromUser("Введите n: ");

int[,] array = GetArray(m,n);
AvgOfColumn(array);

int GetNumberFromUser (string message) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        while(isCorrect)
            return number;
        Console.WriteLine("Ошибка ввода!");
    }
}

int [,] GetArray (int m, int n) 
{
    int[,] array = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            array[i,j] = new Random().Next(0,101);
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void AvgOfColumn (int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0);i++)
        {
            sum = sum + array[i,j];
        }
        Console.WriteLine($"Ср. Арифметическое столбца №{j+1} -> {Math.Round(Convert.ToDouble(sum)/array.GetLength(0),2)}");
        sum = 0;
    }
}