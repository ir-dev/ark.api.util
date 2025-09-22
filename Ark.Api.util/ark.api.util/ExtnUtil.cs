using System;

namespace ark.net.util
{
    public static class ExtnUtil
    {
        public static bool AnyNull(this string? val)
        {
            return val == null || string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);
        }
    }
}
