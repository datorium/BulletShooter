using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BulletClass
{
    class Bullet : PictureBox
    {
        private Timer shootTimer;
        private int verVelocity = 0;
        private int horVelocity = 0;
        private int bulletStep = 2;


        public Bullet()
        {
            InitializeBullet();
            InitializeShootTimer();
        }

        private void InitializeShootTimer()
        {
            shootTimer = new Timer();
            shootTimer.Interval = 20;
        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Red;
            this.Height = 100;
            this.Width = 20;
        }
    }
}
