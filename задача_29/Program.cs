/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
*/


int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result))
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Неверно ввели число");
    }
   } 
   return result;
}

int[] ArrayInput()
{
    int []array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = GetNumber($"Введите {i+1}-ый элемент");
    }
    return array;
}

void ArrayOutput(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int []array = ArrayInput();
ArrayOutput(array);