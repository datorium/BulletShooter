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
        private int bulletStep = 5;

        public Bullet()
        {
            InitializeBullet();
            InitializeShootTimer();
        }

        private void InitializeShootTimer()
        {
            shootTimer = new Timer();
            shootTimer.Tick += new EventHandler(shootTimer_Tick);
            shootTimer.Interval = 20;
            verVelocity = -bulletStep;
            shootTimer.Start();
        }

        private void shootTimer_Tick(object sender, EventArgs e)
        {
            this.Top += verVelocity;
            this.Left += horVelocity;
            if(this.Top < 0 - this.Height)
            {
                this.Dispose();
                shootTimer.Stop();
            }
        }

        private void InitializeBullet()
        {
            this.BackColor = Color.Red;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
