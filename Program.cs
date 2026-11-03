using System.Diagnostics.CodeAnalysis;
using System.Globalization;
//1
Console.WriteLine("сколько студентов  в группе?");
int sum = 0;
int studentsCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentsCount];
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Оценка студента {i + 1}:");
    grades[i] = int.Parse(Console.ReadLine());
    sum += i;
}
foreach (int grade in grades)
{
    Console.WriteLine(grade);
}
double a = (double)sum / grades.Length;
Console.WriteLine($"Средний балл:{a}");
//2
int[] points = { 43, 23, 42, 9, 5 };
for (int i = 0; i < points.Length; i++)
{
    if (i < 10)
    {
         points[i] = points[i] + 1;
    }
    else
    {
        points[i] = points[i];
    }

}
foreach(int point in points)
{
    Console.WriteLine(point);
}