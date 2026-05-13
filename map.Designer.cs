namespace et_game
{
    partial class map
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
            this.p_map = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p_map
            // 
            this.p_map.Location = new System.Drawing.Point(-1, -1);
            this.p_map.Name = "p_map";
            this.p_map.Size = new System.Drawing.Size(828, 634);
            this.p_map.TabIndex = 0;
            this.p_map.Paint += new System.Windows.Forms.PaintEventHandler(this.p_map_Paint);
            this.p_map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_map_MouseClick);
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 632);
            this.Controls.Add(this.p_map);
            this.Name = "map";
            this.Text = "map";
            this.Load += new System.EventHandler(this.map_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_map;
    }
}