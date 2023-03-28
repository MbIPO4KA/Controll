Написать программу, коорая из имеющегося массива строк, формирует массив строк, длина которых
меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры
либо задать на старте выполнения алгоритма. Прирешении не рекомендуется пользоваться 
 коллекциями, лучше обойтись исключительно массивами.

Сначала берём текст. В нашем случае с консоли
назначаем максимальную длину в тексте.
int maxLength = 3; // максимальная длинна искомого слова

Пишем метод для замены знаков в ТЕКСТЕ
меняем запятые на пробелы

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

получаем текст без запятых
Далее преобразуем текст в массив, попутно избавляясь от других знаков препинания

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

Теперь у нас есть чистый массив без знаков препинания, разделённый пробелами

Вычисляем все комбинации , менее трёх знаков
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


ну и выводим наш шедевр на Консоль


Console.WriteLine("Найденые слова:");
string[] rezultText = SelectionText(RemoveSignsText(newText), maxLength);
Console.Write($"[{string.Join(',', rezultText)}]");
Console.WriteLine();

Единственный недостаток, это то, что при вводе дробных чисел строка читает его как целое.
