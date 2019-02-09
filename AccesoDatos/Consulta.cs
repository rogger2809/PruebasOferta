using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloNegocios;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using ModeloDatos;

namespace AccesoDatos
{
    public class Consulta
    {
        public static List<Resultado> ObtenerResultado(int IdProducto)
        {
            List<Resultado> ObjRespuesta = null;

            using (PruebaDBEntities conexion = new PruebaDBEntities())
            {
                try
                {
                    ObjRespuesta = conexion.OfertaDemanda(IdProducto).Select(x => new Resultado {
                        IdProducto = x.idProducto,
                        CantidadSolicitada = x.cantidadSolicitada,
                        CantidadAsignada = x.cantidadAsignada,
                        Residuo = x.residuo,
                        CantidadDisponible = x.cantidadDisponible,
                        Lote = x.lote
                    }).ToList();
                }
                catch(Exception ex)
                {

                }
            }

                return ObjRespuesta;
        }
    }
}
