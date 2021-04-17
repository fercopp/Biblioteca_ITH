using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ContactoControlador
    {
        public static void CrearContacto(Contacto objContacto)
        {
            try
            {
                if (string.IsNullOrEmpty(objContacto.nombre))
                {
                    throw new Exception("Nombre faltante");
                }

                if (string.IsNullOrEmpty(objContacto.primer_apellido))
                {
                    throw new Exception("Primer Apellido faltante");
                }

                if (string.IsNullOrEmpty(objContacto.email))
                {
                    throw new Exception("Correo faltante");
                }

                ContactoModelo.InsertarContacto(objContacto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ModificarContacto(Blog blog)
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

        public static List<Contacto> ObtenerContactos()
        {
            try
            {
                return ContactoModelo.ObtenerContactos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                throw new Exception(ex.Message);
            }
        }


    }
}
