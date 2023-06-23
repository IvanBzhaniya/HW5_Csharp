/*

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/

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