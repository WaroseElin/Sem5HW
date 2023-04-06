Console.WriteLine("Введите размер: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
Array(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Max = {max}, Min = {min}");
Console.WriteLine($"Разница между Max и Min = {max - min}");

void Array(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{

    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    Console.WriteLine();
}