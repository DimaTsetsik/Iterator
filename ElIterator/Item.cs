namespace ElIterator
{
    class Item<T>
    {
        public string ItemName;
        public T ItemValue; 

        public Item(string name, T value)
        {
            ItemName = name;
            ItemValue = value;
        }

        public T GetValue { 
            get { return ItemValue; }
        }

        public string GetName
        {
            get { return ItemName; }
        }
    }
}
