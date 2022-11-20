Console.WriteLine("ВВведите размерность массива: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if(!isParsed)
{
    Console.WriteLine("Не правильно введены данные!");
    return;
}
int[] array = new int[n];
FillArray(array);
PrintArray(array);
int sumeven = CheckEvenSum(array);
Console.WriteLine();
Console.WriteLine($"Сумма эдекментов на нечетной позиции = {sumeven}");

void FillArray(int[] namearray)

{
    int length = namearray.Length;
    int index = 0;
    while (index < length)
    {
        namearray[index] = new Random().Next(99, 1000);
        index++;
    }
}
void PrintArray(int[] araprint)

{
    int size = araprint.Length;
    int position = 0;
    while(position < size)
    {
        Console.Write($" {araprint[position]}");
        position++;
    }
}
 int CheckEvenSum(int[] evenofara)
 {
    int end = evenofara.Length;
    int index = 1;
    int sum = 0;
    while (index < end)
    {
        sum = sum + evenofara[index];
        index+=2;
    }
    return sum;
 }