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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tx_divisao_Click(object sender, EventArgs e)
        {
            Divisao dv = new Divisao();//criar uma instancia
            dv.ShowDialog();//chamar e deixar visivel
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";

            if(radioButton1.Checked == true)
            {
                sexo = radioButton1.Text;
                MessageBox.Show(sexo);
            }
            else
            {
                sexo = radioButton2.Text;
                MessageBox.Show(sexo);
            }
        }
    }
}
