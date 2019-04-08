using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerTest
{
    public partial class Form1 : Form
    {
        public int extractorCost = 10;
        public int clickerCost = 10;
        public static int Score = 10;
        public static List<ExtractorButton> Extractors;
        List<ClickerButton> clickers;

        public Form1()
        {
            InitializeComponent();

            Extractors = new List<ExtractorButton>();
            clickers = new List<ClickerButton>();

            timer.Tick += (a, e) =>
            {
                labelScore.Text = "Score: " + Score;
            };

            buttonBuyExtractor.Text = "Buy Extractor " + extractorCost;
            buttonBuyClicker.Text = "Buy Clicker " + clickerCost;

            buttonBuyClicker.Enabled = false;
        }

        private void buttonBuyExtractor_Click(object sender, EventArgs e)
        {
            buttonBuyClicker.Enabled = true;
            if (Score >= extractorCost)
            {
                ExtractorButton button = new ExtractorButton(timer);
                button.Location = new Point(buttonBuyExtractor.Location.X + 130 + 40 * (Extractors.Count % 15), 
                    buttonBuyExtractor.Location.Y + (Extractors.Count / 15) * 40);
                button.Size = new Size(40, 40);
                Extractors.Add(button);
                this.Controls.Add(button);

                Score -= extractorCost;
                extractorCost += extractorCost / 10;
                buttonBuyExtractor.Text = "Buy Extractor " + extractorCost;
            }
        }

        private void buttonBuyClicker_Click(object sender, EventArgs e)
        {
            if (Score >= clickerCost)
            {
                ClickerButton button = new ClickerButton(timer);
                button.Location = new Point(buttonBuyClicker.Location.X + 130 + 40 * (clickers.Count % 15),
                    buttonBuyClicker.Location.Y + (clickers.Count / 15) * 40);
                button.Size = new Size(40, 40);
                clickers.Add(button);
                this.Controls.Add(button);

                Score -= clickerCost;
                clickerCost += clickerCost / 10;
                buttonBuyClicker.Text = "Buy Clicker " + clickerCost;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            Score += 100;
        }
    }
}
