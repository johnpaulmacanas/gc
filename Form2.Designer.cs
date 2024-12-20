namespace GAMECHARACTER01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tanjirobutton = new System.Windows.Forms.Button();
            this.inosbutton = new System.Windows.Forms.Button();
            this.natbutton = new System.Windows.Forms.Button();
            this.garabutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tanjirobutton
            // 
            this.tanjirobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tanjirobutton.BackgroundImage")));
            this.tanjirobutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tanjirobutton.Location = new System.Drawing.Point(320, 226);
            this.tanjirobutton.Name = "tanjirobutton";
            this.tanjirobutton.Size = new System.Drawing.Size(132, 334);
            this.tanjirobutton.TabIndex = 1;
            this.tanjirobutton.UseVisualStyleBackColor = true;
            this.tanjirobutton.Click += new System.EventHandler(this.tanjirobutton_Click);
            // 
            // inosbutton
            // 
            this.inosbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inosbutton.BackgroundImage")));
            this.inosbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inosbutton.Location = new System.Drawing.Point(461, 184);
            this.inosbutton.Name = "inosbutton";
            this.inosbutton.Size = new System.Drawing.Size(132, 334);
            this.inosbutton.TabIndex = 2;
            this.inosbutton.UseVisualStyleBackColor = true;
            this.inosbutton.Click += new System.EventHandler(this.inosbutton_Click);
            // 
            // natbutton
            // 
            this.natbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("natbutton.BackgroundImage")));
            this.natbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.natbutton.Location = new System.Drawing.Point(602, 223);
            this.natbutton.Name = "natbutton";
            this.natbutton.Size = new System.Drawing.Size(132, 334);
            this.natbutton.TabIndex = 3;
            this.natbutton.UseVisualStyleBackColor = true;
            this.natbutton.Click += new System.EventHandler(this.natbutton_Click);
            // 
            // garabutton
            // 
            this.garabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("garabutton.BackgroundImage")));
            this.garabutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.garabutton.Location = new System.Drawing.Point(743, 184);
            this.garabutton.Name = "garabutton";
            this.garabutton.Size = new System.Drawing.Size(132, 334);
            this.garabutton.TabIndex = 4;
            this.garabutton.UseVisualStyleBackColor = true;
            this.garabutton.Click += new System.EventHandler(this.garabutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "SELECT CHARACTER";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAMECHARACTER01.Properties.Resources.download__12_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.garabutton);
            this.Controls.Add(this.natbutton);
            this.Controls.Add(this.inosbutton);
            this.Controls.Add(this.tanjirobutton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tanjirobutton;
        private System.Windows.Forms.Button inosbutton;
        private System.Windows.Forms.Button natbutton;
        private System.Windows.Forms.Button garabutton;
        private System.Windows.Forms.Label label1;
    }
}