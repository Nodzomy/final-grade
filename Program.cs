
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

int MAX_WORD_LENGTH = 3;

// Находим элементы массива которые <=3  и перезаписываем в новый массив string[] result
string[] GetShortWordsArray(string[] array) 
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MAX_WORD_LENGTH)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

// Вывод массива на экран поэлементно, проверка на отсутсвие элементов в массиве
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Массив пуст");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

// Вывод результатов задачи в упорядоченом виде
void PrintTask(string[] array)
{
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"Массив результатов (слов меньше или равно, чем {MAX_WORD_LENGTH})");
    PrintArray(shortArray);
    Console.WriteLine();
}

PrintTask(array1);
PrintTask(array2);
PrintTask(array3);


