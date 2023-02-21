class rusashomework2
{
    static void Main(string[] args)
    {

        Console.Write("Gtxovt sheiyvanot X ricxvi: ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot y ricxvi: ");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot z ricxvi: ");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Migebuli shedegi= ");
        Console.WriteLine(x + z * y);
        Console.WriteLine();
        Console.WriteLine();


        Console.Write("saxeli: ");
        string a = Console.ReadLine();
        Console.Write("gvari: ");
        string b = Console.ReadLine();
        Console.Write("mamis saxeli: ");
        string c = Console.ReadLine();
        Console.Write("dabadebis tarigi: ");
        int d = Int32.Parse(Console.ReadLine());


        string vertical = "|";
        string horizontal = "___";
        Console.WriteLine();
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
        Console.WriteLine(" " + "1" + " " + vertical + " " + "2" + " " + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
        Console.WriteLine(" " + "4" + " " + vertical + " " + "5" + " " + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
        Console.WriteLine(" " + "7" + " " + vertical + " " + "8" + " " + vertical + "9");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);

    }
    
}