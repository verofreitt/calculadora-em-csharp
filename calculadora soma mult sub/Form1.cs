using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_01___01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero1, Numero2, Soma, Multpilcacao, Subtracao;

            Numero1 = Convert.ToInt16(txtNumero1.Text);
            Numero2 = Convert.ToInt16(txtNumero2.Text);

            Soma = Numero1 + Numero2;

            lblSoma.Text = "SOMA: " + Convert.ToString(Soma);

            Numero1 = Convert.ToInt16(txtNumero1.Text);
            Numero2 = Convert.ToInt16(txtNumero2.Text);

            Subtracao = Numero1 - Numero2;

            lblSubtração.Text = "SUBTRAÇÃO: " + Convert.ToString(Subtracao);

            Numero1 = Convert.ToInt16(txtNumero1.Text);
            Numero2 = Convert.ToInt16(txtNumero2.Text);

            Multpilcacao = Numero1 * Numero2;

            lblMultiplicação.Text = "MULTIPLICAÇÃO: " + Convert.ToString(Multpilcacao);



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblSoma.Text = ("SOMA:");
            lblSubtração.Text = ("SUBTRAÇÃO:");
            lblMultiplicação.Text = ("MULTIPLICAÇÃO:");

        }
    }
}
