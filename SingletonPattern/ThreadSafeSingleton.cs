using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance = null;
        private static readonly object _lock = new object();

        private ThreadSafeSingleton()
        {

        }

        //Double-Check Locking
        public static ThreadSafeSingleton GetThreadSafeSingleton()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }
            return _instance;
        }

    }
}
