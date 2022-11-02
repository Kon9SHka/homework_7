Console.Clear();

int m = GetNumberFromUser("Введите m: ");
int n = GetNumberFromUser("Введите n: ");
double[,] array = GetArray(m,n);

CheckPlace(array);

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

double [,] GetArray (int m, int n) 
{
    double[,] array = new double[m,n];
    for (int i = 0; i < array.GetLength(0); i ++) 
    {
        for (int j = 0; j < array.GetLength(1); j ++) 
        {
            array[i,j] = Math.Round(new Random().NextDouble()*100,2);
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void CheckPlace (double[,] array) 
{
        int i = GetNumberFromUser("Введите i: ");
        int j = GetNumberFromUser("Введите j: ");
        try 
        {
            double place = array[i,j];
            Console.WriteLine($"На позиции ({i}, {j}) стоит число -> {array[i,j]}");
        }
        catch 
        {
            Console.WriteLine($"Нет такой позиции в массиве!");
        }
}