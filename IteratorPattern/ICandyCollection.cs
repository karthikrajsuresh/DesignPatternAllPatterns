namespace IteratorPattern
{
    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        IJellyBeanIterator CreateIterator();
    }
}
