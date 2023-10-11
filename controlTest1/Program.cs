/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
  коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введите количество элементов в массиве:");
int symbolsNumberUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний предел диапазона символов в элементе массива:");
int maxBorder= Convert.ToInt32(Console.ReadLine());

void PrintUserArray(string[] userArray)
{
    Console.Write($"[");
    for (int i = 0; i < (userArray.Length - 1); i++)
    {
        Console.Write($" {userArray[i]},");
    }
    for (int j = (userArray.Length - 1); j < userArray.Length; j++)
    {
        Console.Write($" {userArray[j]}");
    }
    Console.Write($" ]");
}

int HowMuchLetterInNewRandomWord(int border) // метод для генерации переменной сколько символов в последующем элементе массива
{
    int howLetters = new Random().Next(1, border + 1);
    return howLetters;
}

string[] GetRandomWord(int symbolsNumberUser, int maxBorder) // метод генерации массива случайных слов
{
    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();     // Создаем массив букв, которые мы будем использовать.
    string[] stringArray = new string[symbolsNumberUser];  // создаём наш массив который будем заполнять словами и возвращать
   
    for (int i = 0; i < stringArray.Length; i++)
    {

        string word = string.Empty;
        int wordLength = HowMuchLetterInNewRandomWord(maxBorder);
        for (int j = 0; j < wordLength; j++)
        {
            int letter_num = new Random().Next(0, letters.Length);// Выбор случайного числа от 0 до 25 для выбора буквы из массива букв.

            word += letters[letter_num];
        }
        stringArray[i] = word;

    }
    return stringArray;
}

string [] NewArray3x (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    string [] newArray3x = new string[count];
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray3x[number] = array[i];
            number++;
        }
    }
    return newArray3x;
}  

string [] userArray = GetRandomWord (symbolsNumberUser, maxBorder);
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Ваш первоначальный массив(заполнили рандомно) :");
PrintUserArray(userArray);


string [] readyArray = NewArray3x(userArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Ваш массив удовлетворящий решению условия задачи : ");
PrintUserArray(readyArray);