﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SoundOffDrill.Biz
{
    /// <summary>
    /// Shuffle List extension
    /// </summary>
    /// <remarks>
    /// Written by Rob Thijssen
    /// from https://stackoverflow.com/a/1262619
    /// </remarks>
    static class ShuffleExtension
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 +
                Thread.CurrentThread.ManagedThreadId))); }
        }
    }
}
