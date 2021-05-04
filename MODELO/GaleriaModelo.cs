using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    /// La clase GaleriaModelo contiene funciones para un CRUD 
    public class GaleriaModelo
    {
        /// Función para mostrar las imagenes de la tabla Galeria que estén activas en una lista
        static public List<Galeria> ObtenerGalerias(bool estado)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    return contextoEntidades.Galerias.Where(p => p.activo == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        ///Función para agregar una imagen a la base de datos 
        public static void InsertarGaleria(Galeria objGaleria)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Galerias.Add(objGaleria);
                    contextoEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// Función para editar una imagen de la tabla Galeria en la base de datos
        public static void ModificarGaleria(Galeria galeriaMod)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    contextoEntidades.Entry(galeriaMod).State = System.Data.Entity.EntityState.Modified;
                    contextoEntidades.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// Función para retornar una imagen por medio de su id 
        /// <param name="id">id unico de cada imagen de la tabla Galeria </param>
        static public Galeria ObtenerGaleriaPorID(int id)
        {
            try
            {
                using (var contextoEntidades = new BibliotecaITHEntities())
                {
                    var galerias = from p in contextoEntidades.Galerias
                                where p.id == id
                                select p;
                    return galerias.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
