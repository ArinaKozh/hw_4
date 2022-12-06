/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

string GetNumber(string message)
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
   return result.ToString();
}

int result = 0;
string a = GetNumber("Введите число");
foreach (char i in a)
{
    result += i - '0';
}
Console.WriteLine(result);