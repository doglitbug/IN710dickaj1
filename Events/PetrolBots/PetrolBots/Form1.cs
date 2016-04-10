using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public partial class Form1 : Form
    {
        private World world;
        private Random random;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a new rng
            random = new Random();

            //Get worlds max size
            Point world_size=new Point(this.Width,this.Height);
            
            //Get the graphics object
            Graphics mainCanvas = this.CreateGraphics();

            //Create a new World
            world = new World(random, world_size,mainCanvas);
        }
    }
}
