namespace Sprite_2D
{
    partial class UserControlSprite2D
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.playToolStripMenuItem,
            this.switchPlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 158);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedUpToolStripMenuItem,
            this.speedDownToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // speedUpToolStripMenuItem
            // 
            this.speedUpToolStripMenuItem.Name = "speedUpToolStripMenuItem";
            this.speedUpToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.speedUpToolStripMenuItem.Text = "Speed Up";
            this.speedUpToolStripMenuItem.Click += new System.EventHandler(this.speedUpToolStripMenuItem_Click);
            // 
            // speedDownToolStripMenuItem
            // 
            this.speedDownToolStripMenuItem.Name = "speedDownToolStripMenuItem";
            this.speedDownToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.speedDownToolStripMenuItem.Text = "Speed Down";
            this.speedDownToolStripMenuItem.Click += new System.EventHandler(this.speedDownToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomUpToolStripMenuItem,
            this.zoomDownToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomUpToolStripMenuItem
            // 
            this.zoomUpToolStripMenuItem.Name = "zoomUpToolStripMenuItem";
            this.zoomUpToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.zoomUpToolStripMenuItem.Text = "Zoom Up";
            this.zoomUpToolStripMenuItem.Click += new System.EventHandler(this.zoomUpToolStripMenuItem_Click);
            // 
            // zoomDownToolStripMenuItem
            // 
            this.zoomDownToolStripMenuItem.Name = "zoomDownToolStripMenuItem";
            this.zoomDownToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.zoomDownToolStripMenuItem.Text = "Zoom Down";
            this.zoomDownToolStripMenuItem.Click += new System.EventHandler(this.zoomDownToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // switchPlayerToolStripMenuItem
            // 
            this.switchPlayerToolStripMenuItem.Name = "switchPlayerToolStripMenuItem";
            this.switchPlayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.switchPlayerToolStripMenuItem.Text = "Switch Player";
            this.switchPlayerToolStripMenuItem.Click += new System.EventHandler(this.switchPlayerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UserControlSprite2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControlSprite2D";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UserControlSprite2D_PreviewKeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
