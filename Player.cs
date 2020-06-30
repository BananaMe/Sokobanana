using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

//ИНГОРМАЦИИ ЗА ИГРАЧОТ
//Променливи  за позиција (х и у координати), броење на туркање (кутии) и чекори
namespace Sokobanana
{
    class Player
    {
        public int X;       //променлива за позицијата на играчот на х-оската
        public int Y;       //променлива за позицијата на играчот на у-оската
        int P_Moves = 0;    //број на чекори направени од играчот (се зголемува како што се движи)
        int P_Push = 0;     //број на туркања на кутиите со бананите направени од играчот (се зголемува како што турка)


        //ФУНКЦИЈА ЗА ДВИЖЕЊЕ НА ИГРАЧОТ
        //се движи коцка по коцка
        //проеврува дали ќе удри во ѕид
        public int Input(Keys k)
        {
            bool pushed = false;

            //Движење надесно
            if (k == Keys.Right && Level.tiles[this.Y + 1, this.X] != "wall") //проверка за кога се движи да не биде во ѕид
            {
                bool move = true;
                if (Level.tiles[this.Y + 1, this.X].StartsWith("banana")) 
                {
                    if (Level.tiles[this.Y + 2, this.X] == "floor" || Level.tiles[this.Y + 2, this.X] == "goal")
                    {
                        //го зима вториот елемент во стрингот (goal или floor)
                        var banana = Level.tiles[this.Y + 1, this.X].Split('/')[1];
                        Level.tiles[this.Y + 2, this.X] = "banana/" + Level.tiles[this.Y + 2, this.X];
                        Level.tiles[this.Y + 1, this.X] = banana;
                        pushed = true;
                        ++this.P_Push;  //се зголемува бројот на туркања за едно
                    }
                    else move = false;
                }
                if (move)
                {
                    ++this.Y;   //се менува позицијата на у-оска
                    ++this.P_Moves; //се зголемува бројот на чекори за едно
                }
            }

            //Движење налево
            else if (k == Keys.Left && Level.tiles[this.Y - 1, this.X] != "wall")
            {
                bool move = true;
                if (Level.tiles[this.Y - 1, this.X].StartsWith("banana"))
                {
                    if (Level.tiles[this.Y - 2, this.X] == "floor" || Level.tiles[this.Y - 2, this.X] == "goal")
                    {
                        var banana = Level.tiles[this.Y - 1, this.X].Split('/')[1];
                        Level.tiles[this.Y - 2, this.X] = "banana/" + Level.tiles[this.Y - 2, this.X];
                        Level.tiles[this.Y - 1, this.X] = banana;
                        pushed = true;
                        ++this.P_Push;
                    }
                    else move = false;
                }
                if (move)
                {
                    --this.Y;
                    ++this.P_Moves;
                }
            }
            //Движење надоле
            else if (k == Keys.Down && Level.tiles[this.Y, this.X + 1] != "wall")
            {
                bool move = true;
                if (Level.tiles[this.Y, this.X + 1].StartsWith("banana"))
                {
                    if (Level.tiles[this.Y, this.X + 2] == "floor" || Level.tiles[this.Y, this.X + 2] == "goal")
                    {
                        var banana = Level.tiles[this.Y, this.X + 1].Split('/')[1];
                        Level.tiles[this.Y, this.X + 2] = "banana/" + Level.tiles[this.Y, this.X + 2];
                        Level.tiles[this.Y, this.X + 1] = banana;
                        pushed = true;
                        ++this.P_Push;
                    }
                    else move = false;
                }
                if (move)
                {
                    ++this.X;
                    ++this.P_Moves;
                }
            }
            //Движење нагоре
            else if (k == Keys.Up && Level.tiles[this.Y, this.X - 1] != "wall")
            {
                bool move = true;
                if (Level.tiles[this.Y, this.X - 1].StartsWith("banana"))
                {

                    if (Level.tiles[this.Y, this.X - 2] == "floor" || Level.tiles[this.Y, this.X - 2] == "goal")
                    {
                        var banana = Level.tiles[this.Y, this.X - 1].Split('/')[1];
                        Level.tiles[this.Y, this.X - 2] = "banana/" + Level.tiles[this.Y, this.X - 2];
                        Level.tiles[this.Y, this.X - 1] = banana;
                        pushed = true;
                        ++this.P_Push;
                    }
                    else move = false;
                }
                if (move)
                {
                    --this.X;
                    ++this.P_Moves;
                }
            }

            //Кога ќе притисне на R да врати вредност од -1
            else if (k == Keys.R)
                return -1;
            return Convert.ToInt32(pushed);
        }
    }
}
