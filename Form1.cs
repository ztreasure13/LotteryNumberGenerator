using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtFloridaLotto1.Enabled = false;
            txtFloridaLotto2.Enabled = false;
            txtFloridaLotto3.Enabled = false;
            txtFloridaLotto4.Enabled = false;
            txtFloridaLotto5.Enabled = false;
            txtFloridaLotto6.Enabled = false;
            txtPowerBall1.Enabled = false;
            txtPowerBall2.Enabled = false;
            txtPowerBall3.Enabled = false;
            txtPowerBall4.Enabled = false;
            txtPowerBall5.Enabled = false;
            txtPowerBallBonus.Enabled = false;
            txtMega1.Enabled = false;
            txtMega2.Enabled = false;
            txtMega3.Enabled = false;
            txtMega4.Enabled = false;
            txtMega5.Enabled = false;
            txtMegaBonus.Enabled = false;
        }

        private void btnFloridaLotto_Click(object sender, EventArgs e)
        {
            int FloridaLottoNumber1 = 0;
            int FloridaLottoNumber2 = 0;
            int FloridaLottoNumber3 = 0;
            int FloridaLottoNumber4 = 0;
            int FloridaLottoNumber5 = 0;
            int FloridaLottoNumber6 = 0;
            while ( FloridaLottoNumber1 == FloridaLottoNumber2 || FloridaLottoNumber1 == FloridaLottoNumber3 ||
                    FloridaLottoNumber1 == FloridaLottoNumber4 || FloridaLottoNumber1 == FloridaLottoNumber5 ||
                    FloridaLottoNumber1 == FloridaLottoNumber6 || FloridaLottoNumber2 == FloridaLottoNumber3 ||
                    FloridaLottoNumber2 == FloridaLottoNumber4 || FloridaLottoNumber2 == FloridaLottoNumber5 ||
                    FloridaLottoNumber2 == FloridaLottoNumber6 || FloridaLottoNumber3 == FloridaLottoNumber4 ||
                    FloridaLottoNumber3 == FloridaLottoNumber5 || FloridaLottoNumber3 == FloridaLottoNumber6 ||
                    FloridaLottoNumber4 == FloridaLottoNumber5 || FloridaLottoNumber4 == FloridaLottoNumber6 )
            {
                Random rand = new Random();
                FloridaLottoNumber1 = rand.Next(1, 53);
                FloridaLottoNumber2 = rand.Next(1, 53);
                FloridaLottoNumber3 = rand.Next(1, 53);
                FloridaLottoNumber4 = rand.Next(1, 53);
                FloridaLottoNumber5 = rand.Next(1, 53);
                FloridaLottoNumber6 = rand.Next(1, 53);
            }
            txtFloridaLotto1.Text = FloridaLottoNumber1.ToString();
            txtFloridaLotto2.Text = FloridaLottoNumber2.ToString();
            txtFloridaLotto3.Text = FloridaLottoNumber3.ToString();
            txtFloridaLotto4.Text = FloridaLottoNumber4.ToString();
            txtFloridaLotto5.Text = FloridaLottoNumber5.ToString();
            txtFloridaLotto6.Text = FloridaLottoNumber6.ToString();
        }

        private void btnPowerBall_Click(object sender, EventArgs e)
        {
            int PowerBallNumber1 = 0;
            int PowerBallNumber2 = 0;
            int PowerBallNumber3 = 0;
            int PowerBallNumber4 = 0;
            int PowerBallNumber5 = 0;
            int PowerBallNumberBonus = 0;
            while ( PowerBallNumber1 == PowerBallNumber2 || PowerBallNumber1 == PowerBallNumber3 ||
                    PowerBallNumber1 == PowerBallNumber4 || PowerBallNumber1 == PowerBallNumber5 ||
                    PowerBallNumber2 == PowerBallNumber3 || PowerBallNumber2 == PowerBallNumber4 ||
                    PowerBallNumber2 == PowerBallNumber5 || PowerBallNumber3 == PowerBallNumber4 ||
                    PowerBallNumber3 == PowerBallNumber5 || PowerBallNumber4 == PowerBallNumber5 )
            {
                Random rand = new Random();
                PowerBallNumber1 = rand.Next(1, 69);
                PowerBallNumber2 = rand.Next(1, 69);
                PowerBallNumber3 = rand.Next(1, 69);
                PowerBallNumber4 = rand.Next(1, 69);
                PowerBallNumber5 = rand.Next(1, 69);
                PowerBallNumberBonus = rand.Next(1, 26);
            }
            txtPowerBall1.Text = PowerBallNumber1.ToString();
            txtPowerBall2.Text = PowerBallNumber2.ToString();
            txtPowerBall3.Text = PowerBallNumber3.ToString();
            txtPowerBall4.Text = PowerBallNumber4.ToString();
            txtPowerBall5.Text = PowerBallNumber5.ToString();
            txtPowerBallBonus.Text = PowerBallNumberBonus.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFloridaLotto1.Clear();
            txtFloridaLotto2.Clear();
            txtFloridaLotto3.Clear();
            txtFloridaLotto4.Clear();
            txtFloridaLotto5.Clear();
            txtFloridaLotto6.Clear();
            txtPowerBall1.Clear();
            txtPowerBall2.Clear();
            txtPowerBall3.Clear();
            txtPowerBall4.Clear();
            txtPowerBall5.Clear();
            txtPowerBallBonus.Clear();
            txtMega1.Clear();
            txtMega2.Clear();
            txtMega3.Clear();
            txtMega4.Clear();
            txtMega5.Clear();
            txtMegaBonus.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMega_Click(object sender, EventArgs e)
        {
            int MegaNumber1 = 0;
            int MegaNumber2 = 0;
            int MegaNumber3 = 0;
            int MegaNumber4 = 0;
            int MegaNumber5 = 0;
            int MegaNumberBonus = 0;
            while (MegaNumber1 == MegaNumber2 || MegaNumber1 == MegaNumber3 ||
                    MegaNumber1 == MegaNumber4 || MegaNumber1 == MegaNumber5 ||
                    MegaNumber2 == MegaNumber3 || MegaNumber2 == MegaNumber4 ||
                    MegaNumber2 == MegaNumber5 || MegaNumber3 == MegaNumber4 ||
                    MegaNumber3 == MegaNumber5 || MegaNumber4 == MegaNumber5)
            {
                Random rand = new Random();
                MegaNumber1 = rand.Next(1, 70);
                MegaNumber2 = rand.Next(1, 70);
                MegaNumber3 = rand.Next(1, 70);
                MegaNumber4 = rand.Next(1, 70);
                MegaNumber5 = rand.Next(1, 70);
                MegaNumberBonus = rand.Next(1, 25);
            }
            txtMega1.Text = MegaNumber1.ToString();
            txtMega2.Text = MegaNumber2.ToString();
            txtMega3.Text = MegaNumber3.ToString();
            txtMega4.Text = MegaNumber4.ToString();
            txtMega5.Text = MegaNumber5.ToString();
            txtMegaBonus.Text = MegaNumberBonus.ToString();
        }
    }
}
