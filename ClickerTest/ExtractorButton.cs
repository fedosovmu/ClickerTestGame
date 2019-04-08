using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClickerTest
{
    public class ExtractorButton : Button
    {
        private const int miniScoreInScore = 15;
        private int miniScore = 0;
        public int Score = 0;

        public ExtractorButton (Timer timer) 
            : base ()
        {
            timer.Tick += (a, e) => Timer_tick();

            this.Click += (a, e) =>
            {
                ClickOn();
            };

            Redraw();
        }

        public void ClickOn ()
        {
            if (Score > 0)
            {
                miniScore -= miniScoreInScore;
                Form1.Score += 1;
                Redraw();
            }
        }

        private void Timer_tick()
        {
            if (miniScore < miniScoreInScore * 3)
            {
                miniScore += 1;
                Redraw();
            }
        }      

        private void Redraw()
        {
            Score = miniScore / miniScoreInScore;
            Text = Score.ToString();
            if (Score == 3) BackColor = Color.FromArgb(206, 81, 14);
            if (Score == 2) BackColor = Color.FromArgb(206, 138, 13);
            if (Score == 1) BackColor = Color.FromArgb(206, 198, 130);
            if (Score == 0) BackColor = Color.FromArgb(206, 206, 206);
        }
    }
}
