using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula71_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            IMC imc = new IMC();

            imc.Peso = peso;
            imc.Altura = altura;

            imc.ClassifImc();
        }

        private void txtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
