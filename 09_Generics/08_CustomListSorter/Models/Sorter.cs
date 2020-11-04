using System;

namespace _08_CustomListSorter.Models
{
    static class Sorter
    {
        public static void Sort<T>(CustomList<T> customList)
            where T : IComparable<T>
        {
            for (int i = 0; i < customList.Count; i++)
                for (int j = i + 1; j < customList.Count; j++)
                    if (customList[i].CompareTo(customList[j]) > 0)
                        customList.Swap(i, j);
        }
    }
}
