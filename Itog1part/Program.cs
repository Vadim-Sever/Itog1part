Console.Clear();

Console.WriteLine("Введите размер массива");
int razmer = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите текст для заполнения массива");
string[] array = new string[razmer];
FillArray(array);
int newrazmer = MonitoringArray(array);
string[] newarray = new string[newrazmer];
FillArray2(array, newarray);
PrintArray(newarray);

void FillArray(string[] InputArray)
{
    int length = InputArray.Length;
    for (int i = 0; i < length; i++)
    {
        InputArray[i] = Console.ReadLine();
    }
}

int MonitoringArray(string[] InputArray)
{
    int length = InputArray.Length;
    int res = 0;
    for (int i = 0; i < length; i++)
    {
        if (InputArray[i].Length <= 3)
        {
            res++;
        }
    }
    return res;
}

void FillArray2(string[] InputArray, string[] InputArray2)
{
    int length = InputArray.Length;
    int j = 0;
    for (int i = 0; i < InputArray.Length; i++)
    {
        if (InputArray[i].Length <= 3)
        {
            InputArray2[j] = InputArray[i];
            Console.WriteLine($"Элемент {j} массива = {InputArray2[j]}"); // проверка
            j++;
        }
    }
}

void PrintArray(string[] InputArray)
{
    int length = InputArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine(InputArray[i]);
    }
}
