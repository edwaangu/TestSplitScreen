using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSplitScreen
{
    public partial class Form1 : Form
    {
        public static int _index = 0;
        public static bool[] Keys = new bool[256];
        public Form1()
        {
            InitializeComponent();
            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            _index++;
            GameScreen gs2 = new GameScreen();
            this.Controls.Add(gs2);
            gs2.Location = new Point(400, 0);
        }
    }
}
