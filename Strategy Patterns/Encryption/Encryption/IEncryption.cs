using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    /// <summary>
    /// Provides an interface for differnt encryption engines
    /// </summary>
    public interface IEncryption
    {
        /// <summary>
        /// Encrypts the given string
        /// </summary>
        /// <param name="input">String to encrypt</param>
        /// <returns>Encrypted string</returns>
        public String Encrypt(String input);
        /// <summary>
        /// Decrypts the given string
        /// </summary>
        /// <param name="input">String to decrypt</param>
        /// <returns>Decrpyted string</returns>
        public String Decrypt(String input);
    }
}
