void Zadacha34()
{
    //задайте массив заполненный случайными положительными трёхзначными числами. 
    //напишите программу, которая покажет количество чётных чисел в массиве.

    Random random = new Random();
    int size = random.Next(5, 11);
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0) count++;
        }
    Console.WriteLine($"В массиве {count} четных чисел");  
}

void Zadacha37()
{
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях
    Random random = new Random();
    int size = random.Next(5, 11);
    int[] array = new int[size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
        {
            sum += array[i];
        }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {sum}");  
}


void Zadacha38()
{
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементом массива.
Random random = new Random();
int size = random.Next(5, 11);
double[] array = new double[size];
FillArrayDouble(array, 1000, 100000);
PrintArrayDouble(array);

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
    Console.WriteLine($"Разница между минимальным элементом {min}  и максимальным {max} равна {max - min}");
}


void FillArrayDouble(double[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10 - 5, 2);
    }
}


void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }

}

void PrintArrayDouble(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine();
}


void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine();
}



//Zadacha34();
//Zadacha37();
Zadacha38();