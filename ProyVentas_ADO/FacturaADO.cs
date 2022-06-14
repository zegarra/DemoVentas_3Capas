using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class FacturaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataReader ada;

     //   public DataTable VentasPorAño()
    //    {
      //      DataSet dts = new DataSet();
      //      cnx.ConnectionString = MiConexion.GetCnx();
     //       cmd.Connection = cnx;
     //       cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.CommandText = "usp_VentasPorAño";
    //        cmd.Parameters.Clear();
     //       try
     //       {
             //   ada = new SqlDataAdapter(cmd);
             //   ada.Fill(dts, "FacturasAño");
              //  return dts.Tables["FacturasCliente"];
   //         }
    //        catch(SqlException ex)
   //         {
   //             throw new Exception(ex.Message);
  //          }
 //       }
    }
}
