namespace et_game
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
            this.p_startScreen = new System.Windows.Forms.Panel();
            this.p_main = new System.Windows.Forms.Panel();
            this.p_startScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_startScreen
            // 
            this.p_startScreen.Controls.Add(this.p_main);
            this.p_startScreen.Location = new System.Drawing.Point(1, 0);
            this.p_startScreen.Name = "p_startScreen";
            this.p_startScreen.Size = new System.Drawing.Size(923, 589);
            this.p_startScreen.TabIndex = 0;
            this.p_startScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.p_startScreen_Paint);
            this.p_startScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_startScreen_MouseClick);
            // 
            // p_main
            // 
            this.p_main.Location = new System.Drawing.Point(1, 2);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(922, 587);
            this.p_main.TabIndex = 0;
            this.p_main.Paint += new System.Windows.Forms.PaintEventHandler(this.p_main_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 592);
            this.Controls.Add(this.p_startScreen);
            this.Name = "Form1";
            this.Text = "game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.p_startScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_startScreen;
        private System.Windows.Forms.Panel p_main;
    }
}

