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
    public partial class TwoZeroFourEightScore : Form
    {
        public TwoZeroFourEightScore()
        {
            InitializeComponent();
        }
        public void Score(int s)
        {
            scorebox.Text = Convert.ToString(s);
        }
    }
}
