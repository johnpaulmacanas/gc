using System;
using System.Windows.Forms;
using System.Drawing;

namespace GAMECHARACTER01
{
    public partial class Form2 : Form
    {
        private Timer timer;
        private int buttonIndex = 0;
        private Button[] buttons;
        private int animationSpeed = 20;
        private int delayCounter = 0;
        private const int delayBetweenButtons = 10;
        private Point[] originalPositions;

        public Form2()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StartButtonAnimation();
        }

        private void InitializeAnimation()
        {
            buttons = new Button[] { tanjirobutton, inosbutton, natbutton, garabutton };
            originalPositions = new Point[buttons.Length];
            for (int i = 0; i < buttons.Length; i++)
            {
                originalPositions[i] = buttons[i].Location;
                buttons[i].Location = new Point(buttons[i].Location.X, -buttons[i].Height);
                buttons[i].Visible = false;
            }

            timer = new Timer { Interval = 10 };
            timer.Tick += Timer_Tick;
        }

        private void StartButtonAnimation()
        {
            buttonIndex = 0;
            delayCounter = 0;
            buttons[buttonIndex].Visible = true;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (buttonIndex >= buttons.Length)
            {
                timer.Stop();
                return;
            }

            Button currentButton = buttons[buttonIndex];
            int targetY = originalPositions[buttonIndex].Y;

            if (currentButton.Location.Y < targetY)
            {
                currentButton.Location = new Point(currentButton.Location.X, currentButton.Location.Y + animationSpeed);
            }
            else
            {
                delayCounter += timer.Interval;

                if (delayCounter >= delayBetweenButtons)
                {
                    buttonIndex++;
                    delayCounter = 0;

                    if (buttonIndex < buttons.Length)
                    {
                        buttons[buttonIndex].Visible = true;
                    }
                }
            }
        }

      
        private void tanjirobutton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void inosbutton_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void natbutton_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void garabutton_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
    }
}
