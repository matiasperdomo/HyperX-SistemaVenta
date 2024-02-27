using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<ReporteCompra> Compra(string fechainicio, string fechafin)
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new ReporteCompra()
                            {
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                DocumentoProveedor = dr["DocumentoProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<ReporteCompra>();
                }
            }

            return lista;

        }

        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }

            return lista;

        }



    }
}
