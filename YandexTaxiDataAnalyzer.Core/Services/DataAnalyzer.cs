using System;
using System.Collections.Generic;
using System.Linq;
using YandexTaxiDataAnalyzer.Core.Extensions;
using YandexTaxiDataAnalyzer.Core.Models;

namespace YandexTaxiDataAnalyzer.Core.Services
{
    public class DataAnalyzer
    {
        public IList<StatisticsItem<TKey, double?>> GetStatistics<TModel, TKey>(
            IEnumerable<TModel> data,
            Func<TModel, TKey> keySelector,
            Func<TModel, double?> valueSelector)
        {
            Func<IList<double?>, double> averageSelector = (values) => { return values.Where(v => v.HasValue).Average(v => v.Value); };
            Func<IList<double?>, double> medianSelector = (values) => { return values.Where(v => v.HasValue).Select(v => v.Value).Median(); };
            Func<IList<double?>, double?> sumSelector = (values) => { return values.Where(v => v.HasValue).Sum(v => v.Value); };
            return GetStatistics(data, keySelector, valueSelector, averageSelector, medianSelector, sumSelector);
        }

        public IList<StatisticsItem<TKey, int?>> GetStatistics<TModel, TKey>(
            IEnumerable<TModel> data,
            Func<TModel, TKey> keySelector,
            Func<TModel, int?> valueSelector)
        {
            Func<IList<int?>, double> averageSelector = (values) => { return values.Where(v => v.HasValue).Average(v => v.Value); };
            Func<IList<int?>, double> medianSelector = (values) => { return values.Where(v => v.HasValue).Select(v => v.Value).Median(); };
            Func<IList<int?>, int?> sumSelector = (values) => { return values.Where(v => v.HasValue).Sum(v => v.Value); };
            return GetStatistics(data, keySelector, valueSelector, averageSelector, medianSelector, sumSelector);
        }

        public IList<StatisticsItem<TKey, TValue>> GetStatistics<TModel, TKey, TValue>(
            IEnumerable<TModel> data,
            Func<TModel, TKey> keySelector,
            Func<TModel, TValue> valueSelector,
            Func<IList<TValue>, double> averageSelector,
            Func<IList<TValue>, double> medianSelector,
            Func<IList<TValue>, TValue> sumSelector)
        {
            var result = data
                .GroupBy(
                    keySelector,
                    valueSelector,
                    (key, values) => new
                    {
                        Key = key,
                        Values = values.ToList(),
                    })
                .Select(group => new StatisticsItem<TKey, TValue>
                {
                    Key = group.Key,
                    Values = group.Values,
                    Count = group.Values.Count,
                    Average = averageSelector(group.Values),
                    Median = medianSelector(group.Values),
                    Sum = sumSelector(group.Values)
                })
                .OrderBy(grouping => grouping.Key)
                .ToList();
            return result;
        }
    }
}
