using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        int opportunities = 9;
        string h, v, d, d2, lastWinner;

        public frmTicTacToe()
        {
            InitializeComponent();
            rbtnX.Checked = true;
        }

        public void changeTurn(Button btn)
        {
            btn.Enabled = false;
            switch (rbtn0.Checked)
            {
                case true:
                    btn.Text = "0";
                    rbtnX.Checked = true;
                    break;
                case false:
                    btn.Text = "X";
                    rbtn0.Checked = true;
                    break;
            }
            opportunities--;
        }

        public void winGame(Button btn1, Button btn2, Button btn3)
        {
            lastWinner = btn1.Text;
            if (lastWinner == "X")
                lblGamesX.Text = (int.Parse(lblGamesX.Text) + 1).ToString(); 
            else
                lblGames0.Text = (int.Parse(lblGames0.Text) + 1).ToString();

            btn1.BackColor = Color.DarkSeaGreen;
            btn2.BackColor = Color.DarkSeaGreen;
            btn3.BackColor = Color.DarkSeaGreen;

            btn00.Enabled = false;
            btn01.Enabled = false;
            btn02.Enabled = false;
            btn10.Enabled = false;
            btn11.Enabled = false;
            btn12.Enabled = false;
            btn20.Enabled = false;
            btn21.Enabled = false;
            btn22.Enabled = false;
        }    

        public void validateOpportunities()
        {
            if (opportunities == 0)
                lblNotAnyWinner.Visible = true;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            changeTurn(btn00);
            
            h = btn00.Text + btn01.Text + btn02.Text;
            v = btn00.Text + btn10.Text + btn20.Text;
            d = btn00.Text + btn11.Text + btn22.Text;
            if (h == "XXX" || h == "000")
                winGame(btn00, btn01, btn02);
            else if (v == "XXX" || v == "000")
                winGame(btn00, btn10, btn20);
            else if (d == "XXX" || d == "000")
                winGame(btn00, btn11, btn22);
            else validateOpportunities();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            changeTurn(btn01);

            h = btn00.Text + btn01.Text + btn02.Text;
            v = btn01.Text + btn11.Text + btn21.Text;
            if (h == "XXX" || h == "000")
                winGame(btn00, btn01, btn02);
            else if (v == "XXX" || v == "000")
                winGame(btn01, btn11, btn21);
            else validateOpportunities();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            changeTurn(btn02);

            h = btn02.Text + btn01.Text + btn00.Text;
            v = btn02.Text + btn12.Text + btn22.Text;
            d = btn02.Text + btn11.Text + btn20.Text;
            if (h == "XXX" || h == "000")
                winGame(btn02, btn01, btn00);
            else if (v == "XXX" || v == "000")
                winGame(btn02, btn12, btn22);
            else if (d == "XXX" || d == "000")
                winGame(btn02, btn11, btn20);
            else validateOpportunities();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            changeTurn(btn10);

            h = btn10.Text + btn11.Text + btn12.Text;
            v = btn00.Text + btn10.Text + btn20.Text;
            if (h == "XXX" || h == "000")
                winGame(btn10, btn11, btn12);
            else if (v == "XXX" || v == "000")
                winGame(btn00, btn10, btn20);
            else validateOpportunities();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            changeTurn(btn11);

            h = btn10.Text + btn11.Text + btn12.Text;
            v = btn01.Text + btn11.Text + btn21.Text;
            d = btn00.Text + btn11.Text + btn22.Text;
            d2 = btn02.Text + btn11.Text + btn20.Text;
            if (h == "XXX" || h == "000")
                winGame(btn10, btn11, btn12);
            else if (v == "XXX" || v == "000")
                winGame(btn01, btn11, btn21);
            else if (d == "XXX" || d == "000")
                winGame(btn00, btn11, btn22);
            else if (d2 == "XXX" || d2 == "000")
                winGame(btn02, btn11, btn20);
            else validateOpportunities();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            changeTurn(btn12);

            h = btn10.Text + btn11.Text + btn12.Text;
            v = btn02.Text + btn12.Text + btn22.Text;
            if (h == "XXX" || h == "000")
                winGame(btn10, btn11, btn12);
            else if (v == "XXX" || v == "000")
                winGame(btn02, btn12, btn22);
            else validateOpportunities();
        }

        private void lblWhoPlay_Click(object sender, EventArgs e)
        {

        }

        private void btn20_Click(object sender, EventArgs e)
        {
            changeTurn(btn20);

            h = btn20.Text + btn21.Text + btn22.Text;
            v = btn00.Text + btn10.Text + btn20.Text;
            d = btn20.Text + btn11.Text + btn02.Text;
            if (h == "XXX" || h == "000")
                winGame(btn20, btn21, btn22);
            else if (v == "XXX" || v == "000")
                winGame(btn00, btn10, btn20);
            else if (d == "XXX" || d == "000")
                winGame(btn20, btn11, btn02);
            else validateOpportunities();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            changeTurn(btn21);

            h = btn20.Text + btn21.Text + btn22.Text;
            v = btn01.Text + btn11.Text + btn21.Text;
            if (h == "XXX" || h == "000")
                winGame(btn20, btn21, btn22);
            else if (v == "XXX" || v == "000")
                winGame(btn01, btn11, btn21);
            else validateOpportunities();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            changeTurn(btn22);

            h = btn20.Text + btn21.Text + btn22.Text;
            v = btn02.Text + btn12.Text + btn22.Text;
            d = btn00.Text + btn11.Text + btn22.Text;
            if (h == "XXX" || h == "000")
                winGame(btn20, btn21, btn22);
            else if (v == "XXX" || v == "000")
                winGame(btn02, btn12, btn22);
            else if (d == "XXX" || d == "000")
                winGame(btn00, btn11, btn22);
            else validateOpportunities();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            opportunities = 9;
            lblNotAnyWinner.Visible = false;

            btn00.Text = "";
            btn01.Text = "";
            btn02.Text = "";
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn00.Enabled = true;
            btn01.Enabled = true;
            btn02.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
            btn20.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;

            btn00.BackColor = Color.Empty;
            btn01.BackColor = Color.Empty;
            btn02.BackColor = Color.Empty;
            btn10.BackColor = Color.Empty;
            btn11.BackColor = Color.Empty;
            btn12.BackColor = Color.Empty;
            btn20.BackColor = Color.Empty;
            btn21.BackColor = Color.Empty;
            btn22.BackColor = Color.Empty;

            if (lastWinner == "X")
                rbtnX.Checked = true;
            else if (lastWinner == "0")
                rbtn0.Checked = true;
        }
    }
}
