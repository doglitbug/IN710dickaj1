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
            //TODO Entry point for new characters
            //IRL would be read form folder list in a directory
            avaliableCharacters.Add(new Fairy());
            avaliableCharacters.Add(new Frankenstein());
            avaliableCharacters.Add(new Skeleton());
            avaliableCharacters.Add(new Vampire());
            avaliableCharacters.Add(new Werewolf());
            avaliableCharacters.Add(new Witch());

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
        /// Create a new mixed up character from parts
        /// </summary>
        /// <param name="head">Name of the head</param>
        /// <param name="body">Name of the body</param>
        /// <param name="legs">Name of the legs</param>
        /// <returns>Newly created Character</returns>
        public Character createCharacterFromSelection(string head, string body, string legs)
        {
            //Set up placeholder character
            Character newCharacter = new Character();
            //Get the individual parts
            newCharacter.myHead = getHeadFromSelection(head);
            newCharacter.myBody = getBodyFromSelection(body);
            newCharacter.myLegs = getLegsFromSelection(legs);
            return newCharacter;
        }
        /// <summary>
        /// Get a head based off the characters name
        /// </summary>
        /// <param name="characterName">Name of the character</param>
        /// <returns>The characters head</returns>
        private Head getHeadFromSelection(string characterName)
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

