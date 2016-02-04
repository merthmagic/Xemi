namespace Xemi.Core.Caching
{
    public class NullCacheManager : ICacheManager
    {
        public T Get<T>(string key)
        {
            return default(T);
        }

        public void Set(string key, object data, int cacheTime)
        {

        }

        public bool IsSet(string key)
        {
            return false;
        }

        public void Remove(string key)
        {

        }

        public void RemoveByPattern(string pattern)
        {

        }

        public void Clear()
        {

        }
    }
}