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
    public partial class fAmortizacion : Form
    {
       Eventos.validar v = new Eventos.validar();
        public static double monto1 = 3000, monto2= 13300, monto3 = 60000;
        public static double plazo = 36, plazo2 = 60, plazo3 = 240;

        public fAmortizacion()
        {
            InitializeComponent();
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combotipo_KeyDown(object sender, KeyEventArgs e)
        {
           
                
        }

        private void txtmontoPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void txtInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
            
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int i;
            double monto, valorCuota, valorInteresAnual, valorInteresMensual, cuotaPago;
            int plazo;
            string tipo;
            double interes;
            monto = Convert.ToDouble(txtmontoPrestamo.Text);
            plazo = Convert.ToInt32(comboPlazo.SelectedItem.ToString());
            interes = Convert.ToDouble(txtInteres.Text);
            tipo = comboTipo.SelectedItem.ToString();
            valorInteresAnual = ((monto * interes) / 100);
            valorInteresMensual = (valorInteresAnual / plazo);
            valorCuota = (monto / plazo);

                for ( i = 0; i <= plazo; i++)
                {
                    cuotaPago = (valorCuota + valorInteresMensual);
                    string[] row0 = { Convert.ToString(valorCuota), Convert.ToString(valorInteresMensual), Convert.ToString(cuotaPago) };
                    gridPrestamoCalcular.Rows.Add(row0);
                }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fAmortizacion_Load(object sender, EventArgs e)
        {

        }

        
    }
}
