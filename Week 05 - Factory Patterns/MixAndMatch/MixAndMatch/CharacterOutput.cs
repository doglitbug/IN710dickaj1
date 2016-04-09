using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public class CharacterOutput
    {
        /// <summary>
        /// Shows where to output the created character
        /// </summary>
        private PictureBox pbHead, pbBody, pbLegs;
        /// <summary>
        /// The created character
        /// </summary>
        private Character createdCharacter;
        /// <summary>
        /// create the selected character
        /// </summary>
        /// <param name="createdCharacter">A fully completed mixed up character</param>
        /// <param name="pbHead">Picture box for head</param>
        /// <param name="pbBody">Picturebox for body</param>
        /// <param name="pbLegs">Picturebox for legs</param>
        public CharacterOutput(Character createdCharacter, PictureBox pbHead, PictureBox pbBody, PictureBox pbLegs)
        {
            this.createdCharacter = createdCharacter;
            this.pbHead = pbHead;
            this.pbBody = pbBody;
            this.pbLegs = pbLegs;
        }

        /// <summary>
        /// Output our created character to the screen
        /// </summary>
        public void PrintCharacter()
        {
            //Output the created character to the picture boxes for preview
            pbHead.Image = createdCharacter.myHead.Image;
            pbBody.Image = createdCharacter.myBody.Image;
            pbLegs.Image = createdCharacter.myLegs.Image;
            //TODO This is where we would look into created characters parts for the complex instructions
            //that would actually be sent to a 3D printer?
        }
    }
}
