﻿using System;
using System.Text;

namespace MangoApps.Client
{
    public class Encoder
    {
        public static String ToBase64String(string source)
        {
            return Convert.ToBase64String(Encoding.UTF32.GetBytes(source.ToCharArray()));
        }
    }
}
