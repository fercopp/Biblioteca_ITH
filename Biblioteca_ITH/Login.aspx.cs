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

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void btnInicio_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Inicio_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = UsuarioControlador.LogIn(txtEmail.Text, txtContraseña.Text);

                Session["usuario"] = objUsuario;
                string redirect = Request.QueryString["redirect"];
                if (objUsuario.TipoUsuario.nombre == "Administrador")
                {
                    Response.Redirect("principal.aspx");
                }
                else if (objUsuario.TipoUsuario.nombre == "Cliente")
                {
                    if (redirect != string.Empty)
                    {
                        Response.Redirect(redirect);
                    }
                    else
                    {
                        Response.Redirect("index.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "error(\"" + ex.Message + "\");", true);
            }
        }


    }
}