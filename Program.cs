// See https://aka.ms/new-console-template for more information
Console.WriteLine("please enter the first number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("please enter the second number");
int second = int.Parse(Console.ReadLine());
for (int i = first; i <= second; i++)
{
    int sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            sum += j;
        }
    }
    if (sum == i)
    {
        Console.WriteLine(i );
    }
}