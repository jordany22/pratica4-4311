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
    public partial class FrmRegistropersonas : Form
    {
        public FrmRegistropersonas()
        {
            InitializeComponent();
        }


        // Evento para agregar una nueva fila al DataGridView cuando se hace clic en el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add(
                txtNombre.Text, txtApellido.Text,
                txtCédula.Text, dtpFechaNacimiento.Value.ToShortDateString(),
                txtCorreo.Text, txtTeléfono.Text, txtDirección.Text, txtNivelEducativo.Text,
                txtOcupación.Text, cmbEstadoCivil.SelectedItem, cmbSexo.SelectedItem,
                txtNacionalidad.Text
                );
            // Limpiar los campos después de agregar la fila
            LimpiarCampos();

        }

        // Método para limpiar los campos de entrada

        private void LimpiarCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }


        private void FrmRegistropersonas_Load(object sender, EventArgs e)
        {
            //  12 columnas
            dgvPersonas.ColumnCount = 12;

            // Configurar los encabezados de las columnas
            dgvPersonas.Columns[0].Name = "Nombre";
            dgvPersonas.Columns[1].Name = "Apellido";
            dgvPersonas.Columns[2].Name = "Cédula";
            dgvPersonas.Columns[3].Name = "Fecha de Nacimiento";
            dgvPersonas.Columns[4].Name = "Correo Electrónico";
            dgvPersonas.Columns[5].Name = "Teléfono";
            dgvPersonas.Columns[6].Name = "Dirección";
            dgvPersonas.Columns[7].Name = "Nivel Educativo";
            dgvPersonas.Columns[8].Name = "Ocupación";
            dgvPersonas.Columns[9].Name = "Estado Civil";
            dgvPersonas.Columns[10].Name = "Sexo";
            dgvPersonas.Columns[11].Name = "Nacionalidad";



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        //limpiar los campos al hacer clic en el botón "Limpiar"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //eliminar la fila seleccionada al hacer clic en el botón "Eliminar"
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPersonas.Rows.RemoveAt(dgvPersonas.SelectedRows[0].Index);
            }

            catch
            {
                MessageBox.Show("Debe seleccionar una fila para eliminarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ordenar por nombre al hacer clic en el botón "Ordenar"

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            dgvPersonas.Sort(dgvPersonas.Columns[0], ListSortDirection.Ascending);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
