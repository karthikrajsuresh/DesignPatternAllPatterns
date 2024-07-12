using System.Collections;

namespace IteratorPattern
{
    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        IJellyBeanIterator ICandyCollection.CreateIterator()
        {
            throw new NotImplementedException();
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
