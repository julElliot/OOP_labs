using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    public class Plugins
    {
        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.GetEncoding(1251).GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.GetEncoding(1251).GetString(base64EncodedBytes);
        }
    }
}
