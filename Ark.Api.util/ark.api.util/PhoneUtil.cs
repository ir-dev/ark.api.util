namespace ark.net.util
{
    public class PhoneUtil
    {

    }
    public static class PhoneExtn
    {
        public static bool IsValidPhone(this string? val)
        {
            if (val.AnyNull()) return false;
            if (val.Length < 10) return false;
            return true;
        }
    }
}
