using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace et_game
{
    public struct Celest
    {
      public int x, y, width, height;
      public Image image;
      public int imageIndex; 
      public int size;
      public char status;
    }

    public struct chatbubble
    {
        public int x, y, width, height;
        public Image image;
        public string message;
        public bool visible;
    }

    public struct Xander
    {
        public int x, y, width, height;
        public Image image;
        public int imageIndex;
        public int size;
        public char status;
    }

    public partial class Level1 : Form
    {

        chatbubble ChatBubble = new chatbubble();
        Celest Celest = new Celest();
        Xander Xander = new Xander();

        Image chatBubble = Image.FromFile("chatBubble.png");

        Image xanderStandingBack = Image.FromFile("xanderStanding/xanderBack.png");

        Image celestStanding = Image.FromFile("celest_idle/C_idle1.png");

        Image[] celestIdle =
            { Image.FromFile("celest_idle/C_idle1.png"),
              Image.FromFile("celest_idle/C_idle2.png"),
        };

        Image[] CelestMovingRight =
        {
            Image.FromFile("celest_walk_R/C_walk1.png"),
            Image.FromFile("celest_walk_R/C_walk2.png"),
            Image.FromFile("celest_walk_R/C_walk3.png"),
            Image.FromFile("celest_walk_R/C_walk4.png"),
            Image.FromFile("celest_walk_R/C_walk5.png"),
            Image.FromFile("celest_walk_R/C_walk6.png"),
         };
        Image[] CelestMovingLeft =
           {
            Image.FromFile("celest_walk_L/C_walk1L.png"),
            Image.FromFile("celest_walk_L/C_walk2L.png"),
            Image.FromFile("celest_walk_L/C_walk3L.png"),
            Image.FromFile("celest_walk_L/C_walk4L.png"),
            Image.FromFile("celest_walk_L/C_walk5L.png"),
            Image.FromFile("celest_walk_L/C_walk6L.png"),
         };

        Image[] XanderMovingRight =
       {
            Image.FromFile("xander_walk_R/x_walk1.png"),
            Image.FromFile("xander_walk_R/x_walk2.png"),
            Image.FromFile("xander_walk_R/x_walk3.png"),
            Image.FromFile("xander_walk_R/x_walk4.png"),
            Image.FromFile("xander_walk_R/x_walk5.png"),
            Image.FromFile("xander_walk_R/x_walk6.png"),
        };

        int imgIndexXander = 0;
        int imgIndex = 0;
        int idleIndex = 0;
        int chatTime = 0;
        int PanelWidth = 698, PanelHeight = 480;
        bool part = false;
        bool chat = false;
        Image bg = Image.FromFile("level1_pics/bg_xandermeet.jpeg");

        Image Celestimg = Image.FromFile("celest_idle/C_idle1.png");

        public Level1()
        {
            InitializeComponent();
            Celest.x = 150;
            Celest.y = 270;
            Celest.width = (int)(PanelWidth * 0.07);
            Celest.height = (int)(Celest.width * 8.0 / 6.0);
            Celest.size = 1;
            Celest.status = 's';
            Celest.image = celestStanding;

            Xander.x = 550;
            Xander.y = 275;
            Xander.width = (int)(PanelWidth * 0.07 - 5);
            Xander.height = (int)(Xander.width * 8.0 / 6.0);
            Xander.size = 1;
            Xander.status = 's';
            Xander.image = xanderStandingBack;


            ChatBubble.visible = false;
        }

        private void p_L1xandermeet_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bg, 0, 0, PanelWidth, PanelHeight);
            g.DrawImage(Celest.image, Celest.x, Celest.y, Celest.width, Celest.height);
            g.DrawImage(Xander.image, Xander.x, Xander.y, Xander.width, Xander.height);

            if (ChatBubble.visible)
            {
                g.DrawImage(chatBubble, Celest.x + Celest.width + 20, Celest.y - 50, 150, 100);
                g.DrawString("Are you Xander?", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, Celest.x + Celest.width + 35, Celest.y - 10);
            }
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            setDimensions();
        }

        private void t_celestWalk_Tick(object sender, EventArgs e)
        {
            if (Celest.status == 'r')
            {
                Celest.x += 5;
                imgIndex = (imgIndex + 1) % 3;
                Celest.image = CelestMovingRight[imgIndex];
            }
            else if (Celest.status == 'l')
            {
                Celest.x -= 5;
                imgIndex = (imgIndex + 1) % 6;
                Celest.image = CelestMovingLeft[imgIndex];
            }

            if (Celest.x < 0)
                Celest.x = 0;
            else if (Celest.x + Celest.width > PanelWidth)
                part = true;

            if (Xander.x >= Celest.x && Xander.x <= Celest.width + Celest.x
                && Xander.y >= Celest.y && Xander.y <= Celest.height + Celest.y)
            {
                t_celestIdle.Enabled = false;

                chat = true;
                t_celestWalk.Enabled = false;
                t_chat.Enabled = true;
                ChatBubble.visible = true;
                Celest.status = 's';

            }

            this.Invalidate(true);
        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (chat == false)
            {
                t_celestWalk.Enabled = true;
                if (e.KeyCode.ToString() == "Right")
                    Celest.status = 'r';
                else if (e.KeyCode.ToString() == "Left")
                    Celest.status = 'l';
            }
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Right" || e.KeyCode.ToString() == "Left")
            {
                Celest.status = 's';
                t_celestIdle.Enabled = true;
                /* 
                 t_celestWalk.Enabled = false;*/
            }
        }

        private void t_celestIdle_Tick(object sender, EventArgs e)
        {
            if (Celest.status == 's')
            {
                idleIndex = (idleIndex + 1) % 2;
                Celest.image = celestIdle[idleIndex];
            }
        }

        private void t_chat_Tick(object sender, EventArgs e)
        {
            chatTime++;
            if (chatTime == 5)
                ChatBubble.visible = false;

            if (chatTime == 10)
            {
                Xander.status = 'r';
                t_xanderWalk.Enabled = true;
                chat = false;
            }
            this.Invalidate(true);
        }

        private void t_xanderWalk_Tick(object sender, EventArgs e)
        {

            if (Xander.status == 'r')
            {
                Xander.x += 5;
                imgIndexXander = (imgIndexXander + 1) % 6;
                Xander.image = XanderMovingRight[imgIndexXander];
            }
            this.Invalidate(true);
        }

        private void Level1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (part)
            {
                p_L1xandermeet.Visible = false;
                p_L1part2.Visible = true;
            }
            else
            {
                p_L1xandermeet.Visible = true;
                p_L1part2.Visible = false;
            }
        }

        public void setDimensions()
        {
            PanelHeight = this.Height - 40;
            PanelWidth = this.Width - 10;
            p_L1xandermeet.Width = PanelWidth;
            p_L1xandermeet.Height = PanelHeight;
        }
    }
}
