using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormProject
{
    public partial class frmTicTacToe : Form
    {
        bool player = false;
        private char O1 = 'O';
        private char O2 = 'X';

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player)
                btn8.Text = "O";
            else
                btn8.Text = "X";

            player = !player;
            checkit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player)
                btn7.Text = "O";
            else
                btn7.Text = "X";

            player = !player;
            checkit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player)
                btn9.Text = "O";
            else
                btn9.Text = "X";

            player = !player;
            checkit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player)
                btn3.Text = "O";
            else
                btn3.Text = "X";

            player = !player;
            checkit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (player)
                btn2.Text = "O";
            else
                btn2.Text = "X";

            player = !player;
            checkit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(player)
            btn1.Text = "O";
            else
               btn1.Text = "X";

            player = !player;
            checkit();

        }
        private void checkit()
        {

            if((btn1.Text == "O" && btn2.Text == "O"&& btn3.Text == "O")||
                (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")||
                (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")||
                (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")||
                (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")||
                (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")||
                (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")||
                (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
            {
                disabled();
                MessageBox.Show("Player 1 Wins","Result");

            }

            if ((btn1.Text == "X" && btn2.Text =="X" && btn3.Text == "X") ||
               (btn4.Text == "X" && btn5.Text == "X"&& btn6.Text == "X") ||
               (btn7.Text == "X" && btn8.Text == "X"&& btn9.Text == "X") ||
               (btn1.Text == "X" && btn4.Text == "X"&& btn7.Text == "X") ||
               (btn2.Text == "X" && btn5.Text == "X"&& btn8.Text == "X") ||
               (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")||
               (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")||
               (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
            {
                disabled();
                MessageBox.Show("Player 2 Wins", "Result");

            }
            if (Full())
            {
                disabled();
                MessageBox.Show("they Are Draw", "Result");
            }
            


        }
        bool Full()
        {
            if ((btn1.Text != "" && btn2.Text != "" && btn3.Text != "") &&
               (btn4.Text != "" && btn5.Text != "" && btn6.Text != "") &&
               (btn7.Text != "" && btn8.Text != "" && btn9.Text != "")){
                
                return true;
            }
            return false;
        }
        void disabled()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled
                = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = false;
        }
        void enabled()
        {
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled
                = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
        }
        void RestGame()
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text
                = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            enabled();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RestGame();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (player)
                btn4.Text = "O";
            else
                btn4.Text = "X";

            player = !player;
            checkit();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (player)
                btn5.Text = "O";
            else
                btn5.Text = "X";

            player = !player;
            checkit();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (player)
                btn6.Text = "O";
            else
                btn6.Text = "X";

            player = !player;
            checkit();
        }
    }
}
