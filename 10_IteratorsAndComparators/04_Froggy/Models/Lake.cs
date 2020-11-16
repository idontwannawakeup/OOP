using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Froggy.Models
{
    class Lake : IEnumerable<int>
    {
        private List<int> stoneNumbers;

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stoneNumbers.Count; i += 2)
                yield return stoneNumbers[i];

            int idx = stoneNumbers.Count % 2 == 0
                ? stoneNumbers.Count - 1
                : stoneNumbers.Count - 2;

            for (int i = idx; i >= 0; i -= 2)
                yield return stoneNumbers[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public Lake(List<int> numbers)
        {
            stoneNumbers = numbers;
        }
    }
}
