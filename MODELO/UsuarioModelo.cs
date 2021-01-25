using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class UsuarioModelo
    {

        public static void InsertarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Usuarios.Add(nuevoUsuario);
                    contextoEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Usuario IngresarSistem(Usuario usuario)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    var resultado = from us in contextoEntidades.Usuarios
                                    where us.contraseña == usuario.contraseña && us.email == usuario.email
                                    && us.activo == true
                                    select us;
                    return resultado.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static Usuario BuscarUsuarioPorEmail(string email)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    var usuarios = from u in contextoEntidades.Usuarios.Include("TipoUsuario")
                                   where u.email == email
                                   select u;
                    return usuarios.FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
