using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class FormEstudo : Form
    {
        public FormEstudo()
        {
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bom dia!" +" "+ txtBoxNome.Text, "Título", MessageBoxButtons.YesNo,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
        }

        private void btnDataHora_Click(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            MessageBox.Show("Data atual: " + dataHora.ToString());
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            var nota = 7.5f;
            MessageBox.Show("Nota: " + nota.ToString());

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            float area;
            var altura = float.Parse(txtBoxAltura.Text);
            var baseT = float.Parse(txtBoxBase.Text);

            area = baseT * altura;

            MessageBox.Show("Área do Triângulo: " + area.ToString());

        }

        private void btnCalcValor_Click(object sender, EventArgs e)
        {
            float total;
            var valor = float.Parse(txtBoxValor.Text);
            var qtde = int.Parse(txtBoxQtde.Text);

            total = valor * qtde;

            lblTotal.Text = total.ToString("C2");
        }
    }
}
