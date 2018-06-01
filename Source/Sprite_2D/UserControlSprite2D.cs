using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite_2D
{
    public partial class UserControlSprite2D : UserControl
    {
        private Sprite2D player;
        Bitmap bm;
        bool picture = false;
        bool pause = false;
        bool dragPlayer = false;



        public UserControlSprite2D()
        {
            InitializeComponent();
            player = new Sprite2D(picture, bm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.width = 32;
            player.height = 48;
            if (picture == true)
            {
                bm = new Bitmap(Properties.Resources.picture1);
            }
            else
            {
                bm = new Bitmap(Properties.Resources.picture2);
            }
            Graphics g = this.CreateGraphics();
            BufferedGraphicsContext doubleBuffer = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = doubleBuffer.Allocate(g, this.ClientRectangle);
            buffer.Graphics.Clear(Color.White);
            if (dragPlayer == true)
            {
                Point p = this.PointToClient(Cursor.Position);
                player.y = p.Y - (player.width * player.currentScale) / 2;
                player.x = p.X - (player.height * player.currentScale) / 2;
            }
            player.movePlayer(buffer, bm);
            buffer.Render(g);
        }

        public void Sprite2DControl_MouseUp(MouseButtons mb)
        {
            if (mb == MouseButtons.Left)
            {
                dragPlayer = false;
            }
        }

        public void Sprite2DControl_MouseDown(MouseButtons mb)
        {
            Point p = this.PointToClient(Cursor.Position);
            if (mb == MouseButtons.Left)
            {
                if (p.X >= player.x && p.X <= (player.x + player.width * player.currentScale) && p.Y >= player.y && p.Y <= (player.y + player.height * player.currentScale))
                {
                    dragPlayer = true;
                }

            }
            else if (mb == MouseButtons.Right)
            {
                contextMenuStrip1.Show(p);
            }
        }

        private void UserControlSprite2D_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void speedUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 10;
        }

        private void speedDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void zoomUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomUp();
        }

        private void zoomDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomDown();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause = true;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause = false;
        }

        public void Sprite2DControl_KeyUp(Keys e)
        {
            player.action = StateAction.Standing;
        }

        public void Sprite2DControl_KeyDown(Keys e)
        {
            if (pause == false)
            {
                switch (e)
                {
                    case Keys.Left:
                        player.action = StateAction.Left;
                        break;
                    case Keys.Right:
                        player.action = StateAction.Right;
                        break;
                    case Keys.Down:
                        player.action = StateAction.Down;
                        break;
                    case Keys.Up:
                        player.action = StateAction.Up;
                        break;
                }
            }
            switch (e)
            {
                case Keys.OemCloseBrackets:
                    ZoomUp();
                    break;
                case Keys.OemOpenBrackets:
                    ZoomDown();
                    break;
                case Keys.Add:
                    timer1.Interval -= 10;
                    break;
                case Keys.Subtract:
                    timer1.Interval += 10;
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
                case Keys.P:
                    pause = false;
                    break;
                case Keys.S:
                    pause = true;
                    break;
                case Keys.B:
                    if (picture == false)
                        picture = true;
                    else
                        picture = false;
                    break;
            }
        }
        public void ZoomUp()
        {
            player.currentScale++;
        }
        public void ZoomDown()
        {
            if (player.currentScale > 1)
                player.currentScale--;
        }

        private void switchPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picture == false)
                picture = true;
            else
                picture = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
