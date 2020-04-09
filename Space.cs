using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletClass
{
    public partial class Space : Form
    {
        Spaceship spaceShip;
        Bullet freshBullet;
        
        public Space()
        {
            InitializeComponent();
            InitializeSpace();
        }
        private void InitializeSpace()
        {
            this.BackColor = Color.DarkBlue;
            spaceShip = new Spaceship();
            spaceShip.Top = ClientRectangle.Height - spaceShip.Height;
            spaceShip.Left = 100;
            this.Controls.Add(spaceShip);
        }

        private void FireBullet()
        {
            freshBullet = new Bullet();
            freshBullet.Top = spaceShip.Top - freshBullet.Height;
            freshBullet.Left = spaceShip.Left;
            this.Controls.Add(freshBullet);
        }

        private void Space_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                FireBullet();
            }
        }
    }
}
