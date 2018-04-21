using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturaDSNoite
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle;

            if (rdbCF.Checked)
            {
               controle = new Modelo.Controle("CF", txbTemperatura.Text);
            }
            else
            {
                controle = new Modelo.Controle("FC", txbTemperatura.Text);
            }
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resposta;
            }
            else 
            {
                MessageBox.Show(controle.mensagem);
            }
        }

    }
}

