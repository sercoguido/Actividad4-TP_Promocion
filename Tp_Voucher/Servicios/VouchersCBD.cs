using Data_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class VoucherCBD
        {
            public bool ValidarVoucher(string codigoVoucher)
            {
                AccesoDatos datos = new AccesoDatos();
                bool existe = false;

                try
                {
                    datos.setearConsulta("SELECT COUNT(*) FROM PROMOS_DB.dbo.Vouchers WHERE codigo = @CodigoVoucher");
                    datos.setearParametro("@CodigoVoucher", codigoVoucher);
                    datos.ejecutarLectura();

                    if (datos.Lector.Read())
                    {
                        int cantidad = (int)datos.Lector[0];
                        if (cantidad > 0)
                        {
                            existe = true; // El voucher existe
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }

                return existe;
            
        }
    }
}
