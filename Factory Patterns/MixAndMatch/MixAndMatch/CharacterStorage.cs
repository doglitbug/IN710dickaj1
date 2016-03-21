using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class CharacterStorage
    {
        List<Character> avaliableCharacters;
        public CharacterStorage()
        {
            //TODO add in all characters at this point!
            avaliableCharacters.Add(new Fairy());

        }

        /// <summary>
        /// Get a list of characters avaliable to take parts from
        /// </summary>
        /// <returns>String List of character names</returns>
        public List<string> getListofCharacters()
        {
            List<string> names=new List<string>();
            foreach (Character c in avaliableCharacters)
            {
                names.Add(c.Name);
            }
            return names;
        }
    }
}
