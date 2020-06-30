using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ИНФОРМАЦИИ ЗА НИВОТО
//Преведување на нивото, проверка дали е завршено нивото
namespace Sokobanana
{
    class Level
    {
        public static string[,] tiles;
        public static int bananas;
        public void Load(int num)  //ја преведува .txt датотеката во матрица
        {
            string[] lines;

            //try-catch exception кога num е поголем од 5 (бројот на нивоа во играта)
            try
            {
                lines = File.ReadAllLines(@"..\..\Levels\" + num + "_lvl.txt", Encoding.UTF8);
            }

            catch
            {
                bananas = -1;
                return;
            }

            bananas = 0;


            //променливи кои ќе се користат во for циклусот
            int height = lines.Length;
            int width = lines[0].Length;
            tiles = new string[height, width];  //матрица во која ќе биде сместено нивото

            for (int y = 0; y < height; ++y)
            {
                var line = lines[y];
                int x = 0;

                /*w - ѕид
                 B -  банана
                 . - под
                 S - почетно место на играчот
                 G - обележано место за бананите*/
                foreach (char c in line)
                {
                    if (c == 'W') tiles[y, x++] = "wall";
                    else if (c == 'B')
                    {
                        //означува банана што не е на место
                        //во Form1.Draw() се проверува дали е наместена или не за да биде соодветна слика поставено
                        tiles[y, x++] = "banana/floor";
                        //бројот на банани се користи за проверка колку се наместени во местата во complete функцијата
                        ++bananas;  
                    }
                    else if (c == '.') tiles[y, x++] = "floor";
                    else if (c == 'S')
                    {
                        tiles[y, x++] = "floor";
                        Program.player.X = x;
                        Program.player.Y = y;
                    }
                    else if (c == 'G') tiles[y, x++] = "goal";
                    else tiles[y, x++] = "none";
                }
            }
            
        }
        
        //функиција која проверува дали е завршено нивото (бананите да се на облежаните коцки)
        public static bool complete()
        {
            int completeBanana = 0;
            for (int y = 0; y < tiles.GetLength(0); ++y)
            {
                for (int x = 0; x < tiles.GetLength(1); ++x)
                {
                    if (tiles[y,x] == "banana/goal")
                    {
                        ++completeBanana;
                    }
                }
            }
            //ако се исти вредностите враќа true
            return completeBanana == bananas;
        }
    }
}