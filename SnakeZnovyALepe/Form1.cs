using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeZnovyALepe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameRestart();
        }

        private void GameTimeEvent_Tick(object sender, EventArgs e)
        {
           
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyUp(object sender, KeyEventArgs e)
        {

        }


        //vlastni funkce
        private void GameRestart()
        {

        }

        private void Move()
        {

        }

        private void EatFood()
        {

        }

        private void GameEnds()
        {
            btnStart.Enabled = true;
            //dodelat zbytek
        }

        
    }
}
