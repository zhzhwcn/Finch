﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Finch.Exceptions
{
    public class FinchInitializationException : FinchException
    {
        public FinchInitializationException(string message) : base(message)
        {
        }
    }
}