using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClickerTest
{
    class ClickerButton : Button
    {
        private const int ticksBetweenClicks = 10;
        private int tickNumber = 0;
        private Random random;

        public ClickerButton(Timer timer)
            : base()
        {
            timer.Tick += (a, e) => Timer_tick();
            random = new Random();
            this.Enabled = false;
        }


        private void Timer_tick()
        {
            tickNumber += 1;
            if (tickNumber % ticksBetweenClicks == 0)
            {
                int rand = random.Next(Form1.Extractors.Count());
                var extractor = Form1.Extractors[rand];
                int score = extractor.Score;
                if (score == 3) BackColor = Color.FromArgb(206, 81, 14);
                if (score == 2) BackColor = Color.FromArgb(206, 138, 13);
                if (score == 1) BackColor = Color.FromArgb(206, 198, 130);
                if (score == 0) BackColor = Color.FromArgb(131, 216, 247);
                extractor.ClickOn();
            }
            else
            {
                BackColor = Color.FromArgb(206, 206, 206);
            }
        }
    }
}
