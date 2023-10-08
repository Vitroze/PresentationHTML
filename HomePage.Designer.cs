﻿using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.button_close = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.sTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sText = new System.Windows.Forms.Label();
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationHTML.Properties.Resources.code1;
            this.panel1.Location = new System.Drawing.Point(21, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 260);
            this.panel1.TabIndex = 4;
            // 
            // sText
            // 
            this.sText.AutoSize = true;
            this.sText.BackColor = System.Drawing.Color.Transparent;
            this.sText.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sText.Location = new System.Drawing.Point(410, 109);
            this.sText.Name = "sText";
            this.sText.Size = new System.Drawing.Size(424, 285);
            this.sText.TabIndex = 5;
            this.sText.Text = resources.GetString("sText.Text");
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PresentationHTML.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.sText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sTitle);
            this.Controls.Add(this.button_next);
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
        private Panel panel1;
        private Label sText;
    }
}