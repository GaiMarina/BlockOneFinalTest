/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не ремомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string[] Array = new string[] {"hello", "2", "world", ":-)"};

int count = 0; 

for(int i = 0; i < Array.Length; i++)
{   
    if(Array[i].Length < 4)
        count++;
}

string[] newArray = new string[count];

int j = 0;

for(int i = 0; i < Array.Length; i++)
{   
    if(Array[i].Length < 4)
     {
        newArray[j] = Array[i];
        j++;
    }
}

PrintArray(newArray);
