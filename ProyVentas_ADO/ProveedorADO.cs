using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class ProveedorADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
          
        
        // Metodos de mantenimiento
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProveedor";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vraz", objProveedorBE.Raz_soc_prv);
                cmd.Parameters.AddWithValue("@vdir", objProveedorBE.Dir_prv);
                cmd.Parameters.AddWithValue("@vtel", objProveedorBE.Tel_prv);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prv);
                cmd.Parameters.AddWithValue("@vrep", objProveedorBE.Rep_ven);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProveedorBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vest_prv", objProveedorBE.Est_prv);
                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                
            }
          

        }
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", objProveedorBE.Cod_prv);
                cmd.Parameters.AddWithValue("@vraz", objProveedorBE.Raz_soc_prv);
                cmd.Parameters.AddWithValue("@vdir", objProveedorBE.Dir_prv);
                cmd.Parameters.AddWithValue("@vtel", objProveedorBE.Tel_prv);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prv);
                cmd.Parameters.AddWithValue("@vrep", objProveedorBE.Rep_ven);
                cmd.Parameters.AddWithValue("@vIdUbigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objProveedorBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vest_prv", objProveedorBE.Est_prv);
                // Abro la conexion y ejecutamos....
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;


            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
               
            }
           

        }

        public Boolean EliminarProveedor(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProveedor";
            cmd.Parameters.Clear();
            //Agregamos parametros 
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strcod);

                //Abro la conexion y ejecuto...
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
               

            }
            catch (SqlException x)
            {               
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                
            }
            

        }

        public ProveedorBE ConsultarProveedor(String strCod)
        {
            ProveedorBE objProveedorBE = new ProveedorBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarProveedor";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strCod);

                // Abrimos la conexion y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objProveedorBE.Cod_prv = dtr["cod_prv"].ToString();
                    objProveedorBE.Raz_soc_prv = dtr["raz_soc_prv"].ToString();
                    objProveedorBE.Dir_prv = dtr["dir_prv"].ToString();
                    objProveedorBE.Ruc_prv = dtr["ruc_prv"].ToString();
                    objProveedorBE.Tel_prv = dtr["tel_prv"].ToString();
                    objProveedorBE.Rep_ven = dtr["rep_ven"].ToString();
                    objProveedorBE.Est_prv = Convert.ToInt16 (dtr["est_prv"]);
                    objProveedorBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                
                }
                dtr.Close();
                return objProveedorBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                
            }
            
        }

        public DataTable ListarProveedor()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarProveedor";
            cmd.Parameters.Clear();
            try
            {
                //Codifique
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Proveedores");

                return dts.Tables["Proveedores"];
               
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

       

    }
}
