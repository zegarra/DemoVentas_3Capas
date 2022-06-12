using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Para la creacion
using OfficeOpenXml; //para el manejo de EpPlus
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class frmListasProveedor : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();

        public frmListasProveedor()
        {
            InitializeComponent();
        }
        private void MostrarControles(Boolean valor)
        {
            pcbImagen.Visible = valor;
            prgBar.Visible =valor;
            lblMensaje.Visible = valor;
        }
        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                //definimos la ruta de la plantilla(asegurate de que la ruta exista)
                string rutaArchivo = @"D:\Carpetas_Software\DesarrolloApliEm (LEON)\MisExcel\ListadoProveedores.xlsx";

                //Obtener el DataTable de proveedores....
                DataTable dtProveedores = new DataTable();
                dtProveedores = objProveedorBL.ListarProveedor();

                //definimos la fila de inicio del reporte..
                Int16 fila1 = 5;

                //creamos el reporte con una instancia ExcelPackage en base al archivo plantilla...
                using (var pck = new ExcelPackage(new FileInfo(rutaArchivo)))
                {
                    //Creamos una instancia de la Hoja1 del libro....
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Hoja1"];

                    //recorremos la coleccion de filas del dtProveedores...
                    foreach(DataRow drProveedor in dtProveedores.Rows)
                    {
                        //Escrinbimos en las celdas de los datos del proveedor, segun la plantilla
                        ws.Cells[fila1, 1].Value = drProveedor["Cod_prv"].ToString();
                        ws.Cells[fila1, 2].Value = drProveedor["Raz_soc_prv"].ToString();
                        ws.Cells[fila1, 3].Value = drProveedor["Dir_prv"].ToString();
                        ws.Cells[fila1, 4].Value = drProveedor["Tel_prv"].ToString();
                        ws.Cells[fila1, 5].Value = drProveedor["Departamento"].ToString() + "-" +
                                                   drProveedor["Provincia"].ToString() + "-" +
                                                   drProveedor["Distrito"].ToString();
                        ws.Cells[fila1, 6].Value = drProveedor["Rep_ven"].ToString();

                        //Incremento la variable fila1
                        fila1 += 1;
                    }
                    //modificamos las columnas de la hoja...
                    ws.Column(1).Width = 30;
                    ws.Column(2).Width = 50;
                    ws.Column(3).Width = 90;
                    ws.Column(4).Width = 40;
                    ws.Column(5).Width = 50;
                    ws.Column(6).Width = 45;
                    //Creamos un nombre de archivo basado en la credencial del usuario Logueado...
                    String filename = "ListadoProveedores_" + clsCredenciales.Usuario + ".xlsx";

                    //Gravamos el archivo construido...
                    FileStream fs = new FileStream(@"D:\Carpetas_Software\DesarrolloApliEm (LEON)\MisExcel" + filename, FileMode.Create);
                    pck.SaveAs(fs);

                    //Eliminamos las instancias.....
                    pck.Dispose();
                    fs.Dispose();

                    //Mostramos el mensaje al usuario...
                    MessageBox.Show("El archivo: " + filename + " se ha generado con exito.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
