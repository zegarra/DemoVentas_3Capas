using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Agregar...
using System.IO;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProveedorMan01 : Form
    {
       
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv; // Para el filtro por razon social
       
       
        public ProveedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv.RowFilter = "raz_soc_prv like '%" + strFiltro + "%'";
            dtgProveedor.DataSource = dtv;

            lblRegistros.Text = dtgProveedor.Rows.Count.ToString();
        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                //Para que no autigenere columnas
                dtgProveedor.AutoGenerateColumns = false; 

                // Definimos el dataview...
                dtv = objProveedorBL.ListarProveedor().DefaultView;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           try
            {
                //Codifique
                ProveedorMan02 obj02 = new ProveedorMan02();
                obj02.ShowDialog();

                // Refrescar...
                dtv = objProveedorBL.ListarProveedor().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
            try
            {
                //Codifique
                // Obtenemos el codigo del proveedor que se va actualizar....
                String strCod = dtgProveedor.CurrentRow.Cells[0].Value.ToString();

                ProveedorMan03 obj03 = new ProveedorMan03();
                obj03.Codigo = strCod;
                obj03.ShowDialog();

                // Refrescar...
                dtv = objProveedorBL.ListarProveedor().DefaultView;
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Codifique
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgProveedor_DoubleClick(object sender, EventArgs e)
        {
            //al hacer doble click en una fila se actualiza

            btnActualizar.PerformClick();
        }

        private void dtgProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
