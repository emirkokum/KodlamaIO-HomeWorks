using Dictionary;

internal class Program
{
    private static void Main(string[] args)
    {

        MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();

        myDictionary.Add(1, "John");
        myDictionary.Add(2, "James");
        myDictionary.Add(3, "Alex");
        myDictionary.ShowAll();
    }
}