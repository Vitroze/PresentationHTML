namespace PresentationHTML.pages
{
    partial class Page1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            sText = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sText
            // 
            sText.AutoSize = true;
            sText.BackColor = Color.Transparent;
            sText.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            sText.ForeColor = Color.FromArgb(207, 232, 255);
            sText.Location = new Point(406, 1);
            sText.Name = "sText";
            sText.Size = new Size(426, 320);
            sText.TabIndex = 8;
            sText.Text = resources.GetString("sText.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.code1;
            pictureBox1.Location = new Point(21, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 260);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Page1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.background_panel;
            ClientSize = new Size(836, 379);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(sText);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Page1";
            ShowIcon = false;
            Text = "Page1";
            TransparencyKey = Color.White;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sText;
        private PictureBox pictureBox1;
    }
}