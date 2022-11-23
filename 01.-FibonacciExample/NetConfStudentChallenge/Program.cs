using System.Diagnostics;

int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    string suffix = String.Empty;

    switch (n)
    {
        case 1:
            suffix = "st";
            break;
        case 2:
            suffix = "nd";
            break;
        case 3:
            suffix = "rd";
            break;
        default:
            suffix = "th";
            break;
    }

    Debug.WriteLine($"Entering the {nameof(Fibonacci)} method");
    Debug.WriteLine($"Looking up the {n}{suffix} number");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1  = n2;
        n2  = sum;
        Debug.WriteLineIf(sum==1, $"sum is 1, n1 is {n1} and n2 is {n2}");
    }

    //If n2 = 5 continue, else break
    Debug.Assert(n2 == 5, $"The last number should be 5 and is {n2}");
    return n == 0 ? n1 : n2;
}