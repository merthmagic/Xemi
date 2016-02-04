using System;
using System.Collections.Concurrent;
using System.Configuration;

namespace Xemi.Core.Configuration
{
    public class ConfigResolver
    {
        private sealed class CacheConfigResolver : IConfigResolver
        {
            private readonly IConfigResolver _resolver;

            private readonly ConcurrentDictionary<string,string> _cache = new ConcurrentDictionary<string, string>();
 
            public CacheConfigResolver(IConfigResolver resolver)
            {
                _resolver = resolver;
            }

            public string GetConfig(string key)
            {
                return _cache.GetOrAdd(key, _resolver.GetConfig);
            }
        }

        private class DefaultConfigResolver : IConfigResolver
        {
            //To make things simpler,the default config resolver just read
            //configurations from AppSettings.
            //A more complicated resolver will be added soon.
            public string GetConfig(string key)
            {
                return ConfigurationManager.AppSettings[key];
            }
        }

        private static readonly ConfigResolver _instance = new ConfigResolver();

        private IConfigResolver _current;

        private CacheConfigResolver _currentCache;

        public static IConfigResolver Current
        {
            get { return _instance.InnerCurrent; }
        }

        internal static IConfigResolver CurrentCache
        {
            get { return _instance.InnerCurrentCache; }
        }

        public IConfigResolver InnerCurrent
        {
            get { return _current; }
        }

        internal IConfigResolver InnerCurrentCache
        {
            get { return _currentCache;}
        }

        public ConfigResolver()
        {
            InnerSetResolver(new DefaultConfigResolver());
        }

        public static void SetResolver(IConfigResolver resolver)
        {
            _instance.InnerSetResolver(resolver);
        }

        public void InnerSetResolver(IConfigResolver resolver)
        {
            if(resolver == null)
                throw new ArgumentNullException("resolver");
            _current = resolver;
            _currentCache = new CacheConfigResolver(resolver);
        }
    }
}