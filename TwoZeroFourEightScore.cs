using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScore : Form ,View
    {
        public TwoZeroFourEightScore()
        {
            InitializeComponent();
        }
        public void Score(int s)
        {
            scorebox.Text = Convert.ToString(s);
        }
        public void Notify(Model m)
        {
            UpdateScore(((TwoZeroFourEightModel)m).GetScore());
        }
        private void UpdateScore(int score)
        {
            scorebox.Text = Convert.ToString(score);
        }
    }
}
