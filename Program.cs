/* Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
Например для N = 50, M получается 6 */

Console.Clear();

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine());

double groupMax = Math.Truncate(Math.Log(num, 2)) + 1;
//Console.WriteLine(group);
int group = 0;

Console.Write($"Группа 1: 1");

for (int i = 2; i <= num; i++)
{
    group = Convert.ToInt32(Math.Truncate(Math.Log(i, 2)));

    if (group > Convert.ToInt32(Math.Truncate(Math.Log(i - 1, 2))))
    {
        Console.WriteLine();
        Console.Write($"Группа {group +1}: {i}");
    }

    else if (i >= Math.Pow(2, group) && i < Math.Pow(2, group + 1))
    {
        Console.Write(", " + i);
    }
}