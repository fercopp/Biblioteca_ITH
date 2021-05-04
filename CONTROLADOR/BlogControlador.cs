using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

/// Es una capa que sirve de enlace entre las vistas y los modelos, respondiendo a los mecanismos que puedan requerirse para 
/// implementar las necesidades de nuestra aplicación.

namespace CONTROLADOR
{

    /// En esta clase se tienen ciertas validaciones al momento de insertar, modificar, eliminar, etc.
    public class BlogControlador
    {
        public static void InsertarBlog(Blog blog)
        {
            try
            {
                if (string.IsNullOrEmpty(blog.titulo))
                {
                    throw new Exception("Titulo faltante");
                }

                if (string.IsNullOrEmpty(blog.descripcion))
                {
                    throw new Exception("Descripción faltante");
                }

                BlogModelo.InsertarBlog(blog);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Blog> ObtenerBlogs(bool estado)
        {
            try
            {
                return BlogModelo.ObtenerBlogs(estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Blog ObtenerBlogPorID(int id)
        {

            try
            {
                if (id <= 0)
                {
                    throw new Exception("ID no valido");
                }
                return BlogModelo.ObtenerBlogPorID(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ModificarBlog(Blog blog)
        {
            try
            {
                if (string.IsNullOrEmpty(blog.titulo))
                {
                    throw new Exception("Titulo faltante");
                }

                if (string.IsNullOrEmpty(blog.descripcion))
                {
                    throw new Exception("Descripcion faltante");
                }

                BlogModelo.ModificarBlog(blog);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void EliminarBlog(Blog blog)
        {
            try
            {
                BlogModelo.EliminarBlog(blog);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
