using _09_CollectionHierarchy.Interfaces;
using System.Collections.Generic;

namespace _09_CollectionHierarchy.Models
{
    class AddRemoveCollection : IAddable, IRemoveable
    {
        private List<string> data = new List<string>();

        public int Add(string item)
        {
            data.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }
    }
}
