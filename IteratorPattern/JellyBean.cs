namespace IteratorPattern
{
    /// <summary>
    /// Our collection item.  Mostly because I'm a sucker for jelly beans.
    /// </summary>
    class JellyBean
    {
        private string _flavor;

        // Constructor
        public JellyBean(string flavor)
        {
            this._flavor = flavor;
        }


        public string Flavor
        {
            get { return _flavor; }
        }
    }
}
