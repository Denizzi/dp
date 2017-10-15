using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonFirstVersion
    {
        private static SingletonFirstVersion instance = null;

        private SingletonFirstVersion() // Can only be instantiated inside the class itself
        {
        }

        public static SingletonFirstVersion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonFirstVersion();
                }
                return instance;
            }
        }
    }
}
