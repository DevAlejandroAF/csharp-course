

// variables
int number = 5;
double PI = 3.16;
char zone = 'A';
string word = "Hello, world";
bool isActive = false;

static int Add(int num1, int num2)
{
    return num1 + num2;
}

static int Subtract(int num1, int num2)
{
    return num1 - num2;
}
static int Multiply(int num1, int num2)
{
    return num1 * num2;
}
static double Divide(int num1, int num2)
{
    double result = 0.0;

    if (num2 == 0)
    {
        Console.WriteLine("Error: It is not posible divide by 0");
    } else
    {
        result = num1 / num2;
    }

    return result;
}

Console.WriteLine(Add(5, 10));
Console.WriteLine(Subtract(5, 10));
Console.WriteLine(Multiply(5, 10));
Console.WriteLine(Divide(5, 10));

