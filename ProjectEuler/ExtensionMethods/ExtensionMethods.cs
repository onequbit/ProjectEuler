﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static partial class ExtensionMethods
    {
        

        public static void ThrowIfNull(this object thing, string message = "")
        {
            if (thing == null) throw new NullReferenceException();
        }

    }
}
