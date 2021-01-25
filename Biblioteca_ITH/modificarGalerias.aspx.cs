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
    public partial class modificarGalerias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstGalerias.DataSource = GaleriaControlador.ObtenerGalerias(true);
            lstGalerias.DataBind();
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Galeria galeria = GaleriaControlador.ObtenerGaleriaPorID(Convert.ToInt32(btn.Attributes["obj"]));
                chkActivo.Checked = galeria.activo;
                lblImagen.Text = galeria.imagen;
                hdnProdId.Value = galeria.id.ToString();
                lblModal.InnerText = "Editar";
                string javascript = "mostrarModal()";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javascript, true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

        protected void lbtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Galeria galeria = new Galeria();

                galeria.activo = true;
                galeria.activo = chkActivo.Checked;
                if (fupImagen.HasFile && (System.IO.Path.GetExtension(fupImagen.FileName) == ".jpg" || System.IO.Path.GetExtension(fupImagen.FileName) == ".png" || System.IO.Path.GetExtension(fupImagen.FileName) == ".jpeg"))
                {
                    fupImagen.SaveAs(Server.MapPath("~/include/images/Instalaciones/") + Server.HtmlEncode(fupImagen.FileName));
                    galeria.imagen = Server.HtmlEncode(fupImagen.FileName);
                }
                else
                {
                    galeria.imagen = lblImagen.Text;
                }
                if (hdnProdId.Value != "0")
                {
                    galeria.id = Convert.ToInt32(hdnProdId.Value);
                    GaleriaControlador.ModificarGaleria(galeria);
                }
                else
                {
                    GaleriaControlador.InsertarGaleria(galeria);
                }
                Page_Load(null, null);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

    }
}