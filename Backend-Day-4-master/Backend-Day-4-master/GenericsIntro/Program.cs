using GenericsIntro;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        MyList<int> myList = new MyList<int>();
        myList.Add(15);
        
    }
}