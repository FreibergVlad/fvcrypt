﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RSA.errors
{
    public class IntegerTooLargeException : DecryptionException
    {
        public IntegerTooLargeException(string message) : base(message)
        {
        }
    }
}
