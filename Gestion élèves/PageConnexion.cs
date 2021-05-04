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
    public partial class GroupBoxLogin : Form
    {
        public GroupBoxLogin()
        {
            InitializeComponent();
        }

        private void button_SeConnecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil pageAccueil = new Accueil();
            pageAccueil.ShowDialog();
        }

        private void GroupBoxLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}