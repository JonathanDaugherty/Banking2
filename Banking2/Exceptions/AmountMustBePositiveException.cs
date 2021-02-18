using System;
using System.Collections.Generic;
using System.Text;

namespace Banking2.Exceptions {
    class AmountMustBePositiveException : Exception {
        
        public AmountMustBePositiveException() : base() { }
        
        public AmountMustBePositiveException(string Message) : base(Message) { }

        public AmountMustBePositiveException(string Message, Exception InnerException) 
            : base(Message, InnerException) { }
        
        
    }
}
