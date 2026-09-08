// Build: 7d02eeb9cb67f42f8235cd5a42e9a0a7
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
