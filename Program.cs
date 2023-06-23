/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2



int [] RandomArray ()
{
    int size = 6; //new Random().Next(4, 14);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(99, 1000);
    }
    return randomArray;

}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void CountOfElem (int [] countArray)
{
    int count = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        if (countArray[i] %2 == 0)
            count++;
    }
    Console.WriteLine(count);
}

int [] randomArray = RandomArray();
PrintArray(randomArray);
CountOfElem(randomArray);


Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0



int [] RandomArray ()
{
    int size = new Random().Next(4, 14);
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-100, 100);
    }
    return randomArray;

}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void FindSum (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
            sum += array[i];
    Console.WriteLine(sum);
}

int [] randomArray = RandomArray();
PrintArray(randomArray);
FindSum(randomArray);



Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


*/

double [] RandomArray ()
{
    int size = new Random().Next(4, 7);
    double [] randomArray = new double [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = (new Random().NextDouble()*10);
        randomArray[i] = Math.Round(randomArray[i], 2);
    }
    return randomArray;

}

void PrintArray(double [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

double MaxMin(double [] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
        {
            if (max<randomArray[i])
            max = randomArray[i];
            if (min>randomArray[i])
            min = randomArray[i];
            i = i + 1;
        }
    double diff = max - min;
    Console.WriteLine($"{max} - {min} = {diff}");
    return diff;
}


double [] randomArray = RandomArray();
PrintArray(randomArray);
MaxMin(randomArray);


