using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokobanana
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //Објекти од класите Level и Player
        public static Player player = new Player();
        public static Level level = new Level();

        //променливи за сликите со патека до нивната локација за исцртување на нивото
        public static string imageFloor = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\floor.png";
        public static string imageWall = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\wall.png";
        public static string imageMan = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\man.png";
        public static string imageBanana = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\banana.png";
        public static string imageGoal = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\goal.png";
        public static string imageNone = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\none.png";
        public static string imageBananaPlace = @"D:\Angela folder\Skolo\Cetvrti semestar\VIZUELNO PROGRAMIRANJE\Proektna zadadca\Sokobanana\Sokobanana\Images\bananaPlace.png";
        
        //големината на сликите е 24 пиксели
        //се множи за да нема преклопување меѓу сликите
        public static int imageSize = 24;
        
        //почетно ниво е 1
        public static int currlevel = 1;

        [STAThread]
        static void Main()
        {
            level.Load(currlevel);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
