﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTest.Messages;
using System.IO;

namespace AutoTest.VM.Messages
{
    public abstract class ReplyMessage
    {
        public abstract Guid CorrelationID { get; protected set; }
    }
}
