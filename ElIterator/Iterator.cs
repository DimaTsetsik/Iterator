namespace ElIterator
{
    class Iterator<T>: IIterator
    {
        private Collection CurrentCollection;
        private int CurrentElement = 0;
        private int CurrentStep = 1;
        private T Element;

        public Iterator(Collection collection)
        {
            CurrentCollection = collection;
        }

        // Gets first item
        public Item<int> First()
        {
            CurrentElement = 0;
            return CurrentCollection[CurrentElement] as Item<int>;
        }

        // Gets next item
        public Item<int> Next()
        {
            CurrentElement += CurrentStep;
            if (!IsDone)
                return CurrentCollection[CurrentElement] as Item<int>;
            else
                return null;
        }

        public int Step
        {
            get { return CurrentStep; }
            set { CurrentStep = value; }
        }

        // Gets current iterator item
        public Item<int> GetCurrentItem
        {
            get { return CurrentCollection[CurrentElement] as Item<int>; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return CurrentElement >= CurrentCollection.Count; }
        }
    }
}
