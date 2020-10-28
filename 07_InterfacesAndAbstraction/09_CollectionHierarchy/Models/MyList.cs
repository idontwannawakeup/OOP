using _09_CollectionHierarchy.Interfaces;
using System.Collections.Generic;

namespace _09_CollectionHierarchy.Models
{
    class MyList : IAddable, IRemoveable
    {
        private List<string> data = new List<string>();

        public int Add(string item)
        {
            data.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var result = data[0];
            data.RemoveAt(0);
            return result;
        }
    }
}
