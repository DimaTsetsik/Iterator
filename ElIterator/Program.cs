using System;

namespace ElIterator
{
    class Program
    {
        static void Main()
        {
            Collection collection = new Collection();
            collection[0] = new Item<int>("Item", 1);
            collection[1] = new Item<int>("Item", 2);
            collection[2] = new Item<int>("Item", 3);
            collection[3] = new Item<int>("Item", 3);
            collection[4] = new Item<int>("Item", 4);
            collection[5] = new Item<int>("Item", 5);
            collection[6] = new Item<int>("Item", 6);
            collection[7] = new Item<int>("Item", 7);
            collection[8] = new Item<int>("Item", 7);

            Iterator<Item<int>> iterator = collection.CreateIterator();
            iterator.Step = 2;

            Console.WriteLine("Go:");

            for (Item<int> item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine($"{item.GetName} {item.GetValue}");
            }

            Console.ReadKey();
        }
    }
}