using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class MBExtensions
    {
        public static string OnlyLettersAndDigits(this string value)
        {
            return new string(value.Where(Char.IsLetterOrDigit).ToArray());
        }

        public static void TypeCheckWithException(this Type value, Type otherType)
        {
            if (value != otherType)
            {
                throw new Exception(string.Format("Object type mismatch! Given: {0} Expected: {1}", value, otherType));
            }
        }
    }
}
