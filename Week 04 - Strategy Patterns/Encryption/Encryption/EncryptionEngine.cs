using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class EncryptionEngine
    {
        /// <summary>
        /// Current used engine
        /// </summary>
        public IEncryption currentEngine;

        /// <summary>
        /// Constructor
        /// </summary>
        public EncryptionEngine()
        {
            //Set a default engine in case encrypt/decrypt are called before changeEngine
            //Too lazy to throw exceptions
            currentEngine=new Rot13();
        }

        /// <summary>
        /// Pass encryption through to the currently selected engine
        /// </summary>
        /// <param name="input">String to encrypt</param>
        /// <returns>Encrypted string</returns>
        public String Encrypt(String input)
        {
            return currentEngine.Encrypt(input);
        }

        /// <summary>
        /// Pass decryption through to the currently selected engine
        /// </summary>
        /// <param name="input">String to decrypt</param>
        /// <returns>Decrypted string</returns>
        public String Decrypt(String input)
        {
            return currentEngine.Decrypt(input);
        }

        /// <summary>
        /// Signals to the endgine to change its method of encryption/decryption
        /// </summary>
        /// <param name="engineNumber">1-rot13 2-string reverse</param>
        /// TODO Chnage this to an enum?
        public void ChangeEngine(int engineNumber)
        {
            switch (engineNumber)
            {
                case 1:
                    currentEngine = new Rot13();
                    break;
                case 2:
                    currentEngine = new StringReverse();
                    break;
                default:
                    currentEngine = new Rot13();
                    break;
            }
        }
    }
}
