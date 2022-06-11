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
using System.IO; // Para el manejo de las fotos

namespace ProyVentas_GUI
{
    public partial class VendedorMan03 : Form
    {
        VendedorBE objVendedorBE = new VendedorBE();
        VendedorBL objVendedorBL = new VendedorBL();
        // Para controlar el cambio de foto 
        Boolean blnCambioFoto = false;
        
	public VendedorMan03()
        {
            InitializeComponent();
        }
        // Propiedad para identificar el codigo  del vendedor a actualizar
        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }

        private void VendedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique: Cargamos el combo con los supervisores
               

                // Codifique:Mostramos los datos del vendedor
                
                
                // Codifique:Quitamos el nombre de archivo por defecto del openfiledialog1
                

                // Codifique:Si existe un archivo con la foto la mostramos la foto ...
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnGrabar_Click(object sender, EventArgs e)
        {
           
            Single cantidadSupervisados = objVendedorBL.ContarSupervisados(objVendedorBE.Cod_ven);
            try
            {
                 // Codifique: Validamos la regla de negocio de actualizacion de vendedores supervisores.

                // Codifique: Agregar validaciones para nombres, apellidos, DNI , supervisor , sueldo y foto
                


                // Codifique: Cargamos los valores ingresados desde el formulario...
                
                // Codifique:Si se ha cambiado de foto se copia a la carpeta designada ...

                

                // Codifique: Actualizamos el vendedor.....

               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
          
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique: establecemos propiedades del openfiledialog
               

               // Codifique:Si eligio una foto e muestra la foto en el picturebox
                
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }
    }
}
