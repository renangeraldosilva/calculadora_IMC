using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula71_IMC
{
    internal class IMC
    {
        public double Peso;
        public double Altura;

        public double CalcImc()
        {
            return Peso / (Altura * Altura);
        }

        public void ClassifImc()
        {
            if (CalcImc() < 18.5 )
            {
                MessageBox.Show("O Seu IMC é de: " + CalcImc().ToString("F2"));
                MessageBox.Show("Abaixo do recomendado", "Classificação IMC");
            }
            else if (CalcImc() < 24.9)
            {
                MessageBox.Show("O Seu IMC é de: " + CalcImc().ToString("F2"));
                MessageBox.Show("Peso normal", "Classificação IMC");
            }
            else if (CalcImc() < 29.9)
            {
                MessageBox.Show("O Seu IMC é de: " + CalcImc().ToString("F2"));
                MessageBox.Show("Sobrepeso", "Classificação IMC");
            }
            else if (CalcImc() < 39.9)
            {
                MessageBox.Show("O Seu IMC é de: " + CalcImc().ToString("F2"));
                MessageBox.Show("Obesidade", "Classificação IMC");
            }
            else
            {
                MessageBox.Show("O Seu IMC é de: " + CalcImc().ToString("F2"));
                MessageBox.Show("Obesidade severa", "Classificação IMC");
            }
        }
    }
}
