
// validation
// lab 6
// Cullen Kelley kellec2@etsu.edu
// csci 1250-001
// 10-25-22
// homewoek 6





ShowCharacter("new york", 2);

CalculateRetail();

for (int x = 80; x <= 100; x++)
{
    double c = Celcius(x);
    Console.WriteLine($"farengheight:{x} Celcius:{c}");
}
IsPrime(7);
IsPrime(42);
IsPrime(29);
static void ShowCharacter(string s, int x)
{

    {
        x = x - 1;
        Console.WriteLine(s[x]);
        Console.WriteLine("\n");

    }
}
static void CalculateRetail()
{
    Console.Write("what is the price of the item ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(" what is the markup percentage ");
    double markup = Convert.ToDouble(Console.ReadLine());
    double markupAsDeciaml = markup / 100;
    double total = (price * markupAsDeciaml) + price;
    Console.Write(total);
    Console.WriteLine("\n");

}
static double Celcius(int f)
{
    double celcius = (f - 32.0) * (5.0 / 9.0);
    return celcius;
}

static bool IsPrime(int bob)
{
    if (bob <= 1) { Console.WriteLine("false"); return false; }
    for (int i = 2; i < Math.Sqrt(bob); i++)
    {
        if (bob % i == 0) { Console.WriteLine("False"); return false; }


    }
    Console.WriteLine("True");
    return true;


}

