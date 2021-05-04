using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// Se tienen validaciones al momento de insertar, modificar o eliminar imagenes
    public class GaleriaControlador
    {
        public static List<Galeria> ObtenerGalerias(bool estado)
        {
            try
            {
                return GaleriaModelo.ObtenerGalerias(estado);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Galeria ObtenerGaleriaPorID(int id)
        {

            try
            {
                if (id <= 0)
                {
                    throw new Exception("ID no valido");
                }
                return GaleriaModelo.ObtenerGaleriaPorID(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ModificarGaleria(Galeria galeria)
        {
            try
            {

                GaleriaModelo.ModificarGaleria(galeria);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void InsertarGaleria(Galeria galeria)
        {
            try
            {

                GaleriaModelo.InsertarGaleria(galeria);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
