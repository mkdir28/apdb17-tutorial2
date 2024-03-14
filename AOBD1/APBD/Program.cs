// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");
Console.WriteLine("Modification 4");

static double GetAverage(int[] num)
{
    double sums = 0.0;
    for (int i = 0; i < num.Length; i++)
    {
        sums += num[i];
    }

    return sums / num.Length;
}

//4 task - Rebase
static double GetMax(int[] num)
{
    double max = Double.NegativeInfinity;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > max)
            max = num[i];
    }
    return max;
}

int[] num = {1,2,3,4};
//we can use "var" (like in c++ auto)
double avg = GetAverage(num);
double max = GetMax(num);
Console.WriteLine(avg);
Console.WriteLine(max);