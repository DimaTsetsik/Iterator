namespace ElIterator
{
    interface IIterator
    {
        Item<int> First();
        Item<int> Next();
        Item<int> GetCurrentItem { get; }
        bool IsDone { get; }
    }
}