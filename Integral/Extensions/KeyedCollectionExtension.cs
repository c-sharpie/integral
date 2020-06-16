using System.Collections.Generic;
using Integral.Collections;

namespace Integral.Extensions
{
    public static class KeyedCollectionExtension
    {
        public static IEnumerable<Value> Select<Key, Value>(this KeyedCollection<Key, Value> keyedCollection, IEnumerable<Key> keys)
            where Key : notnull
            where Value : notnull
        {
            foreach (Key key in keys)
            {
                if (keyedCollection.Peek(key, out Value value))
                {
                    yield return value;
                }
            }
        }

        public static bool CastedPeek<Key, Value, Result>(this KeyedCollection<Key, Value> keyedCollection, Key key, out Result result)
            where Key : notnull
            where Value : notnull
            where Result : notnull, Value
        {
            if (keyedCollection.Peek(key, out Value value) && value is Result match)
            {
                result = match;
                return true;
            }

            result = default!;
            return false;
        }
    }
}