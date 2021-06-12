﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MODELO;

namespace CONTROLADOR
{

    /// En esta clase se encripta la contraseña del usuario, se valida el Login del usuario y se valida la creación de usuarios
    public static class UsuarioControlador
    {

        public static byte[] GenerarSal()
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] salt = new byte[32];
            rngCsp.GetBytes(salt);
            return salt;
        }

        public static byte[] EncriptarContraseña(string password, byte[] salt)
        {
            int iterations = 40000;
            byte[] hash;

            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            hash = pbkdf2.GetBytes(32);
            return hash;
        }

        public static void CrearUsuario(Usuario objUsuario)
        {
            try
            {

                if (string.IsNullOrEmpty(objUsuario.nombre) || string.IsNullOrEmpty(objUsuario.primer_apellido))
                {
                    throw new ArgumentNullException("Nombre o apellido faltante");
                }
                if (string.IsNullOrEmpty(objUsuario.email) || string.IsNullOrEmpty(objUsuario.contraseña))
                {
                    throw new ArgumentNullException("Email o contraseña nulos");
                }

                if (UsuarioModelo.BuscarUsuarioPorEmail(objUsuario.email) != null)
                {
                    throw new ArgumentNullException("Email ya existente");
                }

                byte[] salt = GenerarSal();
                objUsuario.contraseña = Convert.ToBase64String(salt) + "!" + Convert.ToBase64String(EncriptarContraseña
                    (objUsuario.contraseña, salt));

                UsuarioModelo.InsertarUsuario(objUsuario);

                if (UsuarioModelo.BuscarUsuarioPorEmail(objUsuario.email) == null)
                {
                    throw new ArgumentNullException("Error en creación de usuario");
                }
            }

            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }


        public static Usuario LogIn(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ArgumentNullException("Email o contraseña nulos");
                }

                Usuario objUsuario = UsuarioModelo.BuscarUsuarioPorEmail(email);

                if (objUsuario == null)
                {
                    throw new ArgumentNullException("Email o contraseña incorrectos");
                }

                string[] contraseña = objUsuario.contraseña.Split('!');

                byte[] salt = Convert.FromBase64String(contraseña[0]);
                byte[] hash = Convert.FromBase64String(contraseña[1]);
                byte[] newhash = EncriptarContraseña(password, salt);

                if (hash.SequenceEqual(newhash))
                {
                    return objUsuario;
                }
                else
                {
                    throw new ArgumentException("Email o contraseña incorrectos");
                }

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public static Usuario BuscarUsuarioPorEmail(string email)
        {
            try
            {
                return UsuarioModelo.BuscarUsuarioPorEmail(email);

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
