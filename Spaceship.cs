using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BulletClass
{
    class Spaceship : PictureBox
    {
        public Spaceship()
        {
            InitializeSpaceship();
        }

        private void InitializeSpaceship()
        {
            this.BackColor = Color.Orange;
            this.Width = 150;
            this.Height = 50;
        }
    }
}
