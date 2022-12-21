Console.WriteLine("please enter the first num");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("please enter the second num");
int num2 = int.Parse(Console.ReadLine());
for (int i = num1; i <= num2; i++)
{
    int j;
    for (j = 2; j <= i; j++)
    {
        if (i % j == 0)
        {
         break;
        }
    }
        if (j == i)
        {
            Console.WriteLine(i);
        }
    

}

