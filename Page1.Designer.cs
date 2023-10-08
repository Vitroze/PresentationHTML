namespace PresentationHTML
{
    partial class Page1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            this.sText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.sText.TabIndex = 7;
            this.sText.Text = resources.GetString("sText.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationHTML.Properties.Resources.code1;
            this.panel1.Location = new System.Drawing.Point(21, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 260);
            this.panel1.TabIndex = 6;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sText);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(836, 509);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sText;
        private Panel panel1;
    }
}
