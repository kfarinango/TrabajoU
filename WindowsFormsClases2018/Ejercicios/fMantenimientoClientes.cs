using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClases2018.Ejercicios
{
    public partial class fMantenimientoClientes : Form
    {
        string consulta = "Select * from  Customers";
        int index;
        Controles.Transacciones cargar = new Controles.Transacciones();
        public fMantenimientoClientes()
        {
            InitializeComponent();
        }

        private void fMantenimientoClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaDatos.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.vistaDatos.Customers);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Controles.Transacciones insSQL = new Controles.Transacciones();
            insSQL.insertarCliente(txtCodigo.Text, txtNombreCompania.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtDireccion.Text);
            cargar.cargarGridView(dataGridView1, consulta);
            cargar.limpiarTextbox(txtCodigo, txtNombreCompania, txtNombreContacto, txtCargoContacto, txtDireccion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("En realidad quiere eliminar al usuario " + this.dataGridView1.Rows[index].Cells[2].Value.ToString() + " " + this.dataGridView1.Rows[index].Cells[3].Value.ToString() + "", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Controles.Transacciones insSQL = new Controles.Transacciones();
                string IDUsuario = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                insSQL.eliminarCliente(IDUsuario);
                cargar.cargarGridView(dataGridView1, consulta);
                cargar.limpiarTextbox(txtCodigo, txtNombreCompania, txtNombreContacto, txtCargoContacto, txtDireccion);
            }
            else
            {
                MessageBox.Show("No se a realizado ningun cambio");
                cargar.limpiarTextbox(txtCodigo, txtNombreCompania, txtNombreContacto, txtCargoContacto, txtDireccion);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("En realidad quiere cambiar los datos del usuario " + this.dataGridView1.Rows[index].Cells[2].Value.ToString() + " " + this.dataGridView1.Rows[index].Cells[3].Value.ToString() + "", "Actualizar datos de usuario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Controles.Transacciones insSQL = new Controles.Transacciones();
                string IDUsuario = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                insSQL.actualizarCliente(IDUsuario, txtNombreCompania.Text, txtNombreContacto.Text, txtCargoContacto.Text, txtDireccion.Text);
                cargar.cargarGridView(dataGridView1, consulta);
                cargar.limpiarTextbox(txtCodigo, txtNombreCompania, txtNombreContacto, txtCargoContacto, txtDireccion);
            }
            else
            {
                MessageBox.Show("No se a realizado ningun cambio");
                cargar.limpiarTextbox(txtCodigo, txtNombreCompania, txtNombreContacto, txtCargoContacto, txtDireccion);
            }
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[index];
                txtCodigo.Text = row.Cells[0].Value.ToString();
                txtNombreCompania.Text = row.Cells[1].Value.ToString();
                txtNombreContacto.Text = row.Cells[2].Value.ToString();
                txtCargoContacto.Text = row.Cells[3].Value.ToString();
                txtDireccion.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
