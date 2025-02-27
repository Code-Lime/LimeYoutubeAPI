﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LimeYoutubeAPI.Extentions
{
    internal static class SpanExtentions
    {
        public static ReadOnlySpan<T> TakeBetwen<T>(this ReadOnlySpan<T> source, ReadOnlySpan<T> beganKey, ReadOnlySpan<T> endKey) where T: IEquatable<T>
        {
            var startIndx = source.IndexOf(beganKey) + beganKey.Length;
            if (startIndx == -1) return ReadOnlySpan<T>.Empty;

            var endIndx = source[startIndx..].IndexOf(endKey);
            if (endIndx == -1) return ReadOnlySpan<T>.Empty;

            return source.Slice(startIndx, endIndx - startIndx);
        }
    }
}
