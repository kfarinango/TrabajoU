using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClases2018
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        Eventos.validar v = new Eventos.validar();
        public Login()
        {
            InitializeComponent();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand consulta = new SqlCommand("SELECT * FROM USUARIO WHERE USRIDUSUARIO='" + txtusuario.Text + "'AND USRCLAVE='" + txtcontraseña.Text + "'", cn);
            SqlDataReader ejecuta = consulta.ExecuteReader();
            if (ejecuta.Read() == true)
            {
                MessageBox.Show("Bienvenido");
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                txtcontraseña.Text = "";
                txtusuario.Text = "";
            }
            //if (ValidarTexto() == 1)
            //loginCorrecto();
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            DialogResult varresultado;
            try
            {
                varresultado = MessageBox.Show("¿Realmente desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (varresultado == DialogResult.Yes) {
                    Close();
                    Application.Exit();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        public  int ValidarTexto() {
            int respuesta;
            if ((txtcontraseña.Text.Trim() == "") & (txtusuario.Text.Trim() == ""))
            {
                MessageBox.Show("Campo de contraseña y usuario vacio");
                respuesta = 0;
            }
            else if (txtcontraseña.Text.Trim() == "")
            {
                MessageBox.Show("Campo de contraseña vacio");
                respuesta = 0;
            }
            else if (txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("Campo de usuario vacio");
                respuesta = 0;
            }
            else
                respuesta = 1;
            return respuesta;    
        }

        public void loginCorrecto() {

            string varusuario = "asus";
            string varclave = "12345";
                if ((txtusuario.Text == varusuario) & (txtcontraseña.Text == varclave))
                {
                    MessageBox.Show("Ingreso con exito");
                    MenuPrincipal menu = new MenuPrincipal(); //instanciar un objeto (menu) de la clase MenuPrincipal
                    this.Hide(); //que se oculte la clase activa
                    menu.Show(); //que se muestre el objeto menu de la clase MenuPrincipal
                }
                else
                {
                    if ((txtusuario.Text != varusuario)&(txtcontraseña.Text != varclave))
                    {
                        MessageBox.Show("Usuario y contraseña incorrecta");
                    }
                    else if (txtcontraseña.Text != varclave)
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                    else
                    {
                        MessageBox.Show("Usuario incorrecto");

                    }
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
