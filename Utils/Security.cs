using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Security
    {
        public static void initializationGuard (bool isInitialized)
        {
            if (!isInitialized)
                throw new InitializationMissingException ();
        }
    }
}
