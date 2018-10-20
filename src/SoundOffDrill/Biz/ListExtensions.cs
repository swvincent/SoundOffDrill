using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundOffDrill.Biz
{
    public static class ListExtensions
    {
        // https://stackoverflow.com/a/24258558
        public static IEnumerable<List<T>> Split<T>(this List<T> source, int count)
        {
            int rangeSize = source.Count / count;
            int additionalItems = source.Count % count;
            int index = 0;

            while (index < source.Count)
            {
                int currentRangeSize = rangeSize + ((additionalItems > 0) ? 1 : 0);
                yield return source.GetRange(index, currentRangeSize);
                index += currentRangeSize;
                additionalItems--;
            }
        }
    }
}
