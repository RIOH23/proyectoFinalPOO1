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
    public partial class FrmLoteriaVisual : Form
    {
        public FrmLoteriaVisual()
        {
            InitializeComponent();
        }

        private void nivelBásicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJugar frmJBasico = new FrmJugar();
            this.Hide();
            frmJBasico.Show();
        }
    }
}
