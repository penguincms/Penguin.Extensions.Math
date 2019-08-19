﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Math.Extensions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static class ULongExtensions
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
        /// <summary>
        /// Inclusive/Exclusive bounds check for an ulong
        /// </summary>
        /// <param name="x">The value to check</param>
        /// <param name="a">The lower inclusive bounds</param>
        /// <param name="b">The upper exclusive bounds</param>
        /// <returns>Whether or not the int falls between the values</returns>
        public static bool Between(this ulong x, ulong a, ulong b)
        {
            return x >= a && x < b;
        }
    }
}