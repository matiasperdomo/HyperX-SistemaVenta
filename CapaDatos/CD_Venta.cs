using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Venta
    {

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }


        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }



        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("DocumentoCliente", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }



        public List<Venta> Listar()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdVenta, NumeroDocumento, DocumentoCliente, NombreCliente, MontoTotal, convert(char(10), FechaRegistro, 103)[FechaRegistro] from VENTA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });

                        }

                    }


                }
                catch (Exception ex)
                {

                    lista = new List<Venta>();
                }
            }

            return lista;

        }


        public Venta ObtenerVenta(string numero) {

            Venta obj = new Venta();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.IdVenta,u.NombreCompleto,");
                    query.AppendLine("v.DocumentoCliente,v.NombreCliente,");
                    query.AppendLine("v.TipoDocumento,v.NumeroDocumento,");
                    query.AppendLine("v.MontoPago,v.MontoCambio,v.MontoTotal,");
                    query.AppendLine("convert(char(10),v.FechaRegistro,103)[FechaRegistro]");
                    query.AppendLine("from VENTA v");
                    query.AppendLine("inner join USUARIO u on u.IdUsuario = v.IdUsuario");
                    query.AppendLine("where v.NumeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader()) {

                        while (dr.Read()) {
                            obj = new Venta()
                            {
                                IdVenta = int.Parse(dr["IdVenta"].ToString()),
                                oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }

                }
                catch {
                    obj = new Venta();
                }

            }
            return obj;

        }


        public List<Detalle_Venta> ObtenerDetalleVenta(int idVenta) {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre,dv.PrecioVenta,dv.Cantidad,dv.SubTotal from DETALLE_VENTA dv");
                    query.AppendLine("inner join PRODUCTO p on p.IdProducto = dv.IdProducto");
                    query.AppendLine(" where dv.IdVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@idventa", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;

                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                oProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }
                    }

                }
                catch {
                    oLista = new List<Detalle_Venta>();
                }
            }
            return oLista;
        }




        public decimal ObtenerRecaudacionTotal()
        {

            Venta obj = new Venta();
            decimal monto = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select sum(dbo.VENTA.MontoTotal) from dbo.VENTA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@MontoTotal", monto);
                    cmd.CommandType = System.Data.CommandType.Text;
                    monto = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch
                {
                    //ERROR
                }

            }
            return monto;

        }

        public decimal ObtenerPromedioVenta()
        {

            Venta obj = new Venta();
            decimal promedio = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select avg(dbo.VENTA.MontoTotal) from dbo.VENTA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@MontoTotal", promedio);
                    cmd.CommandType = System.Data.CommandType.Text;
                    promedio = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch
                {
                    //ERROR
                }

            }
            return promedio;

        }


        public decimal ObtenerMayorVenta()
        {

            Venta obj = new Venta();
            decimal ventaMax = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select max(dbo.VENTA.MontoTotal) from dbo.VENTA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@MontoTotal", ventaMax);
                    cmd.CommandType = System.Data.CommandType.Text;
                    ventaMax = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch
                {
                    //ERROR
                }

            }
            return ventaMax;

        }


        public decimal ObtenerMenorVenta()
        {

            Venta obj = new Venta();
            decimal ventaMin = 0;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select min(dbo.VENTA.MontoTotal) from dbo.VENTA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@MontoTotal", ventaMin);
                    cmd.CommandType = System.Data.CommandType.Text;
                    ventaMin = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch
                {
                    //ERROR
                }

            }
            return ventaMin;

        }



    }
}
