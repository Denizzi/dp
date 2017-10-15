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

        private SingletonFirstVersion()
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
