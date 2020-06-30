using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokobanana
{
    public partial class Form1 : Form
    {
        private Graphics GFX;
        public Form1()
        {
            InitializeComponent();
            GFX = this.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Фунцкија за исцртување на нивото
        private void Draw ()
        {
            //ја зима матрицата од класата Levels и става соодветна слика
            //променливите се сместени во класата Program
            for (int y = 0; y < Level.tiles.GetLength(0); ++y)
            {
                for (int x = 0; x < Level.tiles.GetLength(1); ++x)
                {
                    if (Level.tiles[y, x].Equals("wall"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageWall), new Point(y * Program.imageSize, x * Program.imageSize));
                        //new Point: се множи вредноста на променливите х и у со големината на сликите за да не се преклопуваат
                    }
                    else if (Level.tiles[y, x].Equals("floor"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageFloor), new Point(y * Program.imageSize, x * Program.imageSize));
                    }
                    else if (Level.tiles[y, x].Equals("goal"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageGoal), new Point(y * Program.imageSize, x * Program.imageSize));

                    }
                    //банана кутијата се наоѓа на под т.е. необележано место
                    else if (Level.tiles[y, x].Equals("banana/floor"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageBanana), new Point(y * Program.imageSize, x * Program.imageSize));
                    }
                    else if (Level.tiles[y, x].Equals("none"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageNone), new Point(y * Program.imageSize, x * Program.imageSize));
                    }
                    //банана кутијата се наоѓа на целта т.е. облежано место
                    else if (Level.tiles[y, x].Equals("banana/goal"))
                    {
                        GFX.DrawImage(Bitmap.FromFile(Program.imageBananaPlace), new Point(y * Program.imageSize, x * Program.imageSize));
                    }
                }
            }
            //се црта играчот
            GFX.DrawImage(Bitmap.FromFile(Program.imageMan), new Point(Program.player.Y * Program.imageSize, Program.player.X * Program.imageSize));


        }
        private void button1_Click(object sender, EventArgs e)
        {

            base.OnClick(e);    //кликање на копчето Play
            //за да се менува големината на прозорецот
            //this.Height = Level.tiles.GetLength(1) * Program.imageSize + (Program.imageSize * 3) / 2;
            //this.Width = Level.tiles.GetLength(0) * Program.imageSize + (Program.imageSize / 2);
            Play_button.Visible = !Play_button.Visible;
            Title.Visible = !Title.Visible;
            Description_text.Visible = !Description_text.Visible;
            //повикување на Draw функцијата за да се изврши по кликање 
            Draw();
        }
        void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            int a = Program.player.Input(e.KeyCode);
            if(a == 1)
            {
                if (Level.complete())
                {
                    Program.level.Load(++Program.currlevel);

                    //Исклучокот од Level се реализира овде
                    if(Level.bananas == -1)
                    {
                        //се креира нов објект од класата The_End_Form
                        The_End_Form end = new The_End_Form();
                        //веќе отворениот прозорец (Form1) веќе не е видлив
                        this.Visible = !this.Visible;
                        //да се прикаже end прозорецот
                        end.Show();
                        
                    }
                    //за да се менува големината на прозорецот
                    //this.Height = Level.tiles.GetLength(1) * Program.imageSize + (Program.imageSize * 3) / 2;
                    //this.Width = Level.tiles.GetLength(0) * Program.imageSize + (Program.imageSize * 3) / 2;

                }

            }
            //ако се врати вредност -1 од Input фунцкијата (кога ќе стисне играчот R) се исцртува нивото од почеток
            else if (a == -1)
            {
                Program.level.Load(Program.currlevel);
            }

            Draw();          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
        }
    }
}
