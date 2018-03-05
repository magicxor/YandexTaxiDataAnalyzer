using System;
using System.Collections.Generic;
using System.Linq;

namespace YandexTaxiDataAnalyzer.Core.Extensions
{
    public static class LinqStatistics
    {
        /// <summary>
        /// Computes the Median of a sequence of int values. (see <a href="https://github.com/dkackman/LinqStatistics">LinqStatistics</a>)
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the Median of.</param>
        /// <returns>The Median of the sequence of values.</returns>
        public static double Median(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            var sortedList = (from number in source
                              orderby number
                              select (double)number).ToList();

            int count = sortedList.Count;
            int itemIndex = count / 2;

            if (count % 2 == 0)
            {
                // Even number of items.
                return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / (double)2;
            }

            // Odd number of items.
            return sortedList[itemIndex];
        }

        /// <summary>
        /// Computes the Median of a sequence of double values. (see <a href="https://github.com/dkackman/LinqStatistics">LinqStatistics</a>)
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the Median of.</param>
        /// <returns>The Median of the sequence of values.</returns>
        public static double Median(this IEnumerable<double> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            var sortedList = (from number in source
                              orderby number
                              select (double)number).ToList();

            int count = sortedList.Count;
            int itemIndex = count / 2;

            if (count % 2 == 0)
            {
                // Even number of items.
                return (sortedList[itemIndex] + sortedList[itemIndex - 1]) / (double)2;
            }

            // Odd number of items.
            return sortedList[itemIndex];
        }
    }
}
