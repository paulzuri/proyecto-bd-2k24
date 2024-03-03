using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            gerente form = new gerente();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void frm_closing(object sender, FormClosingEventArgs e) {

            textBoxContrasenia.Text = "";
            textBoxDocumento.Text = "";
            this.Show();
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
