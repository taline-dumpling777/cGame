using System;
using System.Drawing;
using System.Windows.Forms;

namespace et_game
{
    public partial class Form1 : Form
    {

        Image StartScreen = Image.FromFile("startScreen/start_screen.jpeg");
        int PanelWidth, PanelHeight;

        Image btn_start = Image.FromFile("startScreen/start_button.jpeg");

        Image Main1 = Image.FromFile("main/main1.jpeg");

        bool play;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDimensions();
        }

        private void p_startScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(StartScreen, 0, 0, PanelWidth, PanelHeight);
            g.DrawImage(btn_start, PanelWidth / 2-25 , PanelHeight/2-10, 125, 50);
        }

        private void p_startScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Location.X > PanelWidth / 2 - 25 && e.Location.X < PanelWidth / 2 + 100 && e.Location.Y > PanelHeight / 2 - 10 && e.Location.Y < PanelHeight / 2 + 40)
            {
                play = true;
            }

            this.Invalidate(true);
        }

        private void p_main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Main1, 0, 0, PanelWidth, PanelHeight);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (play == false)
            {
                p_startScreen.Visible = true;
                p_main.Visible = false;
            }
            else if (play)
            {
                p_startScreen.Visible = false;
                p_main.Visible = true;
                g.DrawImage(Main1, 0, 0, PanelWidth, PanelHeight);
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show($"Click detected! Position: X={e.Location.X}, Y={e.Location.Y}");

            if (e.Location.X > 575 && e.Location.X < 688 && e.Location.Y > 10 && e.Location.Y < 130)
            {
                map map = new map();
                map.Show();
                this.Hide();
            }
        }

        public void setDimensions()
        {
            PanelHeight = this.Height - 40;
            PanelWidth = this.Width - 10;
            p_startScreen.Width = PanelWidth;
            p_startScreen.Height = PanelHeight;
            p_main.Width = PanelWidth;
            p_main.Height = PanelHeight;
        }
    }
}