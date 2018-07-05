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
    public partial class fMantenimientoUsuario : Form
    {
        Controles.encriptacionAES en = new Controles.encriptacionAES();
        Controles.Transacciones cargar = new Controles.Transacciones();
        string consulta = "SELECT Usuario.usrid, Usuario.usrcedula, Usuario.usrapellidop, Usuario.usrapellidom, Usuario.usrnombrec, Usuario.usrmail, Usuario.usridusuario, Usuario.usrclave, PERFILES_USUARIOS.PRFDESCRIPC FROM PERFILES_USUARIOS INNER JOIN  Usuario ON PERFILES_USUARIOS.PRFCODIGOI = Usuario.prfcodigoi";
        int index;
        public fMantenimientoUsuario()
        {
            InitializeComponent();
            cargar.CargarComboBox(comboBoxPerfil);
        }
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaDatos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.vistaDatos.DataTable1);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
                DataGridViewRow row = this.dataGridView1.Rows[index];
                textCedula.Text = row.Cells[1].Value.ToString();
                textApelllidoPaterno.Text = row.Cells[2].Value.ToString();
                textApellidoMaterno.Text = row.Cells[3].Value.ToString();
                textNombres.Text = row.Cells[4].Value.ToString();
                textEMail.Text = row.Cells[5].Value.ToString();
                textIDUsuario.Text = row.Cells[6].Value.ToString();
                textPassword.Text = row.Cells[7].Value.ToString();

                if (row.Cells[8].Value.ToString() == "Usuario")
                    comboBoxPerfil.SelectedIndex = 0;
                else if (row.Cells[8].Value.ToString() == "Administrador")
                    comboBoxPerfil.SelectedIndex = 1;
                else if (row.Cells[8].Value.ToString() == "Editor")
                    comboBoxPerfil.SelectedIndex = 2;

            }

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Controles.Transacciones insSQL = new Controles.Transacciones();
            String pass = en.encriptacion(textPassword.Text);
            insSQL.insertarUsuario(textCedula.Text, textApelllidoPaterno.Text, textApellidoMaterno.Text, textNombres.Text, textEMail.Text, textIDUsuario.Text, pass, comboBoxPerfil.SelectedIndex+1);
            cargar.cargarGridView(dataGridView1, consulta);
            limpiarTXT();
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiarTXT() {
            textCedula.Text = "";
            textApelllidoPaterno.Text = "";
            textApellidoMaterno.Text = "";
            textNombres.Text = "";
            textEMail.Text = "";
            textIDUsuario.Text = "";
            textPassword.Text = "";
            comboBoxPerfil.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("En realidad quiere eliminar al usuario " + this.dataGridView1.Rows[index].Cells[2].Value.ToString() + " "+ this.dataGridView1.Rows[index].Cells[3].Value.ToString() + "", "Eliminar usuario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Controles.Transacciones insSQL = new Controles.Transacciones();
                String pass = en.encriptacion(textPassword.Text);
                int IDUsuario = int.Parse(this.dataGridView1.Rows[index].Cells[0].Value.ToString());
                insSQL.eliminarUsuario(IDUsuario);
                cargar.cargarGridView(dataGridView1, consulta);
                limpiarTXT();
            }
            else {
                MessageBox.Show("No se a realizado ningun cambio");
                limpiarTXT();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("En realidad quiere cambiar los datos del usuario " + this.dataGridView1.Rows[index].Cells[2].Value.ToString() + " " + this.dataGridView1.Rows[index].Cells[3].Value.ToString() + "", "Actualizar datos de usuario", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Controles.Transacciones insSQL = new Controles.Transacciones();
                String pass = en.encriptacion(textPassword.Text);
                int IDUsuario = int.Parse(this.dataGridView1.Rows[index].Cells[0].Value.ToString());
                insSQL.actualizarUsuario(IDUsuario, textCedula.Text, textApelllidoPaterno.Text, textApellidoMaterno.Text, textNombres.Text, textEMail.Text, textIDUsuario.Text, pass, comboBoxPerfil.SelectedIndex + 1);
                cargar.cargarGridView(dataGridView1, consulta);
                limpiarTXT();
            }
            else
            {
                MessageBox.Show("No se a realizado ningun cambio");
                limpiarTXT();
            }
        }
    }
}
