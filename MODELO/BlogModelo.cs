using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class BlogModelo
    {
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
                throw new Exception(ex.Message);
            }
        }

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
                throw new Exception(ex.Message);
            }
        }

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
                throw new Exception(ex.Message);
            }
        }

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
                throw new Exception(ex.Message);
            }
        }

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
                throw new Exception(ex.Message);
            }
        }

    }
}
