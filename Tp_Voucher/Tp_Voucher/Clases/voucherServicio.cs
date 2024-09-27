using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Tp_Voucher.Clases
{
    public class voucherServicio
    {
        public List <Voucher> listar()
        {
            List<Voucher> lista = new List<Voucher>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=PROMOS_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT CodigoVoucher,IdCliente,FechaCanje,IdArticulo FROM Vouchers";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Voucher aux = new Voucher();

                    // Verificar que el campo no sea nulo antes de asignar el valor
                    aux.codigo = !lector.IsDBNull(0) ? lector.GetString(0) : string.Empty;
                    aux.IdCliente = !lector.IsDBNull(1) ? lector.GetInt32(1) : 0;

                    // Para FechaCanje, si es nulo, puedes asignar una fecha por defecto
                    aux.FechaCanje = !lector.IsDBNull(2) ? lector.GetDateTime(2) : DateTime.MinValue;

                    aux.idArticulo = !lector.IsDBNull(3) ? lector.GetInt32(3) : 0;

                    lista.Add(aux);
                }

                conexion.Close();
            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}