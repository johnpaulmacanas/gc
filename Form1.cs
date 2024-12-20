using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMECHARACTER01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set dimensions for button1
            button1.Width = 300;
            button1.Height =100;
            button1.Text = "PLAY";  // Set text for button1
            MakeButtonRoundedRectangle(button1, 20, Color.ForestGreen, Color.Black);  // Set green background and black border

            // Set dimensions for button2
            button2.Width = 300;
            button2.Height = 90;
            button2.Text = "EXIT";  // Set text for button2
            MakeButtonRoundedRectangle(button2, 20, Color.DarkRed, Color.Black);  // Set red background and black border
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle button1 click event
            
            Form2 form2 = new Form2();  // Instantiate Form2
            form2.Show();  // Show Form2
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Handle button2 click event
            MessageBox.Show("Button 2 clicked!");
        }

        private void MakeButtonRoundedRectangle(Button button, int cornerRadius, Color buttonColor, Color borderColor)
        {
            // Create a path for the rounded rectangle
            GraphicsPath path = new GraphicsPath();

            // Define the rounded rectangle path
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);  // Top-left corner
            path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);  // Top-right corner
            path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);  // Bottom-right corner
            path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);  // Bottom-left corner
            path.CloseFigure();

            // Set the button's region to the rounded rectangle
            button.Region = new Region(path);

            // Set the button's background color
            button.BackColor = buttonColor;
            // Set the text color to white
            button.ForeColor = Color.White;

            // Set the button's flat style and remove default border
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            // Handle the Paint event to draw custom borders
            button.Paint += (s, e) => DrawButtonBorder(s, e, cornerRadius, borderColor);
        }

        private void DrawButtonBorder(object sender, PaintEventArgs e, int cornerRadius, Color borderColor)
        {
            Button button = sender as Button;

            if (button != null)
            {
                // Create a pen to draw the border
                Pen borderPen = new Pen(borderColor, 3);  // Border color and thickness
                borderPen.Alignment = PenAlignment.Inset;

                // Define the rounded rectangle path for the border
                GraphicsPath borderPath = new GraphicsPath();
                borderPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);  // Top-left corner
                borderPath.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);  // Top-right corner
                borderPath.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);  // Bottom-right corner
                borderPath.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);  // Bottom-left corner
                borderPath.CloseFigure();

                // Draw the border around the button
                e.Graphics.DrawPath(borderPen, borderPath);
            }
        }
    }
}
