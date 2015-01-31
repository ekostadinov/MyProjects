using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaApiTestFramework.Utils.dbAccessors.mySQL.MySqlException
{
    class MySqlAccessorException : Exception
    {
        public MySqlAccessorException()
        {
        }

        public MySqlAccessorException(string message)
            : base(message)
        {
        }

        public MySqlAccessorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
