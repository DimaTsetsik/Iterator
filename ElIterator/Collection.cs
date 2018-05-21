using System.Collections;

namespace ElIterator
{
    class Collection: IAbstractCollection
    {
        private ArrayList Items = new ArrayList();

        public Iterator<Item<int>> CreateIterator()
        {
            return new Iterator<Item<int>>(this);
        }

        public int Count
        {
            get { return Items.Count; }
        }

        public object this[int index]
        {
            get { return Items[index]; }
            set { Items.Add(value); }
        }
    }
}
