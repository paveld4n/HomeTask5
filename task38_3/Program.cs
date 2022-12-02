// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементов массива.

Console.WriteLine("ВВведите размерность массива: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}
double[] array = new double[n];
FillArray(array);
Console.Write("Сгенерированный массив: ");
PrintArray(array);
Console.WriteLine();

double minnumber = CheckMinNum(array);
Console.WriteLine($"Минимальный элемент в массиве = {minnumber}");

double maxnumber = CheckMaxNum(array);
Console.WriteLine($"Максимальный элемент в массиве = {maxnumber}");

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxnumber - minnumber}");

void FillArray(double[] namearray)
{
    Random random = new Random();
    int length = namearray.Length;
    int index = 0;
    while (index < length)
    {
        namearray[index] = random.Next(1, 100) + Math.Round(random.NextDouble(), 2);
        index++;
    }
}

void PrintArray(double[] araprint)
{
    int size = araprint.Length;
    int position = 0;
    while(position < size)
    {
        Console.Write($" {araprint[position]}");
        position++;
    }
}
 
 double CheckMinNum(double[] minofara) 
 {
    double min = minofara[0];
    for (int i = 0; i < n; i++)
    {
        if(minofara[i] < min)
        {
            min = minofara[i];
        }
    }
    return min;
 }

double CheckMaxNum(double[] maxofara) 
 {
    double max = maxofara[0];
    for (int i = 0; i < n; i++)
    {
        if(maxofara[i] > max)
        {
            max = maxofara[i];
        }
    }
    return max;
 }