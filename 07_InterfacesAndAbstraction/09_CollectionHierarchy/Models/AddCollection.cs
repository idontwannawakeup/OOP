using _09_CollectionHierarchy.Interfaces;
using System.Collections.Generic;

namespace _09_CollectionHierarchy.Models
{
    class AddCollection : IAddable
    {
        private List<string> data = new List<string>();

        public int Add(string item)
        {
            data.Add(item);
            return data.Count - 1;
        }
    }
}
