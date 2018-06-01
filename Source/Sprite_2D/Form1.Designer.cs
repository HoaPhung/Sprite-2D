namespace Sprite_2D
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControlSprite2D1 = new Sprite_2D.UserControlSprite2D();
            this.SuspendLayout();
            // 
            // userControlSprite2D1
            // 
            this.userControlSprite2D1.Location = new System.Drawing.Point(-7, -1);
            this.userControlSprite2D1.Name = "userControlSprite2D1";
            this.userControlSprite2D1.Size = new System.Drawing.Size(507, 409);
            this.userControlSprite2D1.TabIndex = 0;
            this.userControlSprite2D1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userControlSprite2D1_KeyDown);
            this.userControlSprite2D1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userControlSprite2D1_KeyUp);
            this.userControlSprite2D1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userControlSprite2D1_MouseDown);
            this.userControlSprite2D1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.userControlSprite2D1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 410);
            this.Controls.Add(this.userControlSprite2D1);
            this.Name = "Form1";
            this.Text = "My Sprite 2D";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlSprite2D userControlSprite2D1;
    }
}

