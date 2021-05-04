using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_élèves
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes pageNotes = new Notes();
            pageNotes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emploi_du_temps pageEmploi_Du_Temps = new Emploi_du_temps();
            pageEmploi_Du_Temps.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agenda pageAgenda = new Agenda();
            pageAgenda.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
