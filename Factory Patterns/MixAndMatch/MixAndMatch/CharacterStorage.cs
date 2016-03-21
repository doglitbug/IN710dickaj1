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
            avaliableCharacters = new List<Character>();
            //TODO add in all characters at this point!
            avaliableCharacters.Add(new Fairy());
            avaliableCharacters.Add(new Frankenstein());

        }

        /// <summary>
        /// Get a list of characters avaliable to take parts from
        /// </summary>
        /// <returns>String List of character names</returns>
        public List<string> getListofCharacters()
        {
            List<string> names = new List<string>();
            foreach (Character c in avaliableCharacters)
            {
                names.Add(c.Name);
            }
            return names;
        }

        /// <summary>
        /// Get a head based off the characters name
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <returns>The characters head</returns>
        public Head getHeadFromSelection(string characterName)
        {
            Head selectedHead = null;
            foreach (Character c in avaliableCharacters)
            {
                if (c.Name == characterName)
                {
                    selectedHead = c.myHead;
                }
            }
            return selectedHead;
        }

        /// <summary>
        /// Get a Body based off the characters name
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <returns>The characters Body</returns>
        public Body getBodyFromSelection(string characterName)
        {
            Body selectedBody = null;
            foreach (Character c in avaliableCharacters)
            {
                if (c.Name == characterName)
                {
                    selectedBody = c.myBody;
                }
            }
            return selectedBody;
        }

        /// <summary>
        /// Get a Legs based off the characters name
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <returns>The characters Legs</returns>
        public Legs getLegsFromSelection(string characterName)
        {
            Legs selectedLegs = null;
            foreach (Character c in avaliableCharacters)
            {
                if (c.Name == characterName)
                {
                    selectedLegs = c.myLegs;
                }
            }
            return selectedLegs;
        }
    }
}

