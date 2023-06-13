using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudandoProva
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = ""; //ou string.Empty;//para não deixar o label aparecendo
        }

        private void tx_botao2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
          try
          {
                double a = Convert.ToDouble(tx_valor1.Text);
                double b = Convert.ToDouble(tx_valor2.Text);

                double c = a / b;
                lb_resultado.Text = c.ToString();
                //MessageBox.Show(c.ToString());//converter int para string//irá abrir uma caixinha
          }
            catch (Exception ex)
          {
             MessageBox.Show("Erro ao dividir!");
          }
           finally
            {
                MessageBox.Show("Tchau");
            }

        }

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
