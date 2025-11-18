using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAProyectoFinalROMS
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            FrmLogin frm0 = new FrmLogin();
            this.Hide();
            frm0.Show();
        }
    }
}
