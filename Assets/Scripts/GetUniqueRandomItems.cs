using System;
using System.Collections.Generic;
using System.Linq;
using Random = System.Random;

public sealed class RandomUniqueCollectionInitiliazer<T>
{
    #region PRIVATE FIELDS

    private readonly List<T> _collection;
    private readonly Random _rng;

    #endregion


    #region PUBLIC METHODS

    public RandomUniqueCollectionInitiliazer(IEnumerable<T> items)
    {
        _collection = items.ToList();
        _rng = new Random(DateTime.Now.Millisecond);
    }
    
    public IEnumerable<T> GetUniqueRandomItems(int count)
    {
        if (count <= 0)
            throw new ArgumentOutOfRangeException(nameof(count), "count must be greater than 0");

        if (count >= _collection.Count)
        {
            return _collection;
        }
        else
        {
            var result = new List<T>();
            while (result.Count < count)
            {
                var index = _rng.Next(_collection.Count);
                result.Add(_collection[index]);
                _collection.RemoveAt(index);
            }
            return result;
        }
    }

    #endregion
}


