using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;

namespace Tp_Voucher
{
    public partial class Voucher : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            // Solo cargar los datos si no es un postback
            if (!IsPostBack)
            {
                CargarVouchers();
            }



        }
        // Método para cargar los vouchers y mostrarlos en el GridView
        private void CargarVouchers()
        {
            // Instancia de voucherServicio para acceder al método listar()
            VoucherCBD servicio = new VoucherCBD();

            // Obtener la lista de vouchers
            List<Tp_Voucher.Clases.Voucher> listaVouchers = servicio.listar();

            // Enlazar la lista de vouchers al GridView
            gvVouchers.DataSource = listaVouchers;
            gvVouchers.DataBind();
        }


        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            string codigoVoucher = "VOUCHER123"; // Código del voucher que quieres verificar
            VerificarVoucher(codigoVoucher);
        }

        private void VerificarVoucher(string codigoVoucher)
        {
            // Instancia de voucherServicio para acceder al método ExisteVoucher()
            VoucherCBD servicio = new VoucherCBD();

            // Verificar si el voucher existe
            bool existe = servicio.ExisteVoucher(codigoVoucher);

            if (existe)
            {
                // Si el voucher existe, hacer algo, por ejemplo, mostrar un mensaje
                lbl1.Text = "El voucher existe.";
            }
            else
            {
                // Si no existe, manejar el caso de que no se encontró el voucher
                lbl1.Text = "No se encontró el voucher.";
            }
        }
    }
}