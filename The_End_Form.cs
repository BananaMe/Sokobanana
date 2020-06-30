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
    public partial class The_End_Form : Form
    {
        public The_End_Form()
        {
            InitializeComponent();
        }
        
        //Ок копчето
        private void button1_Click(object sender, EventArgs e)
        {
            Close();    //кликаш и се гаси прозорецот
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
