using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton _instance = null;

        private NaiveSingleton()
        {

        }

        public static NaiveSingleton GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new NaiveSingleton();
            }
            return _instance;
        }

        public void BusinessLogic()
        {

        }
    }
}
