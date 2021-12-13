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
    public partial class GameScreen : UserControl
    {
        int index;
        int timeElapsed = 0;

        public GameScreen()
        {
            InitializeComponent();
            index = Form1._index;

            if(index == 1)
            {
                this.BackColor = Color.Red;
            }
            if (index == 0)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            timeElapsed += 1 * (index + 1);
            timerText.Text = timeElapsed.ToString();

            if(index == 0)
            {
                pressingUp.Text = Form1.Keys[87].ToString();
            }
            if (index == 1)
            {
                pressingUp.Text = Form1.Keys[38].ToString();
            }

            Form theForm = this.FindForm();

            mouseLabel.Text = (MousePosition.X - theForm.Location.X - this.Location.X).ToString() + ", " + (MousePosition.Y - theForm.Location.Y - this.Location.Y).ToString();

            this.Refresh();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form1.Keys[e.KeyValue] = true;
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            Form1.Keys[e.KeyValue] = false;
        }
    }
}
