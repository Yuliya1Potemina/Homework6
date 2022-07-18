/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите число M(количество чисел)");
int M = int.Parse(Console.ReadLine());
int[] massiveNumbers = new int[M];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = int.Parse(Console.ReadLine());
  }
}
int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");