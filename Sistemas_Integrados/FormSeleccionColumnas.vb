Public Class FormSeleccionColumnas
    ' Agregar propiedades para cada columna que el usuario selecciona
    Public Property ColumnaCPO As Integer
    Public Property ColumnaEstilo As Integer
    Public Property ColumnaColor As Integer
    Public Property ColumnaTalla As Integer
    Public Property ColumnaUnidades As Integer
    Public Property ColumnaTotal As Integer
    Public Property ColumnaEstado As Integer
    Public Property ColumnaDestino As Integer
    Public Property ColumnaVendedor As Integer
    Public Property ColumnaComision As Integer
    Public Property ColumnaEscala As Integer
    Public Property ColumnaMinimoP As Integer
    Public Property ColumnaMaximoP As Integer
    Public Property ColumnaPrecio As Integer

    ' Declarar columnasDisponibles como variable de clase
    Private columnasDisponibles As List(Of String)

    ' Constructor que recibe las columnas disponibles
    Public Sub New(columnas As List(Of String))
        ' Esta llamada es necesaria para diseñar correctamente el formulario
        InitializeComponent()

        ' Asigna las columnas recibidas a la variable local
        columnasDisponibles = columnas

        ' Cargar las columnas en los ComboBox
        CargarColumnasEnComboBox()
    End Sub

    ' Cargar las columnas disponibles a los ComboBox con un "placeholder"
    Private Sub CargarColumnasEnComboBox()
        ComboBox1.Items.Add("CPO (Seleccionar Columna)")
        ComboBox1.Items.AddRange(columnasDisponibles.ToArray()) ' Para "CPO"

        ComboBox2.Items.Add("ESTILO (Seleccionar Columna)")
        ComboBox2.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Estilo"

        ComboBox3.Items.Add("COLOR (Seleccionar Columna)")
        ComboBox3.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Color"

        ComboBox4.Items.Add("TALLA (Seleccionar Columna)")
        ComboBox4.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Talla"

        ComboBox5.Items.Add("UNIDADES (Seleccionar Columna)")
        ComboBox5.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Unidades"

        ComboBox6.Items.Add("TOTAL (Seleccionar Columna)")
        ComboBox6.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Total"

        ComboBox7.Items.Add("ESTADO (Seleccionar Columna)")
        ComboBox7.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Estado"

        ComboBox8.Items.Add("DESTINO (Seleccionar Columna)")
        ComboBox8.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Destino"

        ComboBox9.Items.Add("VENDEDOR (Seleccionar Columna)")
        ComboBox9.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Vendedor"

        ComboBox10.Items.Add("COMISION (Seleccionar Columna)")
        ComboBox10.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Comision"

        ComboBox11.Items.Add("ESCALA (Seleccionar Columna)")
        ComboBox11.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Escala"

        ComboBox12.Items.Add("MIN_P (Seleccionar Columna)")
        ComboBox12.Items.AddRange(columnasDisponibles.ToArray()) ' Para "MinimoP"

        ComboBox13.Items.Add("MAX_P (Seleccionar Columna)")
        ComboBox13.Items.AddRange(columnasDisponibles.ToArray()) ' Para "MaximoP"

        ComboBox14.Items.Add("PRECIO (Seleccionar Columna)")
        ComboBox14.Items.AddRange(columnasDisponibles.ToArray()) ' Para "Precio"

        ' Seleccionar el primer elemento por defecto como "placeholder"
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 0
        ComboBox8.SelectedIndex = 0
        ComboBox9.SelectedIndex = 0
        ComboBox10.SelectedIndex = 0
        ComboBox11.SelectedIndex = 0
        ComboBox12.SelectedIndex = 0
        ComboBox13.SelectedIndex = 0
        ComboBox14.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Asignar el índice seleccionado en cada ComboBox a las propiedades correspondientes
        ColumnaCPO = ComboBox1.SelectedIndex + 1
        ColumnaEstilo = ComboBox2.SelectedIndex + 1
        ColumnaColor = ComboBox3.SelectedIndex + 1
        ColumnaTalla = ComboBox4.SelectedIndex + 1
        ColumnaUnidades = ComboBox5.SelectedIndex + 1
        ColumnaTotal = ComboBox6.SelectedIndex + 1
        ColumnaEstado = ComboBox7.SelectedIndex + 1
        ColumnaDestino = ComboBox8.SelectedIndex + 1
        ColumnaVendedor = ComboBox9.SelectedIndex + 1
        ColumnaComision = ComboBox10.SelectedIndex + 1
        ColumnaEscala = ComboBox11.SelectedIndex + 1
        ColumnaMinimoP = ComboBox12.SelectedIndex + 1
        ColumnaMaximoP = ComboBox13.SelectedIndex + 1
        ColumnaPrecio = ComboBox14.SelectedIndex + 1

        ' Mensaje de depuración para mostrar las columnas seleccionadas
        MessageBox.Show("Seleccionaste estas columnas: CPO: " & ColumnaCPO & ", Estilo: " & ColumnaEstilo & ", Color: " & ColumnaColor)

        ' Validación básica para asegurarte de que el usuario ha seleccionado alguna columna
        If ComboBox1.SelectedIndex = 0 Or ComboBox2.SelectedIndex = 0 Then
            MessageBox.Show("Por favor, selecciona las columnas correctas en los combos")
            Return
        End If

        ' Cerrar el formulario con resultado OK
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
