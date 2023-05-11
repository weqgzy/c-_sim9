// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputNumbers("Введите от: ");
int n = InputNumbers("Введите до: ");
int res = m;

if (m > n) 
{
  m = n; 
  n = res;
}

PrintSumm(m, n, res = 0);

void PrintSumm(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSumm(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}