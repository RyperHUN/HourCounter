using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Security
    {
        public static void InitializationGuard (bool isInitialized)
        {
            if (!isInitialized)
                throw new InitializationMissingException ();
        }
    }
}
