
namespace Gestion_élèves
{
    partial class Agenda
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
            this.buttonAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgenda
            // 
            this.buttonAgenda.Location = new System.Drawing.Point(353, 196);
            this.buttonAgenda.Name = "buttonAgenda";
            this.buttonAgenda.Size = new System.Drawing.Size(75, 23);
            this.buttonAgenda.TabIndex = 0;
            this.buttonAgenda.Text = "Agenda";
            this.buttonAgenda.UseVisualStyleBackColor = true;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAgenda);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgenda;
    }
}