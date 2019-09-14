﻿using System;
using System.Linq;
using System.Runtime.Serialization;

namespace Bot3PG.Utilities
{
    [Serializable]
    public class CommandException : Exception
    {
        public CommandException() { }
        public CommandException(string message) : base(message) { }
        public CommandException(string message, Exception inner) : base(message, inner) { }
        protected CommandException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}