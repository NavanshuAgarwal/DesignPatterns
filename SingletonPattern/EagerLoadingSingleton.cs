using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class EagerLoadingSingleton
    {
        private static readonly EagerLoadingSingleton _instance = new EagerLoadingSingleton();

        private EagerLoadingSingleton()
        {

        }

        public static EagerLoadingSingleton GetInstance()
        {
            return _instance;
        }

    }
}
