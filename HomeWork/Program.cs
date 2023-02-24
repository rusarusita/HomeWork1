class rusashomework2
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(5,7));
        MinMax(1, 2, 3, 4);
        Fruit();
    }

    static int Sum(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    static void MinMax(decimal a, decimal b, decimal c, decimal d)
    {
        decimal max = a;
        decimal min = a;

        if (b > max) max = b;
        if (c > max) max = c;
        if (d > max) max = d;

        if (b < min) min = b;
        if (c < min) min = d;
        if (d < min) min = d;
        Console.WriteLine(max);
        Console.WriteLine(min);
    }

    static void Fruit()
    {
        Console.WriteLine("Enter fruit");
        Console.WriteLine("Example apple, watermelon, melon, cherry, strawberry");
        string fruit = Console.ReadLine();

        switch (fruit)
        {
            case "apple":
                Console.WriteLine("You entered apple");
                break;
            case "watermelon":
                Console.WriteLine("You entered watermelon");
                break;
            case "melon":
                Console.WriteLine("You entered melon");
                break;
            case "cherry":
                Console.WriteLine("You entered cherry");
                break;
            case "strawberry":
                Console.WriteLine("You entered strawberry");
                break;
            default:
                Console.WriteLine("Entered wrong word!");
                break;
        }
    }

}