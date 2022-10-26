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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Enabled = true;
            progressBarLoading.Increment(2);
            if(progressBarLoading.Value == 100)
            {
                timerLoading.Enabled = false;
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
        }
    }
}
