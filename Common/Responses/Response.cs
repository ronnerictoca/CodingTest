﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Common.Responses
{
    public interface Response
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
