//Написать программу, коорая из имеющегося массива строк, формирует массив строк, длина которых
//меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры
//либо задать на старте выполнения алгоритма. Прирешении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите текст или же целые числа (через запятую или пробел) или дробные через точку:");


string text = Console.ReadLine();

int maxLength = 3; // максимальная длинна искомого слова
Console.WriteLine("Исходный текст:");
Console.WriteLine(text);
Console.WriteLine();

/// <summary>
/// метод заменяет одни знаки другими
/// </summary>
/// <param name="text">заданный текст</param>
/// <param name="oldValue">запятая</param>
/// <param name="newValue">пробел</param>
/// <returns></returns>
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ',' , ' '  );
