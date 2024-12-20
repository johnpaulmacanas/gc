using System;
using System.Windows.Forms;

namespace GAMECHARACTER01
{
    public partial class Form5 : Form
    {
        private Timer animationTimer; // Timer for controlling animations
        private int animationStep = 0; // Tracks the animation step sequence

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Initialize the timer
            animationTimer = new Timer();
            animationTimer.Interval = 1000; // 1 second interval
            animationTimer.Tick += AnimationTimer_Tick;

            // Load the initial images from resources
            LoadInitialImages();

            // Initial visibility - Use PictureBox names
            pictureBox3.Visible = true; // c2 idle image
            pictureBox4.Visible = false; // c2 attack image
            pictureBox2.Visible = true; // enemy idle image
            pictureBox1.Visible = false; // enemy hurt image
        }

        private void LoadInitialImages()
        {
            // Load the images from resources into PictureBox controls
            pictureBox3.Image = Properties.Resources.c2_idle; // Replace with actual resource name
            pictureBox4.Image = Properties.Resources.c2_atk; // Replace with actual resource name
            pictureBox2.Image = Properties.Resources.Fire_idle; // Replace with actual resource name
            pictureBox1.Image = Properties.Resources.Fire_dmg; // Replace with actual resource name
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start the attack animation
            animationStep = 0;
            pictureBox3.Visible = false; // Hide c2 idle
            pictureBox4.Visible = true; // Show c2 attack
            pictureBox2.Visible = false; // Hide enemy idle
            pictureBox1.Visible = true; // Show enemy hurt
            animationTimer.Start(); // Start the timer
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            animationStep++;

            if (animationStep == 1)
            {
                // After 1 second, reset the visibility
                pictureBox4.Visible = false; // Hide c2 attack
                pictureBox3.Visible = true; // Show c2 idle
                pictureBox2.Visible = false; // Hide enemy hurt
                pictureBox1.Visible = true; // Show enemy idle
                animationTimer.Stop(); // Stop the timer
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) //enemyattack
        {
            // Handle enemy attack if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle enemy hurt if needed
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Handle enemy idle if needed
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Handle c2 idle if needed
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Handle c2 attack if needed
        }
    }
}
