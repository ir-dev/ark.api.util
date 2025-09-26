using System;
using System.Collections.Generic;

namespace ark.net.util
{
    public class PwdUtil
    {
        public static (bool, List<string>) ValidatePolicy(string pwd)
        {
            return ValidatePolicy(pwd, new PwdPolicy());
        }
        public static (bool, List<string>) ValidatePolicy(string pwd, PwdPolicy validator)
        {
            var result = validator.ValidatePassword(pwd);
            return (result.IsValid, result.Errors);
        }
        public static string Hash(string pwd)
        {
            return PwdHasher.HashPassword(pwd);
        }
    }
}
