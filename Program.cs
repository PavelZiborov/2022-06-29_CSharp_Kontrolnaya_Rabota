/*

1. Метод, который принимает на вход массив строк
2. Метод, который печатает массив строк
3. Основной метод, принимает массив строк и на возвращает массив строк, в котором длина каждого элемента строки <= 3

*/

string[] UserInput() // 1. Метод, который принимает на вход массив строк
{
    int count = 0;
    string s;
    string[] mainArray;
    string[] tempArray;
    mainArray = new string[count];
    Console.WriteLine("Введите несколько строк, разделяя их ENTER.\nЧто бы закончить ввод нажми ENTER без ввода символов.");
    Console.WriteLine("Поехали:\n");

    do
    {
        s = Console.ReadLine();
        if (s != string.Empty)
        {
            count++;
            tempArray = new string[count];
            for (int i = 0; i < tempArray.Length - 1; i++)
            {
                tempArray[i] = mainArray[i];
            }
            tempArray[count - 1] = s;
            mainArray = tempArray;
        }
    } while (s != string.Empty);
    return mainArray;
}

void PrintStringArray(string[] array) // 2. Метод, который печатает массив строк
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        if (i != array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}']");
    }
    Console.WriteLine();
}

string[] ReducingToThreeСharacters(string[] incomingArray) // 3. Метод, принимает массив строк и на возвращает массив строк, в котором длина каждого элемента <= 3
{
    string[] outgoingArray; // исходящий массив
    string[] tempArray;     // Temp-массив
    int count = 0;
    outgoingArray = new string[count];
    for (int i = 0; i < incomingArray.Length; i++) // проходим по всему входящему массиву
    {
        if (incomingArray[i].Length <= 3) // условие добавления в новый массив
        {
            count++;
            tempArray = new string[count];
            for (int j = 0; j < tempArray.Length - 1; j++) // копируем в новый Temp-массив элементы исходящего массива
            {
                tempArray[j] = outgoingArray[j];
            }
            tempArray[count - 1] = incomingArray[i]; // добавляем в Temp-массив последним элементом, подходящий условию, элемент из входящего
            outgoingArray = tempArray;
        }
    }
    return outgoingArray;
}

string[] array = UserInput();
Console.Write($"Исходный массив     -> ");
PrintStringArray(array);
string[] reducingArray = ReducingToThreeСharacters(array);
Console.Write($"Получившийся массив -> ");
PrintStringArray(reducingArray);