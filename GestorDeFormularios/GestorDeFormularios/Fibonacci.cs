using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeFormularios
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 0)
            {
                List<int> serie = new List<int> { 0 };
                int a = 0, b = 1;

                while (b <= limite)
                {
                    serie.Add(b);
                    int temp = a + b;
                    a = b;
                    b = temp;
                }

                txtResultado.Text = string.Join(",", serie);
            }

            else
            {
                MessageBox.Show("Ingrese un numero entero valido((≥ 0).)");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLimite.Clear();
            txtResultado.Clear();
        }
    }
}
