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

namespace WindowsFormsClases2018.Controles
{
    class Transacciones
    {

       
        
        public void insertarUsuario(string usrCedula, string usrapellidop, string usrapellidom, string usrnombre, string usrmail, string usridusuario, string usrClave, int perfil)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO USUARIO (usrcedula, usrapellidop, usrapellidom, usrnombrec, usrmail, usridusuario, usrClave, prfcodigoi) values ('" + @usrCedula + "', '" + @usrapellidop + "', '" + @usrapellidom + "', '" + @usrnombre + "', '" + @usrmail + "', '" + @usridusuario + "', '" + @usrClave + "', '" + @perfil + "')";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
        
                cmdact.Parameters.AddWithValue("@usrcedula", usrCedula);
                cmdact.Parameters.AddWithValue("@usrapellidop", usrapellidop);
                cmdact.Parameters.AddWithValue("@usrapellidom", usrapellidom);
                cmdact.Parameters.AddWithValue("@usrnombre", usrnombre);
                cmdact.Parameters.AddWithValue("@usrmail", usrmail);
                cmdact.Parameters.AddWithValue("@usridusuario", usridusuario);
                cmdact.Parameters.AddWithValue("@usrClave", usrClave);
                cmdact.Parameters.AddWithValue("@perfil", perfil);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void actualizarUsuario(int IDUsuario,string usrCedula, string usrapellidop, string usrapellidom, string usrnombre, string usrmail, string usridusuario, string usrClave, int perfil)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "Update USUARIO set usrcedula = '" + @usrCedula + "', usrapellidop =  '" + @usrapellidop + "', usrapellidom = '" + @usrapellidom + "', usrnombrec = '" + @usrnombre + "', usrmail = '" + @usrmail + "', usridusuario = '" + @usridusuario + "', usrClave = '" + @usrClave + "', prfcodigoi = '" + @perfil + "' where usrid = '" + @IDUsuario + "'";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;

                cmdact.Parameters.AddWithValue("@usrcedula", usrCedula);
                cmdact.Parameters.AddWithValue("@usrapellidop", usrapellidop);
                cmdact.Parameters.AddWithValue("@usrapellidom", usrapellidom);
                cmdact.Parameters.AddWithValue("@usrnombre", usrnombre);
                cmdact.Parameters.AddWithValue("@usrmail", usrmail);
                cmdact.Parameters.AddWithValue("@usridusuario", usridusuario);
                cmdact.Parameters.AddWithValue("@usrClave", usrClave);
                cmdact.Parameters.AddWithValue("@perfil", perfil);
                cmdact.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void eliminarUsuario(int IDUsuario)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "DELETE FROM USUARIO  where usrid = '" + @IDUsuario + "'";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;

                cmdact.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void cargarGridView(DataGridView dataGrid, string tabla)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ToString())) {
                 DataTable dt;
                SqlDataAdapter da = new SqlDataAdapter("SELECT Usuario.usrid, Usuario.usrcedula, Usuario.usrapellidop, Usuario.usrapellidom, Usuario.usrnombrec, Usuario.usrmail, Usuario.usridusuario, Usuario.usrclave, PERFILES_USUARIOS.PRFDESCRIPC FROM PERFILES_USUARIOS INNER JOIN  Usuario ON PERFILES_USUARIOS.PRFCODIGOI = Usuario.prfcodigoi", cn);
                dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;

            }

        }

        public void CargarComboBox(ComboBox comboBox)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ToString()))
            {
                SqlCommand cm = new SqlCommand("SELECT PRFDESCRIPC from PERFILES_USUARIOS", cn);
                SqlDataReader dr;
                cn.Open();
                dr = cm.ExecuteReader() ;
                while (dr.Read()) {
                    comboBox.Items.Add(dr["PRFDESCRIPC"].ToString());
                }
                comboBox.SelectedIndex = 0;
                dr.Close();
            }

        }
    }
    
}
