Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class Carga_de_cpos_masiva
    Private archivoCargado As Boolean = False
    Private archivoExcelRuta As String = String.Empty
    Private usuarioActual As String = GlobalVariables.usuarioglobal


    ' Función para obtener la conexión a la base de datos de inventarios
    Private Sub def_sql_inventarios(ByRef conexion As SqlClient.SqlConnection)
        conexion = New SqlClient.SqlConnection("Data Source=192.9.200.3\JT;initial catalog=inventarios;User id=user_e;Password=Ga2412_e")
    End Sub

    ' Evento para cargar la pantalla
    Private Sub Carga_de_cpos_masiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If VerificarPantallaEnUso("Carga_de_cpos_masiva") Then
            MessageBox.Show($"La pantalla está siendo utilizada por: {ObtenerUsuarioBloqueo("Carga_de_cpos_masiva")}")
            Me.Close()
            Return
        End If

        ' Bloquear la pantalla para el usuario actual
        BloquearPantalla("Carga_de_cpos_masiva", usuarioActual)


        ' Al iniciar, ocultar el Panel1
        Panel1.Visible = False

        ' Cambiar el texto del botón
        Boton_cargar.Text = "Cargar"

        ' Inicializa la conexión
        Dim cnn As SqlClient.SqlConnection
        def_sql(cnn)

        ' Cargar los clientes activos en el ComboBox usando la conexión cnn
        CargarClientesEnComboBox(cnn)
    End Sub

    Private Sub CargarClientesEnComboBox(ByVal conexion As SqlClient.SqlConnection)
        ' Usar la conexión proporcionada para obtener los clientes activos
        Dim queryClientes As String = "SELECT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S'"

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("CLIENTE") ' Placeholder

        ' Asegurar que la conexión esté abierta
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            ' Ejecutar la consulta para obtener los clientes activos
            Using command As New SqlClient.SqlCommand(queryClientes, conexion)
                Using reader As SqlClient.SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cliente As String = reader("CLIENTE").ToString()
                        ComboBox1.Items.Add(cliente)
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar clientes: " & ex.Message)
        End Try

        ' Establecer el placeholder como el seleccionado por defecto
        ComboBox1.SelectedIndex = 0
    End Sub

    ' Evento Click del botón para subir el archivo Excel o insertar los datos
    Private Sub Boton_cargar_Click(sender As Object, e As EventArgs) Handles Boton_cargar.Click
        If Not archivoCargado Then
            ' Si aún no se ha cargado un archivo, cargar el archivo Excel
            CargarArchivoExcel()
        Else
            ' Si ya se cargó el archivo, proceder a insertar los datos en la base de datos
            SubirDatos()
        End If
    End Sub

    ' Método para cargar el archivo Excel
    Private Sub CargarArchivoExcel()
        ' Crear y configurar el OpenFileDialog
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Excel Files|*.xls;*.xlsx",
            .Title = "Seleccione un archivo Excel"
        }

        ' Abrir el diálogo de selección de archivo
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Guardar la ruta del archivo Excel cargado
            archivoExcelRuta = openFileDialog.FileName
            ' Cargar las columnas del archivo Excel para que el usuario las asigne
            SeleccionarColumnasExcel(archivoExcelRuta)

            ' Cambiar el estado para indicar que el archivo ya fue cargado
            archivoCargado = True
            ' Cambiar el texto del botón a "Subir Datos"
            Boton_cargar.Text = "Subir Datos"
        End If
    End Sub

    ' Método para seleccionar columnas del archivo Excel
    Private Sub SeleccionarColumnasExcel(rutaArchivo As String)
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open(rutaArchivo)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim range As Excel.Range = worksheet.UsedRange

            ' Preseleccionar las columnas basadas en la primera fila del Excel
            Dim columnasDisponibles As New List(Of String)
            For columna As Integer = 1 To range.Columns.Count
                Dim valorCelda = range.Cells(1, columna).Value
                If valorCelda IsNot Nothing Then
                    columnasDisponibles.Add(valorCelda.ToString())
                End If
            Next

            ' Actualizar los ComboBoxes solo si hay columnas disponibles
            ActualizarComboBox(ComboBox_CPO, columnasDisponibles, "CPO")
            ActualizarComboBox(ComboBox_ESTILO, columnasDisponibles, "ESTILO")
            ActualizarComboBox(ComboBox_COLOR, columnasDisponibles, "COLOR")
            ActualizarComboBox(ComboBox_TALLA, columnasDisponibles, "TALLA")
            ActualizarComboBox(ComboBox_UNIDADES, columnasDisponibles, "UNIDADES")
            ActualizarComboBox(ComboBox_TOTAL, columnasDisponibles, "TOTAL")
            ActualizarComboBox(ComboBox_ESTADO, columnasDisponibles, "ESTADO")
            ActualizarComboBox(ComboBox_DESTINO, columnasDisponibles, "DESTINO")
            ActualizarComboBox(ComboBox_VENDEDOR, columnasDisponibles, "VENDEDOR")
            ActualizarComboBox(ComboBox_COMISION, columnasDisponibles, "COMISION")
            ActualizarComboBox(ComboBox_ESCALA, columnasDisponibles, "ESCALA")
            ActualizarComboBox(ComboBox_MINIMO_P, columnasDisponibles, "MINIMO_P")
            ActualizarComboBox(ComboBox_MAXIMO_P, columnasDisponibles, "MAXIMO_P")
            ActualizarComboBox(ComboBox_PRECIO, columnasDisponibles, "PRECIO")

        Catch ex As Exception
            MessageBox.Show("Error al procesar el archivo Excel: " & ex.Message)
        Finally
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()

            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub

    ' Método para actualizar un ComboBox de acuerdo a las columnas disponibles y asignar el valor predefinido
    Private Sub ActualizarComboBox(comboBox As ComboBox, columnas As List(Of String), nombreColumna As String)
        comboBox.Items.Clear()
        comboBox.Items.AddRange(columnas.ToArray())
        If columnas.Contains(nombreColumna) Then
            comboBox.SelectedIndex = columnas.IndexOf(nombreColumna)
        Else
            comboBox.SelectedIndex = -1 ' No asignar valor si no se encuentra
        End If
    End Sub

    ' Método para insertar datos después de que el usuario confirme las columnas
    Private Sub SubirDatos()
        ' Verificar si ya se cargó el archivo Excel
        If String.IsNullOrEmpty(archivoExcelRuta) Then
            MessageBox.Show("Primero debe cargar un archivo Excel.")
            Return
        End If

        ' Reutilizar la conexión existente (cnn) para todo el proceso
        Dim conexion As SqlClient.SqlConnection = Nothing
        def_sql(conexion) ' Esta función te dará la conexión correcta según la base de datos actual

        ' Cargar el archivo Excel nuevamente para extraer los datos
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' Abrir el archivo Excel desde la ruta previamente cargada
            workbook = excelApp.Workbooks.Open(archivoExcelRuta)
            worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            Dim range As Excel.Range = worksheet.UsedRange

            ' Procesar las filas y extraer los datos
            For fila As Integer = 2 To range.Rows.Count
                Try
                    ' Obtener valores de las celdas
                    Dim cpo As String = If(range.Cells(fila, ComboBox_CPO.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_CPO.SelectedIndex + 1).Value.ToString(), String.Empty)
                    Dim estilo As String = If(range.Cells(fila, ComboBox_ESTILO.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_ESTILO.SelectedIndex + 1).Value.ToString(), String.Empty)
                    Dim color As String = If(range.Cells(fila, ComboBox_COLOR.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_COLOR.SelectedIndex + 1).Value.ToString(), String.Empty)
                    Dim talla As String = If(range.Cells(fila, ComboBox_TALLA.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_TALLA.SelectedIndex + 1).Value.ToString(), String.Empty)

                    ' Verificar si los campos obligatorios están vacíos
                    If String.IsNullOrEmpty(cpo) OrElse String.IsNullOrEmpty(estilo) OrElse String.IsNullOrEmpty(color) Then
                        ' Saltar esta fila si alguno de los valores clave está vacío
                        Continue For
                    End If

                    ' Validar si el valor de "unidades" es un número antes de convertir
                    Dim unidades As Integer = 0
                    If IsNumeric(range.Cells(fila, ComboBox_UNIDADES.SelectedIndex + 1).Value) Then
                        unidades = CInt(range.Cells(fila, ComboBox_UNIDADES.SelectedIndex + 1).Value)
                    End If

                    ' Validar si el valor de "total" es un número antes de convertir
                    Dim total As Integer = 0
                    If IsNumeric(range.Cells(fila, ComboBox_TOTAL.SelectedIndex + 1).Value) Then
                        total = CInt(range.Cells(fila, ComboBox_TOTAL.SelectedIndex + 1).Value)
                    End If

                    Dim estado As String = If(range.Cells(fila, ComboBox_ESTADO.SelectedIndex + 1).Value.ToString(), String.Empty)
                    Dim destino As String = If(range.Cells(fila, ComboBox_DESTINO.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_DESTINO.SelectedIndex + 1).Value.ToString(), String.Empty)
                    Dim vendedor As String = If(range.Cells(fila, ComboBox_VENDEDOR.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_VENDEDOR.SelectedIndex + 1).Value.ToString(), String.Empty)

                    ' Validar comision como decimal
                    Dim comision As Decimal = 0
                    If IsNumeric(range.Cells(fila, ComboBox_COMISION.SelectedIndex + 1).Value) Then
                        comision = CDec(range.Cells(fila, ComboBox_COMISION.SelectedIndex + 1).Value)
                    End If

                    Dim escala As String = If(range.Cells(fila, ComboBox_ESCALA.SelectedIndex + 1).Value IsNot Nothing, range.Cells(fila, ComboBox_ESCALA.SelectedIndex + 1).Value.ToString(), String.Empty)

                    ' Validar min/max como enteros
                    Dim minimoP As Integer = 0
                    If IsNumeric(range.Cells(fila, ComboBox_MINIMO_P.SelectedIndex + 1).Value) Then
                        minimoP = CInt(range.Cells(fila, ComboBox_MINIMO_P.SelectedIndex + 1).Value)
                    End If

                    Dim maximoP As Integer = 0
                    If IsNumeric(range.Cells(fila, ComboBox_MAXIMO_P.SelectedIndex + 1).Value) Then
                        maximoP = CInt(range.Cells(fila, ComboBox_MAXIMO_P.SelectedIndex + 1).Value)
                    End If

                    Dim precio As Decimal = 0
                    If IsNumeric(range.Cells(fila, ComboBox_PRECIO.SelectedIndex + 1).Value) Then
                        precio = CDec(range.Cells(fila, ComboBox_PRECIO.SelectedIndex + 1).Value)
                    End If

                    ' Insertar los datos en la tabla temporal utilizando la conexión correcta
                    InsertarDatosEnTablaTemporal(conexion, cpo, estilo, color, talla, unidades, total, estado, destino, vendedor, comision, escala, minimoP, maximoP, precio)

                Catch ex As Exception
                    ' Capturar el error y mostrar un mensaje con información de la fila
                    MessageBox.Show($"Error en la fila {fila}: {ex.Message}")
                End Try
            Next

            ' Mostrar mensaje de éxito
            MessageBox.Show("Datos subidos correctamente")

            ' Mostrar el panel y proceder con el resto de las operaciones
            MostrarPanel1()
            PoblarDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error al procesar los datos: " & ex.Message)
        Finally
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()
            ReleaseObject(workbook)
            ReleaseObject(worksheet)
            ReleaseObject(excelApp)
        End Try
    End Sub

    ' Método para mostrar el Panel1 y cambiar el diseño de la pantalla
    Private Sub MostrarPanel1()
        ' Ocultar los controles actuales (puedes ocultar más controles si es necesario)
        ComboBox_CPO.Visible = False
        ComboBox_ESTILO.Visible = False
        ComboBox_COLOR.Visible = False
        ComboBox_TALLA.Visible = False
        ComboBox_UNIDADES.Visible = False
        ComboBox_TOTAL.Visible = False
        ComboBox_ESTADO.Visible = False
        ComboBox_DESTINO.Visible = False
        ComboBox_VENDEDOR.Visible = False
        ComboBox_COMISION.Visible = False
        ComboBox_ESCALA.Visible = False
        ComboBox_MINIMO_P.Visible = False
        ComboBox_MAXIMO_P.Visible = False
        ComboBox_PRECIO.Visible = False
        Boton_cargar.Visible = False

        ' Mostrar el Panel1
        Panel1.Visible = True
    End Sub

    ' Método para poblar el DataGridView con los datos de la consulta SQL
    Private Sub PoblarDataGridView()
        ' Obtener la base de datos correcta que está utilizando
        Dim conexion As SqlClient.SqlConnection = Nothing
        def_sql(conexion) ' Utiliza la función que define la conexión adecuada

        ' Definir la consulta SQL que va a obtener los datos de la tabla TEMPORAL_CPO_D
        Dim query As String = "
        SELECT 
            CPO, 
            ESTILO, 
            COLOR,
            SUM(CAST(CASE WHEN TALLA = '1' THEN UNIDADES ELSE '0' END AS INT)) AS XS,
            SUM(CAST(CASE WHEN TALLA = '2' THEN UNIDADES ELSE '0' END AS INT)) AS S,
            SUM(CAST(CASE WHEN TALLA = '3' THEN UNIDADES ELSE '0' END AS INT)) AS M,
            SUM(CAST(CASE WHEN TALLA = '4' THEN UNIDADES ELSE '0' END AS INT)) AS L,
            SUM(CAST(CASE WHEN TALLA = '5' THEN UNIDADES ELSE '0' END AS INT)) AS XL,
            SUM(CAST(CASE WHEN TALLA = '6' THEN UNIDADES ELSE '0' END AS INT)) AS XL2,
            SUM(CAST(CASE WHEN TALLA = '7' THEN UNIDADES ELSE '0' END AS INT)) AS XL3,
            SUM(CAST(CASE WHEN TALLA = '8' THEN UNIDADES ELSE '0' END AS INT)) AS XL4,
            SUM(CAST(CASE WHEN TALLA = '9' THEN UNIDADES ELSE '0' END AS INT)) AS XL5,
            SUM(CAST(CASE WHEN TALLA = '10' THEN UNIDADES ELSE '0' END AS INT)) AS XL6,
            SUM(CAST(UNIDADES AS INT)) AS TOTAL,
            CAST(CASE WHEN TALLA = '1' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C1,
            CAST(CASE WHEN TALLA = '2' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C2,
            CAST(CASE WHEN TALLA = '3' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C3,
            CAST(CASE WHEN TALLA = '4' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C4,
            CAST(CASE WHEN TALLA = '5' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C5,
            CAST(CASE WHEN TALLA = '6' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C6,
            CAST(CASE WHEN TALLA = '7' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C7,
            CAST(CASE WHEN TALLA = '8' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C8,
            CAST(CASE WHEN TALLA = '9' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C9,
            CAST(CASE WHEN TALLA = '10' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2)) AS C0,
            ESTADO AS ESTADO,
            'SELECCIONAR' AS F_ENTREGA,
            'SELECCIONAR' AS F_PROMETIDA,
            DESTINO,
            GETDATE() AS F_INGRESO,
            VENDEDOR,
            COMISION,
            ESCALA,
            MINIMO_P,
            MAXIMO_P
        FROM 
            TEMPORAL_CPO_D
        GROUP BY 
            CPO, ESTILO, COLOR, ESTADO, DESTINO, VENDEDOR, COMISION, ESCALA, MINIMO_P, MAXIMO_P, TALLA, PRECIO;
        "

        ' Usar la conexión correcta proporcionada por def_sql()
        Using connection As SqlClient.SqlConnection = conexion
            Try
                connection.Open()

                ' Crear el adaptador de datos y ejecutar la consulta
                Dim adapter As New SqlClient.SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                ' Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dataTable)

                ' Asignar el DataTable como origen de datos del DataGridView
                DataGridView1.DataSource = dataTable

                ' Ajustar el tamaño de las columnas al contenido
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            Catch ex As Exception
                MessageBox.Show("Error al poblar el DataGridView: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para insertar datos en la tabla temporal
    Private Sub InsertarDatosEnTablaTemporal(ByVal conexion As SqlClient.SqlConnection, cpo As String, estilo As String, color As String, talla As String, unidades As Integer, total As Integer, estado As String, destino As String, vendedor As String, comision As Decimal, escala As String, minimoP As Integer, maximoP As Integer, precio As Decimal)
        ' Eliminar todos los registros de TEMPORAL_CPO_D **una vez** antes de insertar nuevos datos
        Static recordsDeleted As Boolean = False ' Verificar si ya se eliminó antes
        If Not recordsDeleted Then
            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If

                ' 1. Eliminar todos los registros de TEMPORAL_CPO_D
                Dim queryDelete As String = "DELETE FROM TEMPORAL_CPO_D"
                Using commandDelete As New SqlClient.SqlCommand(queryDelete, conexion)
                    commandDelete.ExecuteNonQuery()
                End Using

                ' Marcar que ya se eliminó para no volver a hacerlo en esta sesión de inserciones
                recordsDeleted = True
            Catch ex As Exception
                MessageBox.Show("Error al eliminar los registros de TEMPORAL_CPO_D: " & ex.Message)
                Return
            End Try
        End If

        ' Iniciar la transacción para insertar el registro
        Dim transaction As SqlClient.SqlTransaction = Nothing
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            ' Iniciar la transacción
            transaction = conexion.BeginTransaction()

            ' 2. Insertar el nuevo registro en TEMPORAL_CPO_D
            Dim queryInsert As String = "
            INSERT INTO TEMPORAL_CPO_D (CPO, ESTILO, COLOR, TALLA, UNIDADES, TOTAL, ESTADO, DESTINO, VENDEDOR, COMISION, ESCALA, MINIMO_P, MAXIMO_P, PRECIO) 
            VALUES (@CPO, @Estilo, @Color, @Talla, @Unidades, @Total, @Estado, @Destino, @Vendedor, @Comision, @Escala, @MinimoP, @MaximoP, @Precio)"

            Using commandInsert As New SqlClient.SqlCommand(queryInsert, conexion, transaction)
                ' Asignar los valores a los parámetros para evitar SQL injection
                commandInsert.Parameters.AddWithValue("@CPO", cpo)
                commandInsert.Parameters.AddWithValue("@Estilo", estilo)
                commandInsert.Parameters.AddWithValue("@Color", color)
                commandInsert.Parameters.AddWithValue("@Talla", talla)
                commandInsert.Parameters.AddWithValue("@Unidades", unidades)
                commandInsert.Parameters.AddWithValue("@Total", total)
                commandInsert.Parameters.AddWithValue("@Estado", estado)
                commandInsert.Parameters.AddWithValue("@Destino", destino)
                commandInsert.Parameters.AddWithValue("@Vendedor", vendedor)
                commandInsert.Parameters.AddWithValue("@Comision", comision)
                commandInsert.Parameters.AddWithValue("@Escala", escala)
                commandInsert.Parameters.AddWithValue("@MinimoP", minimoP)
                commandInsert.Parameters.AddWithValue("@MaximoP", maximoP)
                commandInsert.Parameters.AddWithValue("@Precio", precio)

                ' Ejecutar la inserción
                commandInsert.ExecuteNonQuery()
            End Using

            ' Confirmar la transacción si todo fue exitoso
            transaction.Commit()

        Catch ex As Exception
            ' Si ocurre un error, revertir la transacción
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MessageBox.Show("Error al insertar datos: " & ex.Message)
        Finally
            ' Asegurarse de cerrar la conexión
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub



    ' Método para liberar objetos COM (requerido al usar Interop)
    Private Sub ReleaseObject(obj As Object)
        Try
            If obj IsNot Nothing Then
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    ' Declarar las conexiones de la base de datos
    Dim e(2) As String
    Dim constr(2) As String

    ' Función para llenar conexiones de la base de datos
    Private Sub llena_conexiones()
        e(0) = "inventarios"
        e(1) = "TRECENTO"
        e(2) = "zuntex"

        For i As Integer = 0 To 2
            constr(i) = "Data Source=192.9.200.3\JT;initial catalog=" & e(i) & ";User id=user_e;Password=Ga2412_e"
        Next
    End Sub

    ' Método para insertar los datos en la tabla CPO_COSTO
    Private Sub InsertarDatosCPOCosto(ByVal conexion As SqlClient.SqlConnection)
        Dim query As String = "
INSERT INTO CPO_COSTO (CPO, ESTILO, COLOR, C1, C2, C3, C4, C5, C6, C7, C8, C9, C0)
SELECT 
    CPO, 
    ESTILO, 
    COLOR,
    MAX(CAST(CASE WHEN TALLA = '1' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C1,
    MAX(CAST(CASE WHEN TALLA = '2' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C2,
    MAX(CAST(CASE WHEN TALLA = '3' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C3,
    MAX(CAST(CASE WHEN TALLA = '4' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C4,
    MAX(CAST(CASE WHEN TALLA = '5' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C5,
    MAX(CAST(CASE WHEN TALLA = '6' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C6,
    MAX(CAST(CASE WHEN TALLA = '7' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C7,
    MAX(CAST(CASE WHEN TALLA = '8' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C8,
    MAX(CAST(CASE WHEN TALLA = '9' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C9,
    MAX(CAST(CASE WHEN TALLA = '10' THEN PRECIO ELSE '0.00' END AS DECIMAL(10, 2))) AS C0
FROM TEMPORAL_CPO_D
GROUP BY CPO, ESTILO, COLOR;


"

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, conexion)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message)
        End Try
    End Sub


    ' Método para insertar los datos en la tabla CPO_D
    Private Sub InsertarDatosCPOD(ByVal conexion As SqlClient.SqlConnection)
        ' Obtener la fecha seleccionada del DateTimePicker
        Dim fechaPrometida As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Dim query As String = "
    INSERT INTO CPO_D (CPO, ESTILO, COLOR, XS, S, M, L, XL, XL2, XL3, XL4, XL5, XL6, TOTAL, ESTADO, F_ENTREGA, F_PROMETIDA, DESTINO, F_INGRESO, VENDEDOR, COMISION, ESCALA, MINIMO_P, MAXIMO_P)
    SELECT 
        CPO, 
        ESTILO, 
        COLOR,
        SUM(CAST(CASE WHEN TALLA = '1' THEN UNIDADES ELSE '0' END AS INT)) AS XS,
        SUM(CAST(CASE WHEN TALLA = '2' THEN UNIDADES ELSE '0' END AS INT)) AS S,
        SUM(CAST(CASE WHEN TALLA = '3' THEN UNIDADES ELSE '0' END AS INT)) AS M,
        SUM(CAST(CASE WHEN TALLA = '4' THEN UNIDADES ELSE '0' END AS INT)) AS L,
        SUM(CAST(CASE WHEN TALLA = '5' THEN UNIDADES ELSE '0' END AS INT)) AS XL,
        SUM(CAST(CASE WHEN TALLA = '6' THEN UNIDADES ELSE '0' END AS INT)) AS XL2,
        SUM(CAST(CASE WHEN TALLA = '7' THEN UNIDADES ELSE '0' END AS INT)) AS XL3,
        SUM(CAST(CASE WHEN TALLA = '8' THEN UNIDADES ELSE '0' END AS INT)) AS XL4,
        SUM(CAST(CASE WHEN TALLA = '9' THEN UNIDADES ELSE '0' END AS INT)) AS XL5,
        SUM(CAST(CASE WHEN TALLA = '10' THEN UNIDADES ELSE '0' END AS INT)) AS XL6,
        SUM(CAST(UNIDADES AS INT)) AS TOTAL,
        ESTADO AS ESTADO,
        '" & fechaPrometida & "' AS F_ENTREGA,
        '" & fechaPrometida & "' AS F_PROMETIDA,
        DESTINO, 
        GETDATE() AS F_INGRESO,
        VENDEDOR AS VENDEDOR,
        COMISION AS COMISION,
        ESCALA AS ESCALA,
        MINIMO_P AS MINIMO_P,
        MAXIMO_P AS MAXIMO_P
    FROM TEMPORAL_CPO_D
    GROUP BY CPO, ESTILO, COLOR, ESTADO, DESTINO, VENDEDOR, COMISION, ESCALA, MINIMO_P, MAXIMO_P;
    "

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, conexion)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message)
        End Try
    End Sub


    ' Método para insertar los datos en la tabla CPO con el cliente seleccionado
    Private Sub InsertarDatosCPO(ByVal conexion As SqlClient.SqlConnection, clienteSeleccionado As String)
        ' Obtener la fecha seleccionada del DateTimePicker
        Dim fechaPrometida As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        Dim query As String = "
    INSERT INTO CPO (CPO, CLIENTE, F_PEDIDO, F_ENTREGA, PEDIDO, BOM)
    SELECT 
        CPO,  
        @Cliente AS CLIENTE,
        FORMAT(GETDATE(), 'yyyy-MM-d') AS F_PEDIDO,
        '" & fechaPrometida & "' AS F_ENTREGA,
        SUM(TOTAL) AS PEDIDO,
        '0' AS BOM
    FROM TEMPORAL_CPO_D
    GROUP BY CPO;"

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, conexion)
                ' Agregar el cliente como parámetro
                command.Parameters.AddWithValue("@Cliente", clienteSeleccionado)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message)
        End Try
    End Sub

    ' Evento que se ejecuta cuando se hace clic en el botón "Finalizar"
    Private Sub Boton_Finalizar_Click(sender As Object, e As EventArgs) Handles Finalizar.Click
        ' Verificar si se ha seleccionado un cliente
        If ComboBox1.SelectedIndex = 0 Or ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("No has seleccionado un cliente.")
            Return
        End If

        ' Primero llenamos las conexiones
        Dim conexion As SqlClient.SqlConnection = Nothing
        def_sql(conexion) ' Aquí obtienes la conexión correcta para la base de datos actual

        ' Ejecutamos las inserciones en el orden correcto
        Dim clienteSeleccionado As String = ComboBox1.SelectedItem.ToString()

        ' 3. Insertar datos en la tabla CPO_D
        InsertarDatosCPO(conexion, clienteSeleccionado)

        InsertarDatosCPOD(conexion)

        ' 2. Insertar datos en la tabla CPO_COSTO
        InsertarDatosCPOCosto(conexion)

        ' 1. Insertar datos en la tabla CPO


        ' Eliminar los datos de la tabla TEMPORAL_CPO_D antes de mostrar el mensaje
        Dim queryDelete As String = "DELETE FROM TEMPORAL_CPO_D"

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Using command As New SqlClient.SqlCommand(queryDelete, conexion)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar los datos de TEMPORAL_CPO_D: " & ex.Message)
            Return ' Si hay un error, salir del procedimiento
        End Try

        ' Mensaje de confirmación solo después de borrar los datos
        MessageBox.Show("Datos insertados correctamente en CPO, CPO_COSTO y CPO_D.")

        ' Cerrar la pantalla después del mensaje
        Me.Close()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    ' Función para verificar si la pantalla está en uso en la base de datos inventarios
    Private Function VerificarPantallaEnUso(pantalla As String) As Boolean
        Dim enUso As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM [inventarios].[dbo].[ControlDePantalla] WHERE Pantalla = @Pantalla AND EnUso = 1"

        Dim cnn As SqlClient.SqlConnection
        ' Aquí debes asegurarte de conectarte siempre a la base de datos 'inventarios'
        def_sql_inventarios(cnn)

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, cnn)
                command.Parameters.AddWithValue("@Pantalla", pantalla)
                enUso = Convert.ToInt32(command.ExecuteScalar()) > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al verificar si la pantalla está en uso: " & ex.Message)
        End Try

        Return enUso
    End Function

    ' Función para obtener el nombre del usuario que tiene bloqueada la pantalla en la base de datos inventarios
    Private Function ObtenerUsuarioBloqueo(pantalla As String) As String
        Dim nombreUsuario As String = String.Empty
        Dim query As String = "SELECT Usuario FROM [inventarios].[dbo].[ControlDePantalla] WHERE Pantalla = @Pantalla AND EnUso = 1"

        Dim cnn As SqlClient.SqlConnection
        ' Conexión a la base de datos 'inventarios'
        def_sql_inventarios(cnn)

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, cnn)
                command.Parameters.AddWithValue("@Pantalla", pantalla)
                nombreUsuario = command.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al obtener el usuario que bloquea la pantalla: " & ex.Message)
        End Try

        Return nombreUsuario
    End Function

    ' Función para bloquear la pantalla en la base de datos inventarios
    Private Sub BloquearPantalla(pantalla As String, usuario As String)
        Dim query As String = "INSERT INTO [inventarios].[dbo].[ControlDePantalla] (Pantalla, Usuario, EnUso) VALUES (@Pantalla, @Usuario, 1)"

        Dim cnn As SqlClient.SqlConnection
        ' Conexión a la base de datos 'inventarios'
        def_sql_inventarios(cnn)

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, cnn)
                command.Parameters.AddWithValue("@Pantalla", pantalla)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al bloquear la pantalla: " & ex.Message)
        End Try
    End Sub

    ' Función para desbloquear la pantalla en la base de datos inventarios
    Private Sub DesbloquearPantalla(pantalla As String, usuario As String)
        Dim query As String = "DELETE FROM [inventarios].[dbo].[ControlDePantalla] WHERE Pantalla = @Pantalla AND Usuario = @Usuario"

        Dim cnn As SqlClient.SqlConnection
        ' Conexión a la base de datos 'inventarios'
        def_sql_inventarios(cnn)

        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            Using command As New SqlClient.SqlCommand(query, cnn)
                command.Parameters.AddWithValue("@Pantalla", pantalla)
                command.Parameters.AddWithValue("@Usuario", usuario)
                command.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al desbloquear la pantalla: " & ex.Message)
        End Try
    End Sub


    ' Evento que se dispara cuando el formulario se está cerrando
    Private Sub Carga_de_cpos_masiva_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Desbloquear la pantalla cuando se cierra
        DesbloquearPantalla("Carga_de_cpos_masiva", usuarioActual)
    End Sub

End Class
