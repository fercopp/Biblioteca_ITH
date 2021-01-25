using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class GaleriaModelo
    {
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
