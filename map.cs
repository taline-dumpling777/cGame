using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace et_game
{
    public partial class map : Form
    {
        Image Map = Image.FromFile("map/mapbg.jpeg");
        int PanelWidth, PanelHeight;

        Image level1 = Image.FromFile("map/level1_icon.png");


        public map()
        {
            InitializeComponent();
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {
            setDimensions();
        }

        private void p_map_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Map, 0, 0, PanelWidth, PanelHeight);
            g.DrawImage(level1, 180, 400, 70, 50);
        }

        private void p_map_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show($"Click detected! Position: X={e.Location.X}, Y={e.Location.Y}");

            if (e.Location.X > 180 && e.Location.X < 260 && e.Location.Y > 400 && e.Location.Y < 440)
            {
                p_map.Visible = false;

                Level1 level1 = new Level1();
                level1.Show();
                this.Hide();
            }
            /*else if (e.Location.X > 10 && e.Location.X < 100 && e.Location.Y > 10 && e.Location.Y < 100)
             {
                level2 = true;
             }*/

            this.Invalidate(true);
        }

        public void setDimensions()
        {
            PanelHeight = this.Height - 40;
            PanelWidth = this.Width - 10;
        }
    }
}
