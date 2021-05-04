
namespace Gestion_élèves
{
    partial class Emploi_du_temps
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
            this.buttonEmploiDuTemps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmploiDuTemps
            // 
            this.buttonEmploiDuTemps.Location = new System.Drawing.Point(350, 208);
            this.buttonEmploiDuTemps.Name = "buttonEmploiDuTemps";
            this.buttonEmploiDuTemps.Size = new System.Drawing.Size(101, 23);
            this.buttonEmploiDuTemps.TabIndex = 0;
            this.buttonEmploiDuTemps.Text = "Emploi du temps";
            this.buttonEmploiDuTemps.UseVisualStyleBackColor = true;
            // 
            // Emploi_du_temps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEmploiDuTemps);
            this.Name = "Emploi_du_temps";
            this.Text = "Emploi_du_temps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmploiDuTemps;
    }
}