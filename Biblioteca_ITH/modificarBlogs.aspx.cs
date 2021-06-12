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

    public partial class agregarBlogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstBlogs.DataSource = BlogControlador.ObtenerBlogs(true);
            lstBlogs.DataBind();
        }


        [Obsolete("Este metodo es viejo. No usar.")]
        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Blog blog = BlogControlador.ObtenerBlogPorID(Convert.ToInt32(btn.Attributes["obj"]));
                txtDesc.Text = blog.descripcion;
                txtTitulo.Text = blog.titulo;
                chkActivo.Checked = blog.activo;
                lblImagen.Text = blog.imagen;
                hdnProdId.Value = blog.id.ToString();
                lblModal.InnerText = "Editar";
                string javascript = "mostrarModal()";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javascript, true);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void btnBorrar_Click(object sender, EventArgs e)
        {

        }
        protected void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                Blog blog = BlogControlador.ObtenerBlogPorID(Convert.ToInt32(btn.Attributes["obj"]));
                BlogControlador.EliminarBlog(blog);
                Page_Load(null, null);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void lbtGuardar_Click(object sender, EventArgs e)
        {

        }
        protected void Lbt_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Blog blog = new Blog();

                blog.activo = true;
                blog.descripcion = txtDesc.Text;
                blog.titulo = txtTitulo.Text;
                blog.activo = chkActivo.Checked;
                if (fupImagen.HasFile && (System.IO.Path.GetExtension(fupImagen.FileName) == ".jpg" || System.IO.Path.GetExtension(fupImagen.FileName) == ".png" || System.IO.Path.GetExtension(fupImagen.FileName) == ".jpeg"))
                {
                    fupImagen.SaveAs(Server.MapPath("~/include/images/Blogs/") + Server.HtmlEncode(fupImagen.FileName));
                    blog.imagen = Server.HtmlEncode(fupImagen.FileName);
                }
                else
                {
                    blog.imagen = lblImagen.Text;
                }
                if (hdnProdId.Value != "0")
                {
                    blog.id = Convert.ToInt32(hdnProdId.Value);
                    BlogControlador.ModificarBlog(blog);
                }
                else
                {
                    BlogControlador.InsertarBlog(blog);
                }
                Page_Load(null, null);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(\"" + ex.Message + "\");", true);
            }
        }

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        protected void Btn_Agregar_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            txtTitulo.Text = "";
            lblImagen.Text = "";
            hdnProdId.Value = "0";
            chkActivo.Checked = true;
            lblModal.InnerText = "Agregar";
            string javascript = "mostrarModal()";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javascript, true);
            Page_Load(null, null);
        }

    }
}