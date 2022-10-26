using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnAbrirFormConversorMoedas_Click(object sender, EventArgs e)
        {
            var form = new frmConversorMoeda();
            form.Show();
        }

        private void btnAbrirFormComissionamento_Click(object sender, EventArgs e)
        {
            var form = new frmComissionamento();
            form.Show();
        }

        private void conversosDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmConversorMoeda();
               form.MdiParent = this;
            form.Show();

        }
    }
}
