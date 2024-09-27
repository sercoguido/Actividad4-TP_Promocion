using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tp_Voucher.Clases;

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
            voucherServicio servicio = new voucherServicio();

            // Obtener la lista de vouchers
            List<Tp_Voucher.Clases.Voucher> listaVouchers = servicio.listar();

            // Enlazar la lista de vouchers al GridView
            gvVouchers.DataSource = listaVouchers;
            gvVouchers.DataBind();
        }


        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            lbl1.Text = "asd";
        }
    }
}