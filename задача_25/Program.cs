/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) && result>0)
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

int A = GetNumber("Введите число, которое нужно возвести в степень ");
int B = GetNumber("Введите степень");

Console.WriteLine($"Резульат = {Math.Pow(A,B)}");