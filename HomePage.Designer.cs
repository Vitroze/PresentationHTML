using System.Windows.Forms;

namespace PresentationHTML
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.button_close = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.sTitle = new System.Windows.Forms.Label();
            this.DPanel_Main = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = global::PresentationHTML.Properties.Resources.button_close;
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(745, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(55, 54);
            this.button_close.TabIndex = 1;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            this.button_close.MouseLeave += new System.EventHandler(this.button_close_MouseExitHover);
            this.button_close.MouseHover += new System.EventHandler(this.button_close_MouseHover);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.BackgroundImage = global::PresentationHTML.Properties.Resources.button_next;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_next.FlatAppearance.BorderSize = 0;
            this.button_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Location = new System.Drawing.Point(585, 431);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(239, 57);
            this.button_next.TabIndex = 2;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            this.button_next.MouseLeave += new System.EventHandler(this.button_next_MouseExitHover);
            this.button_next.MouseHover += new System.EventHandler(this.button_next_MouseHover);
            // 
            // sTitle
            // 
            this.sTitle.AutoSize = true;
            this.sTitle.BackColor = System.Drawing.Color.Transparent;
            this.sTitle.Font = new System.Drawing.Font("Montserrat Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.sTitle.Location = new System.Drawing.Point(26, 13);
            this.sTitle.Name = "sTitle";
            this.sTitle.Size = new System.Drawing.Size(374, 51);
            this.sTitle.TabIndex = 3;
            this.sTitle.Text = "HTML TP - Etape 1";
            // 
            // DPanel_Main
            // 
            this.DPanel_Main.BackColor = System.Drawing.Color.Transparent;
            this.DPanel_Main.Location = new System.Drawing.Point(0, 105);
            this.DPanel_Main.Name = "DPanel_Main";
            this.DPanel_Main.Size = new System.Drawing.Size(836, 378);
            this.DPanel_Main.TabIndex = 4;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.BackgroundImage = global::PresentationHTML.Properties.Resources.button_back;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(503, 431);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(64, 57);
            this.button_back.TabIndex = 5;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Visible = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            this.button_back.MouseLeave += new System.EventHandler(this.button_back_MouseExitHover);
            this.button_back.MouseHover += new System.EventHandler(this.button_back_MouseHover);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PresentationHTML.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.DPanel_Main);
            this.Controls.Add(this.sTitle);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML TP - Etape 1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_close;
        private Button button_next;
        private Label sTitle;
        private Panel DPanel_Main;
        private Button button_back;
    }
}