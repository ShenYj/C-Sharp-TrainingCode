using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Day复习
{
    // 单例练习
    class SingleClass
    {

        public static SingleClass _singleClass = null;

        private SingleClass()
        {
        }

        public static SingleClass Shared()
        {
            if (_singleClass != null) return _singleClass;
            _singleClass = new SingleClass();
            return _singleClass;
        }
    }
}
