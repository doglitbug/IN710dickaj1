using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Rot13 : IEncryption
    {
        public string Encrypt(string input)
        {
            //Copied from http://www.dotnetperls.com/rot13
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }



        public string Decrypt(string input)
        {
            //Yes I realise that this is a really cheap method of decrypting
            //but rot13*2=rot0...
           return Encrypt(string);
        }
    }
}
