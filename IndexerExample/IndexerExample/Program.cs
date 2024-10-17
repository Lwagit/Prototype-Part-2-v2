using System;

public class SimpleStringCollection
{
    private string[] elements;

    public SimpleStringCollection(int size)
    {
        elements = new string[size];
    }

    // Indexer to get or set string elements
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return elements[index];
        }
        set
        {
            if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            elements[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a collection with 3 elements
        SimpleStringCollection collection = new SimpleStringCollection(3);

        // Use the indexer to set values
        collection[0] = "Hello";
        collection[1] = "World";
        collection[2] = "Indexer";

        // Use the indexer to get values
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(collection[i]);
        }
    }
}
