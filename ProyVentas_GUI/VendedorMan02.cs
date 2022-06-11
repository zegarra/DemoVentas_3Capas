using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyVentas_BE;
using ProyVentas_BL;
using System.IO;// Para el manejo de la copia de la foto del vendedor...

namespace ProyVentas_GUI
{
    public partial class VendedorMan02 : Form
    {
        VendedorBL  objVendedorBL = new VendedorBL();
        VendedorBE objVendedorBE = new VendedorBE();

        public VendedorMan02()
        {
            InitializeComponent();
        }

        private void VendedorMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique:Cargamos el combo con los supervisores
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private Image ObtenerImagen(String strRuta)
        {

            byte[] imagebuffer = File.ReadAllBytes(strRuta);
            using (MemoryStream ms = new MemoryStream(imagebuffer))
            {
                Image img = Image.FromStream(ms);
                ms.Close();
                return img;

            }


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique: establecemos propiedades del openfiledialog
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           try
            {

                // Codifique: Validamos que el nombre, apellido , foto DNI  y sueldo no esten vacios
                if (txtnom.Text.Length == 0)
                {
                    throw new Exception ("El Nombre no puede estar vacio.");
                }

                if (txtape.Text.Length == 0)
                {
                    throw new Exception ("El Apellido no puede estar vacio.");
                }

                if (mskSueldo.Text == "")
                {
                    throw new Exception ("Debe ingresar un sueldo valido.");

                }

                if (mskDNI.MaskFull  == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");

                }

                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe ingresar una foto.");

                }

                // Codifique: Si todo esta bien asignamos los datos del nuevo vendedor...
               

                // Codifique:Se copia la foto en la carpeta designada ...
                

		// Codifique:Insertamos el nuevo vendedor
                
            }
           catch ( Exception ex)
            {
           MessageBox .Show ("Se ha producido el error: " + ex.Message );
           }

         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
