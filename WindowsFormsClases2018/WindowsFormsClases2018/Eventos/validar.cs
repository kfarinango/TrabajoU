using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClases2018.Eventos
{
    class validar
    {
        public void soloNumeros(KeyPressEventArgs e) {
           
                //permita el ingreso contraseña (flase = si true = no)
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Permitra borrar en caso de que ingrese mal la contraseña
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Permita el ingrerso de espacio
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                //el resto
                else
                    e.Handled = true;
           
        }
        public void soloLetras(KeyPressEventArgs e) {
           
                //permita el ingreso contraseña (flase = si true = no)
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Permitra borrar en caso de que ingrese mal la contraseña
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                //Permita el ingrerso de espacio
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                //el resto
                else
                    e.Handled = true;
            
           
        }
        

    }
}
