
namespace Gestion_élèves
{
    partial class GroupBoxLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupBoxLogin));
            this.button_SeConnecter = new System.Windows.Forms.Button();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIdentifiant = new System.Windows.Forms.PictureBox();
            this.pictureBoxMdp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMdpOublié = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentifiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdp)).BeginInit();
            this.SuspendLayout();
            // 
            // button_SeConnecter
            // 
            this.button_SeConnecter.Location = new System.Drawing.Point(268, 311);
            this.button_SeConnecter.Name = "button_SeConnecter";
            this.button_SeConnecter.Size = new System.Drawing.Size(280, 69);
            this.button_SeConnecter.TabIndex = 0;
            this.button_SeConnecter.Text = "Se connecter";
            this.button_SeConnecter.UseVisualStyleBackColor = true;
            this.button_SeConnecter.Click += new System.EventHandler(this.button_SeConnecter_Click);
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(84, 157);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(140, 20);
            this.textBoxMdp.TabIndex = 2;
            this.textBoxMdp.UseSystemPasswordChar = true;
            // 
            // textBoxIdentifiant
            // 
            this.textBoxIdentifiant.Location = new System.Drawing.Point(353, 182);
            this.textBoxIdentifiant.Name = "textBoxIdentifiant";
            this.textBoxIdentifiant.Size = new System.Drawing.Size(140, 20);
            this.textBoxIdentifiant.TabIndex = 3;
            this.textBoxIdentifiant.TextChanged += new System.EventHandler(this.textBoxIdentifiant_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.pictureBoxIdentifiant);
            this.groupBox1.Controls.Add(this.pictureBoxMdp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelMdpOublié);
            this.groupBox1.Controls.Add(this.textBoxMdp);
            this.groupBox1.Location = new System.Drawing.Point(269, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxIdentifiant
            // 
            this.pictureBoxIdentifiant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIdentifiant.Image")));
            this.pictureBoxIdentifiant.Location = new System.Drawing.Point(22, 103);
            this.pictureBoxIdentifiant.Name = "pictureBoxIdentifiant";
            this.pictureBoxIdentifiant.Size = new System.Drawing.Size(41, 32);
            this.pictureBoxIdentifiant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIdentifiant.TabIndex = 4;
            this.pictureBoxIdentifiant.TabStop = false;
            // 
            // pictureBoxMdp
            // 
            this.pictureBoxMdp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMdp.Image")));
            this.pictureBoxMdp.Location = new System.Drawing.Point(22, 150);
            this.pictureBoxMdp.Name = "pictureBoxMdp";
            this.pictureBoxMdp.Size = new System.Drawing.Size(41, 32);
            this.pictureBoxMdp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMdp.TabIndex = 3;
            this.pictureBoxMdp.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connexion élève :";
            // 
            // labelMdpOublié
            // 
            this.labelMdpOublié.AutoSize = true;
            this.labelMdpOublié.Location = new System.Drawing.Point(81, 205);
            this.labelMdpOublié.Name = "labelMdpOublié";
            this.labelMdpOublié.Size = new System.Drawing.Size(111, 13);
            this.labelMdpOublié.TabIndex = 0;
            this.labelMdpOublié.Text = "Mot de passe oublié ?";
            // 
            // GroupBoxLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SeConnecter);
            this.Controls.Add(this.textBoxIdentifiant);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupBoxLogin";
            this.Text = "geo uortçyu";
            this.Load += new System.EventHandler(this.GroupBoxLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentifiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SeConnecter;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMdpOublié;
        private System.Windows.Forms.PictureBox pictureBoxIdentifiant;
        private System.Windows.Forms.PictureBox pictureBoxMdp;
    }
}

