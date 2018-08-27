using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demolab2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Datos da = new Datos();
            GvProveedor.DataSource = da.ListaProveedores();
            GvProveedor.DataBind();
            /*GvListaClientesPais.DataSource = da.ListaClientesPais("Peru");
            GvListaClientesPais.DataBind();*/
        }

        protected void GvProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string param = GvProveedor.SelectedRow.Cells[4].Text;
            Console.WriteLine(param);
            Datos da = new Datos();
            GvListaClientesPais.DataSource = da.ListaClientesPais(param);
            GvListaClientesPais.DataBind();
        }

        protected void GvProveedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvProveedor.PageIndex = e.NewPageIndex;
            GvProveedor.DataBind();
        }

    }
}