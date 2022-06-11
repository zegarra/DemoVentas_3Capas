using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyVentas_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //mostramos el usuario logueado.
            this.lblUsuario.Text = "Usuario: " + clsCredenciales.Usuario;

            //manejamos 
            if(clsCredenciales.Nivel == 1)//Admin
            {
                mantenimientoToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)//usuariofina
            {
                mantenimientoToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = false;
                salirToolStripMenuItem.Visible = true;
            }

        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void proveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorMan01 objProveedor01 = new ProveedorMan01();
            objProveedor01.MdiParent = this;
            objProveedor01.Show();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendedorMan01 objVendedor02 = new VendedorMan01();
            objVendedor02.MdiParent = this;
            objVendedor02.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaMan01 oCategoria = new CategoriaMan01();
            oCategoria.MdiParent = this;
            oCategoria.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("¿sefuro de salir del sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //salimos de la aplicacion al cerrar el MDI
            Application.Exit();
        }
    }
}
