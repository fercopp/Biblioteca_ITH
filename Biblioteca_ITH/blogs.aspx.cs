using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELO;
using CONTROLADOR;

namespace Biblioteca_ITH
{
    public partial class blogs1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstNewBlog.DataSource = BlogControlador.ObtenerBlogs(true);
            lstNewBlog.DataBind();

        }
    }
}