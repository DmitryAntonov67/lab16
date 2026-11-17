using System.Diagnostics.CodeAnalysis;
using System.Globalization;
// //1
// Console.WriteLine("сколько студентов  в группе?");
// int sum = 0;
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.WriteLine($"Оценка студента {i + 1}:");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum += i;
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// double a = (double)sum / grades.Length;
// Console.WriteLine($"Средний балл:{a}");
// //2
// int[] points = { 43, 23, 42, 9, 5 };
// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }

// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// //3
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }
// //4
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }
// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }
//     return slots;
// }
// int[] slots = GenerateEvenSlots(6);
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }

// //5 
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// //Самостоятельные задачи
//  //A
//  Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine());

// int[] squares = new int[n];

// for (int i = 0; i < squares.Length; i++)
// {
//     int number = i + 1;
//     squares[i] = number * number;
// }

// foreach (int square in squares)
// {
//     Console.WriteLine(square);
// }
// //Б
//  int[] numbers = { 5, -3, 12, -8, 0, -1, 7 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }

//5
{
    int[] arr = { 10, 20, 30, 40, 50 };

    for (int i = 0; i < arr.Length / 2; i++)
    {
        int oppositeIndex = arr.Length - 1 - i;
        int temp = arr[i];
        arr[i] = arr[oppositeIndex];
        arr[oppositeIndex] = temp;
    }

    foreach (int item in arr)
    {
        Console.WriteLine(item);
    }
}

//7 
{
    int[] original = { 2, -3, 4, 5 };
    int[] squared = SquareAll(original);

    foreach (int item in squared)
    {
        Console.WriteLine(item);
    }
}

int[] SquareAll(int[] numbers)
{
    int[] result = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = numbers[i] * numbers[i];
    }

    return result;
}
