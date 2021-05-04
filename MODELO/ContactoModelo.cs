using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    /// La clase ContactoModelo se usa para insertar el mensaje y los datos de un contacto a la base de datos
    public class ContactoModelo
    {
        /// Función para agregar los datos de una persona que contacta a los administradores
        static public void InsertarContacto(Contacto objContacto)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Contactoes.Add(objContacto);
                    contextoEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// Función para mostrar las personas que hayan enviado mensaje en forma de lista al administrador
        static public List<Contacto> ObtenerContactos()
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    return contextoEntidades.Contactoes.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// Función para filtrar los contactos por criterios
        public static List<Contacto> BuscarContactoPorCriterios(string criterios, bool estado)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    var contactos = from u in contextoEntidades.Contactoes
                                   where (u.email.Contains(criterios) ||
                                   u.nombre.Contains(criterios) || u.primer_apellido.Contains(criterios)
                                   || u.segundo_apellido.Contains(criterios))
                                   select u;
                    return contactos.ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
