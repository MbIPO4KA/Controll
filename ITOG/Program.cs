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

/// <summary>
/// Преобразование строк в массив 
/// </summary>
/// <param name="str">Текст</param>
/// <returns>Массив слов</returns>
string[] RemoveSignsText(string str) // загружаем строку
{   
    string[] RemoveSigns = { ".", "!", ","};  // удаляем ненужные знаки из текста
    for (int i = 0; i < RemoveSigns.Length; i++)
    {
        str = str.Replace(RemoveSigns[i], string.Empty);// методом Replace, где первый аргумент - встречающиеся знаки,
                                                     // а второй на что заменять. В нашем случае - это пусто
    }
    return str.Split(" "); //возвращение массива с использованием символа пробела в качестве разделителя
}

/// <summary>
/// Поиск слов по их длинне
/// </summary>
/// <param name="str">Массив слов</param>
/// <param name="wordLength">максимальное значение знаков</param>
/// <returns>Массив найденых слов</returns>
string[] SelectionText(string[] str, int maxLength)
{
    string newString = string.Empty; // создадим пустую строку и заполним 
    for (int i = 0; i < str.Length; i++) // для всех индексов
    {
        if (str[i].Length <= maxLength)  // если количество букв не превышает 
        {
            newString = newString + str[i] + " "; // набираем слова по условию задачи
        }
    }    
    return newString.Split(" ");//возвращение массива с использованием символа пробела в качестве разделителя
    
}

Console.WriteLine("Найденые слова:");
string[] rezultText = SelectionText(RemoveSignsText(newText), maxLength);
Console.Write($"[{string.Join(',', rezultText)}]");
Console.WriteLine();