using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadoraIMC
{
    public partial class frmCalculadoraIMC : Form
    {

        

        public frmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                Double altura = Convert.ToDouble(txtAltura.Text.Replace(".", ","));
                Double peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));

                Double soma = peso / (altura * altura);


                if (soma < 16)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Baixo peso (Grau 1)");
                }
                else if (soma >= 16 && soma < 17)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Baixo peso (Grau 2)");
                }
                else if (soma >= 17 && soma < 18.50)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Baixo peso (Grau 3)");
                }
                else if (soma >= 18.50 && soma < 25)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Peso adequado");
                }
                else if (soma >= 25 && soma < 30)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Sobrepeso");
                }
                else if (soma >= 30 && soma < 35)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Obesidade (Grau 1)");
                }
                else if (soma >= 35 && soma < 40)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Obesidade (Grau 2)");
                }
                else if (soma >= 40)
                {
                    MessageBox.Show("IMC = " + soma.ToString("F") + " Obesidade (Grau 3)");
                }
            }
            catch(Exception)
            {          
                MessageBox.Show("Prencha os campos corretamente");
            }
        }
    }
}
