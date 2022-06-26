using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class LazyLoadingSingleton
    {
        private static readonly Lazy<LazyLoadingSingleton> _instance = new Lazy<LazyLoadingSingleton>(() => new LazyLoadingSingleton());

        private LazyLoadingSingleton() 
        {

        }

        public static LazyLoadingSingleton GetInstance()
        {
            return _instance.Value;
        }

    }
}

