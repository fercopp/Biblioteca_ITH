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
    public partial class contacto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }
        protected void Btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto();
                contacto.email = txtCorreo.Text;
                contacto.nombre = txtNombre.Text;
                contacto.primer_apellido = txtApellido1.Text;
                contacto.segundo_apellido = txtApellido2.Text;
                contacto.sugerencia = txtSugerencia.Text;
                ContactoControlador.CrearContacto(contacto);
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Mensaje enviado');", true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

    }
}
