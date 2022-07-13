//Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа в группе друг на друга не делились? Найдите M при заданном N 
// и получите одно из разбиений на группы N ≤ 10²⁰.
// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
int groupIndex = 1;

Console.WriteLine();
Console.Write("numbers = {");
FillArray(numbers);
Console.WriteLine("};");
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] != 0)
    {
        int index = 0;
        int[] groupOfnumbers = new int[numbers.Length];
        for (int j = i; j < numbers.Length; j++)
        {
            if (numbers[j] % numbers[i] != 0 || numbers[j] / numbers[i] == 1)
            {
                groupOfnumbers[index] = numbers[j];
                index++;
            }
        }
        for (int l = 1; l < groupOfnumbers.Length; l++)
        {
            for (int m = l + 1; m < groupOfnumbers.Length; m++)
            {
                if (groupOfnumbers[l] != 0 && groupOfnumbers[m] % groupOfnumbers[l] == 0)
                {
                    groupOfnumbers[m] = 0;
                }
            }
        }
        for (int k = 0; k < numbers.Length; k++)
        {
            for (int x = 0; x < groupOfnumbers.Length; x++)
            {
                if (groupOfnumbers[x] == numbers[k])
                {
                    numbers[k] = 0;
                }
            }
        }
        Console.Write($"Группа № {groupIndex}: ");
        for (int y = 0; y < groupOfnumbers.Length; y++)
        {
            
            if (groupOfnumbers[y] != 0)
            {
                Console.Write(groupOfnumbers[y] + " ");
            }
        }
        groupIndex++;
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.Write($"При заданном N = {n}, количество групп M  = {groupIndex}!");

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        Console.Write(array[i] + " ");
    }
}


