namespace MehNimationNav
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Suivant = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Suivant
            // 
            this.Suivant.AllowDrop = true;
            this.Suivant.Location = new System.Drawing.Point(399, 219);
            this.Suivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(100, 28);
            this.Suivant.TabIndex = 0;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(399, 255);
            this.Quitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(100, 28);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Suivant);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Quitter;
    }
}

