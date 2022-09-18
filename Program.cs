// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] CreatArray(string massage)
{
    System.Console.Write(massage);
    int Length = int.Parse(Console.ReadLine());
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();

    }
    return array;
}

void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + ", ");
    }
}

string[] CreatNewArrayLessThreeElements(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newStr = new string[count];
    int j=0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            newStr[j] = str[i];
            j++;
        }
    }

    return newStr;
}


string[] str = CreatArray("Введите количесвто элементов массива: ");
System.Console.Write("Заданный массив: ");
PrintArray(str);
System.Console.WriteLine();
System.Console.Write("Массив с длиной элементов <= 3: ");
string[] newStr = CreatNewArrayLessThreeElements(str);
PrintArray(newStr);
