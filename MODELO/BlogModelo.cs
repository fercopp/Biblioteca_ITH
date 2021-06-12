using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Es la capa donde se trabaja con los datos, por tanto contendrá mecanismos para acceder a la información y 
/// también para actualizar su estado.
namespace MODELO
{

    /// La clase BlogModelo nos sirve para realizar diferentes peticiones (CRUD) a la tabla de Blogs de la base de datos
    public class BlogModelo
    {

        /// Se obtienen todos los blogs que esten activos en la base de datos
        /// <param name="estado">Para saber si el blog esta activo o desactivado (true or false)</param>
        static public List<Blog> ObtenerBlogs(bool estado)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    return contextoEntidades.Blogs.Where(p => p.activo == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        ///Guardar Blogs a la base de datos
        public static void InsertarBlog(Blog objBlog)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Blogs.Add(objBlog);
                    contextoEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        ///Modificación de Blogs en la base de datos
        public static void ModificarBlog(Blog blogMod)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Entry(blogMod).State = System.Data.Entity.EntityState.Modified;
                    contextoEntidades.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        ///Eliminar un blog de la base de datos por su id de blog
        static public void EliminarBlog(Blog objBlog)
        {
            try
            {
                Blog blog = new Blog() { id = objBlog.id };
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Blogs.Attach(blog);

                    contextoEntidades.Blogs.Remove(blog);
                    contextoEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        ///Para obtener los ID de los blogs de la base de datos
        /// <param name="id">Este parametro nos sirve para identificar el blog y poder obtenerlo desde la BD</param>
        static public Blog ObtenerBlogPorID(int id)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    var blogs = from p in contextoEntidades.Blogs
                                    where p.id == id
                                    select p;
                    return blogs.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

    }
}
