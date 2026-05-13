namespace et_game
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            this.t_celestWalk = new System.Windows.Forms.Timer(this.components);
            this.t_celestIdle = new System.Windows.Forms.Timer(this.components);
            this.p_L1xandermeet = new System.Windows.Forms.Panel();
            this.t_chat = new System.Windows.Forms.Timer(this.components);
            this.t_xanderWalk = new System.Windows.Forms.Timer(this.components);
            this.p_L1part2 = new System.Windows.Forms.Panel();
            this.p_L1xandermeet.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_celestWalk
            // 
            this.t_celestWalk.Tick += new System.EventHandler(this.t_celestWalk_Tick);
            // 
            // t_celestIdle
            // 
            this.t_celestIdle.Interval = 300;
            this.t_celestIdle.Tick += new System.EventHandler(this.t_celestIdle_Tick);
            // 
            // p_L1xandermeet
            // 
            this.p_L1xandermeet.Controls.Add(this.p_L1part2);
            this.p_L1xandermeet.Location = new System.Drawing.Point(0, 3);
            this.p_L1xandermeet.Name = "p_L1xandermeet";
            this.p_L1xandermeet.Size = new System.Drawing.Size(987, 473);
            this.p_L1xandermeet.TabIndex = 0;
            this.p_L1xandermeet.Paint += new System.Windows.Forms.PaintEventHandler(this.p_L1xandermeet_Paint);
            // 
            // t_chat
            // 
            this.t_chat.Interval = 1000;
            this.t_chat.Tick += new System.EventHandler(this.t_chat_Tick);
            // 
            // t_xanderWalk
            // 
            this.t_xanderWalk.Tick += new System.EventHandler(this.t_xanderWalk_Tick);
            // 
            // p_L1part2
            // 
            this.p_L1part2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_L1part2.Location = new System.Drawing.Point(7, 0);
            this.p_L1part2.Name = "p_L1part2";
            this.p_L1part2.Size = new System.Drawing.Size(979, 472);
            this.p_L1part2.TabIndex = 0;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 477);
            this.Controls.Add(this.p_L1xandermeet);
            this.DoubleBuffered = true;
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Level1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            this.p_L1xandermeet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t_celestWalk;
        private System.Windows.Forms.Timer t_celestIdle;
        private System.Windows.Forms.Panel p_L1xandermeet;
        private System.Windows.Forms.Timer t_chat;
        private System.Windows.Forms.Timer t_xanderWalk;
        private System.Windows.Forms.Panel p_L1part2;
    }
}