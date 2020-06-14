using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Email_Corporativo
{
    public partial class frmNomeEmail : Form
    {
        public frmNomeEmail()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txtNomeCompleto.Text;
            string[] nomes = nomeCompleto.Split(' ');
            string primeiroNome = nomes[0];
            string ultimoNome = nomes[nomes.Length - 1];

            lblRes_Nome.Text = $"{primeiroNome.ToUpper()} {ultimoNome.ToUpper()}";
            
            lblRes_Email1.Text = $"{primeiroNome.ToLower()}.{ultimoNome.ToLower()}@corporation.pt";

            lblRes_Email2.Text = $"{primeiroNome.ToLower()[0]}{ultimoNome.ToLower()}@corporation.pt";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = "";
            lblRes_Nome.Text = "";
            lblRes_Email1.Text = "";
            lblRes_Email2.Text = "";
        }
    }
}
