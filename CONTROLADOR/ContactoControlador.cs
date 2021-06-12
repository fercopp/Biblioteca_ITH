using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// En esta clase se tienen validaciones en los campos para crear un contacto en la base de datos
    /// 
    /// ### Example
    /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~.cpp
    /// if (string.IsNullOrEmpty(objContacto.nombre)) { throw new Exception("Nombre faltante");}
    /// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    public class ContactoControlador
    {

        [Obsolete("Este metodo es viejo. No usar.")]
        protected void ModificarProducto(Blog blog)
        {

        }

        public static void CrearContacto(Contacto objContacto)
        {
            try
            {
                if (string.IsNullOrEmpty(objContacto.nombre))
                {
                    throw new ArgumentNullException("Nombre faltante");
                }

                if (string.IsNullOrEmpty(objContacto.primer_apellido))
                {
                    throw new ArgumentNullException("Primer Apellido faltante");
                }

                if (string.IsNullOrEmpty(objContacto.email))
                {
                    throw new ArgumentNullException("Correo faltante");
                }

                ContactoModelo.InsertarContacto(objContacto);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static void ModificarContacto(Blog blog)
        {
            try
            {
                if (string.IsNullOrEmpty(blog.titulo))
                {
                    throw new ArgumentNullException("Titulo faltante");
                }

                if (string.IsNullOrEmpty(blog.descripcion))
                {
                    throw new ArgumentNullException("Descripcion faltante");
                }

                BlogModelo.ModificarBlog(blog);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        ///Obtener la lista de contactos con sus mensajes si no hay errores
        public static List<Contacto> ObtenerContactos()
        {
            try
            {
                return ContactoModelo.ObtenerContactos();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static List<Contacto> BuscarContactoPorCriterios(string criterios, bool estado)
        {
            try
            {
                return ContactoModelo.BuscarContactoPorCriterios(criterios, estado);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


    }
}
