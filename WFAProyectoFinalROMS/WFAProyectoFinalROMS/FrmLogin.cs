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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmLoteriaVisual frm1 = new FrmLoteriaVisual();
            this.Hide();
            frm1.Show();
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario frm2 = new FrmRegistrarUsuario();
            this.Hide();
            frm2.Show();
        }
    }
}
