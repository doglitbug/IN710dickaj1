using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class StringReverse:IEncryption
    {
        public string Encrypt(string input)
        {
            //Copied from http://www.dotnetperls.com/reverse-string
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string Decrypt(string input)
        {
            return Encrypt(input);
        }
    }
}
