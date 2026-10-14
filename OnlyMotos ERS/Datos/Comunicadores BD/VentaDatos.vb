Imports Microsoft.Data.SqlClient
Public Class VentaDatos

    Public Function ObtenerTiposFactura() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarTiposFactura", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ListarClientesParaCombo() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarClientesParaCombo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerMotosDisponibles() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarMotosDisponibles", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerDatosMotoPorId(idMoto As Integer) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ObtenerMotoPorId", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_moto", idMoto)
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function DescontarStockMoto(idMoto As Integer, cantidad As Integer) As Boolean

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_DescontarStockDetalle", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_moto", idMoto)
                comando.Parameters.AddWithValue("@cantidad", cantidad)

                Dim paramResultado As New SqlParameter("@resultado", SqlDbType.Int)
                paramResultado.Direction = ParameterDirection.Output
                comando.Parameters.Add(paramResultado)

                conexion.Open()
                comando.ExecuteNonQuery()

                Dim exito As Integer = Convert.ToInt32(paramResultado.Value)
                Return (exito = 1)

            End Using

        End Using

    End Function

    Public Sub DevolverStockMoto(idMoto As Integer, cantidad As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_DevolverStockMoto", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_moto", idMoto)
                comando.Parameters.AddWithValue("@cantidad", cantidad)

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function RegistrarVentaCompleta(idUsuario As Integer, idCliente As Integer, idTipoFactura As Integer, fecha As DateTime, total As Decimal, dtDetalle As DataTable) As Boolean

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            conexion.Open()

            Using transaccion As SqlTransaction = conexion.BeginTransaction()

                Try

                    Dim idVentaGenerado As Integer = 0

                    Using cmdCabecera As New SqlCommand("sp_RegistrarCabeceraVenta", conexion, transaccion)

                        cmdCabecera.CommandType = CommandType.StoredProcedure
                        cmdCabecera.Parameters.AddWithValue("@id_usuario", idUsuario)
                        cmdCabecera.Parameters.AddWithValue("@id_cliente", idCliente)
                        cmdCabecera.Parameters.AddWithValue("@id_tipoFactura", idTipoFactura)
                        cmdCabecera.Parameters.AddWithValue("@fecha", fecha)
                        cmdCabecera.Parameters.AddWithValue("@total", total)

                        Dim paramId As New SqlParameter("@id_venta_generado", SqlDbType.Int)
                        paramId.Direction = ParameterDirection.Output
                        cmdCabecera.Parameters.Add(paramId)

                        cmdCabecera.ExecuteNonQuery()
                        idVentaGenerado = Convert.ToInt32(paramId.Value)

                    End Using


                    For Each row As DataRow In dtDetalle.Rows

                        Using cmdDetalle As New SqlCommand("sp_RegistrarDetalleVenta", conexion, transaccion)

                            cmdDetalle.CommandType = CommandType.StoredProcedure
                            cmdDetalle.Parameters.AddWithValue("@id_venta", idVentaGenerado)
                            cmdDetalle.Parameters.AddWithValue("@id_moto", Convert.ToInt32(row("id_moto")))
                            cmdDetalle.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row("Cantidad")))
                            cmdDetalle.Parameters.AddWithValue("@sub_total", Convert.ToDecimal(row("SubTotal")))

                            cmdDetalle.ExecuteNonQuery()

                        End Using

                    Next


                    transaccion.Commit()
                    Return True

                Catch ex As Exception

                    transaccion.Rollback()
                    Throw New Exception("Error al registrar la venta en la base de datos: " & ex.Message)

                End Try

            End Using

        End Using

    End Function

End Class
