using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite_2D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void userControlSprite2D1_KeyDown(object sender, KeyEventArgs e)
        {
            userControlSprite2D1.Sprite2DControl_KeyDown(e.KeyCode);
           
        }

        private void userControlSprite2D1_KeyUp(object sender, KeyEventArgs e)
        {
            userControlSprite2D1.Sprite2DControl_KeyUp(e.KeyCode);
        }

        private void userControlSprite2D1_MouseDown(object sender, MouseEventArgs e)
        {
            userControlSprite2D1.Sprite2DControl_MouseDown(e.Button);
        }

        private void userControlSprite2D1_MouseUp(object sender, MouseEventArgs e)
        {
            userControlSprite2D1.Sprite2DControl_MouseUp(e.Button);
        }
    }
}
