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
            this.grpCreation = new System.Windows.Forms.GroupBox();
            this.txtValiderPort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNavireCree = new System.Windows.Forms.Label();
            this.btnCreerNavire = new System.Windows.Forms.Button();
            this.txtNomNavire = new System.Windows.Forms.TextBox();
            this.txtLibelleFret = new System.Windows.Forms.TextBox();
            this.txtQteFret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNoLloyds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoLloyds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnimation = new System.Windows.Forms.GroupBox();
            this.txtStockageCapa = new System.Windows.Forms.TextBox();
            this.grpCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCreation
            // 
            this.grpCreation.Controls.Add(this.txtStockageCapa);
            this.grpCreation.Controls.Add(this.txtValiderPort);
            this.grpCreation.Controls.Add(this.comboBox1);
            this.grpCreation.Controls.Add(this.label7);
            this.grpCreation.Controls.Add(this.label6);
            this.grpCreation.Controls.Add(this.label5);
            this.grpCreation.Controls.Add(this.lblNavireCree);
            this.grpCreation.Controls.Add(this.btnCreerNavire);
            this.grpCreation.Controls.Add(this.txtNomNavire);
            this.grpCreation.Controls.Add(this.txtLibelleFret);
            this.grpCreation.Controls.Add(this.txtQteFret);
            this.grpCreation.Controls.Add(this.label4);
            this.grpCreation.Controls.Add(this.lblNoLloyds);
            this.grpCreation.Controls.Add(this.label3);
            this.grpCreation.Controls.Add(this.label2);
            this.grpCreation.Controls.Add(this.txtNoLloyds);
            this.grpCreation.Controls.Add(this.label1);
            this.grpCreation.Location = new System.Drawing.Point(38, 12);
            this.grpCreation.Name = "grpCreation";
            this.grpCreation.Size = new System.Drawing.Size(1058, 161);
            this.grpCreation.TabIndex = 0;
            this.grpCreation.TabStop = false;
            this.grpCreation.Text = "Creation de Navire / Port";
            this.grpCreation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtValiderPort
            // 
            this.txtValiderPort.Location = new System.Drawing.Point(731, 110);
            this.txtValiderPort.Name = "txtValiderPort";
            this.txtValiderPort.Size = new System.Drawing.Size(126, 40);
            this.txtValiderPort.TabIndex = 16;
            this.txtValiderPort.Text = "Valider le Port";
            this.txtValiderPort.UseVisualStyleBackColor = true;
            this.txtValiderPort.Click += new System.EventHandler(this.txtValiderPort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(849, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Votre liste de stockage :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Créer un Stockage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Créer un Port :";
            // 
            // lblNavireCree
            // 
            this.lblNavireCree.AutoSize = true;
            this.lblNavireCree.Location = new System.Drawing.Point(427, 50);
            this.lblNavireCree.Name = "lblNavireCree";
            this.lblNavireCree.Size = new System.Drawing.Size(46, 17);
            this.lblNavireCree.TabIndex = 10;
            this.lblNavireCree.Text = "label5";
            this.lblNavireCree.Click += new System.EventHandler(this.lblNavireCree_Click);
            // 
            // btnCreerNavire
            // 
            this.btnCreerNavire.Location = new System.Drawing.Point(256, 46);
            this.btnCreerNavire.Name = "btnCreerNavire";
            this.btnCreerNavire.Size = new System.Drawing.Size(120, 93);
            this.btnCreerNavire.TabIndex = 9;
            this.btnCreerNavire.Text = "Créer un Navire";
            this.btnCreerNavire.UseVisualStyleBackColor = true;
            this.btnCreerNavire.Click += new System.EventHandler(this.btnCreerNavire_Click);
            // 
            // txtNomNavire
            // 
            this.txtNomNavire.Location = new System.Drawing.Point(128, 70);
            this.txtNomNavire.Name = "txtNomNavire";
            this.txtNomNavire.Size = new System.Drawing.Size(100, 22);
            this.txtNomNavire.TabIndex = 8;
            // 
            // txtLibelleFret
            // 
            this.txtLibelleFret.Location = new System.Drawing.Point(128, 95);
            this.txtLibelleFret.Name = "txtLibelleFret";
            this.txtLibelleFret.Size = new System.Drawing.Size(100, 22);
            this.txtLibelleFret.TabIndex = 7;
            // 
            // txtQteFret
            // 
            this.txtQteFret.Location = new System.Drawing.Point(128, 119);
            this.txtQteFret.Name = "txtQteFret";
            this.txtQteFret.Size = new System.Drawing.Size(100, 22);
            this.txtQteFret.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantité Fret :";
            // 
            // lblNoLloyds
            // 
            this.lblNoLloyds.AutoSize = true;
            this.lblNoLloyds.Location = new System.Drawing.Point(6, 51);
            this.lblNoLloyds.Name = "lblNoLloyds";
            this.lblNoLloyds.Size = new System.Drawing.Size(75, 17);
            this.lblNoLloyds.TabIndex = 4;
            this.lblNoLloyds.Text = "NoLloyds :";
            this.lblNoLloyds.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom du Navire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libelle Fret :";
            // 
            // txtNoLloyds
            // 
            this.txtNoLloyds.Location = new System.Drawing.Point(128, 46);
            this.txtNoLloyds.Name = "txtNoLloyds";
            this.txtNoLloyds.Size = new System.Drawing.Size(100, 22);
            this.txtNoLloyds.TabIndex = 1;
            this.txtNoLloyds.TextChanged += new System.EventHandler(this.txtNoLloyds_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer un Navire :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpAnimation
            // 
            this.grpAnimation.Location = new System.Drawing.Point(38, 219);
            this.grpAnimation.Name = "grpAnimation";
            this.grpAnimation.Size = new System.Drawing.Size(1058, 162);
            this.grpAnimation.TabIndex = 1;
            this.grpAnimation.TabStop = false;
            this.grpAnimation.Text = "Rendu :";
            this.grpAnimation.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtStockageCapa
            // 
            this.txtStockageCapa.Location = new System.Drawing.Point(824, 46);
            this.txtStockageCapa.Name = "txtStockageCapa";
            this.txtStockageCapa.Size = new System.Drawing.Size(100, 22);
            this.txtStockageCapa.TabIndex = 17;
            this.txtStockageCapa.TextChanged += new System.EventHandler(this.txtStockageCapa_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1130, 505);
            this.Controls.Add(this.grpAnimation);
            this.Controls.Add(this.grpCreation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCreation.ResumeLayout(false);
            this.grpCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreation;
        private System.Windows.Forms.GroupBox grpAnimation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoLloyds;
        private System.Windows.Forms.Label lblNoLloyds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNavireCree;
        private System.Windows.Forms.Button btnCreerNavire;
        private System.Windows.Forms.TextBox txtNomNavire;
        private System.Windows.Forms.TextBox txtLibelleFret;
        private System.Windows.Forms.TextBox txtQteFret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtValiderPort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtStockageCapa;
    }
}

