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
    public partial class Cálculo_de_Impuestos : Form
    {
        public Cálculo_de_Impuestos()
        {
            InitializeComponent();
        }

        private void Cálculo_de_Impuestos_Load(object sender, EventArgs e)
        {
            cmbImpuesto.Items.Add("ITBIS 18%");
            cmbImpuesto.Items.Add("Impuesto Selectivo 10%");
            cmbImpuesto.Items.Add("Impuesto Municipal 5%");
            cmbImpuesto.SelectedIndex = 0; // Selecciona el primer impuesto por defecto
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                double impuesto = 0;
                switch (cmbImpuesto.SelectedItem.ToString())
                {
                    case "ITBIS 18%":
                        impuesto = monto * 0.18;
                        break;
                    case "Impuesto Selectivo 10%":
                        impuesto = monto * 0.10;
                        break;
                    case "Impuesto Municipal 5%":
                        impuesto = monto * 0.05;
                        break;
                }
                double total = monto + impuesto;
                lblTotal.Text = $" {total:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        //limpiar los campos

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
            cmbImpuesto.SelectedIndex = -1;
            lblTotal.Text = "0.00";
        }
    }
}
