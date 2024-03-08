// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");
Console.WriteLine("Modification 4");

static double GetAverage(int[] num)
{
    double sum = 0.0;
    for (int i = 0; i < num.Length; i++)
    {
        sum += num[i];
    }

    return sum / num.Length;
}