using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    //This exception is thrown when you don't call a classes initialization function
    class InitializationMissingException : ApplicationException
    {
        string _message;
        public InitializationMissingException () { }

        public InitializationMissingException (string message)
        {
            _message = message;
        }

        public override string ToString () 
        {
            return _message + " Class initialization function was not called.";
        }
        public string ToStringSensitive ()
        {
            return _message + " Class initialization function was not called." + base.ToString ();
        }
    }
}
