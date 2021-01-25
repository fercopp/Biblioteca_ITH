using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CONTROLADOR;
using MODELO;

namespace Biblioteca_ITH
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstNewGaleria1.DataSource = GaleriaControlador.ObtenerGalerias(true);
            lstNewGaleria1.DataBind();
        }
    }
}