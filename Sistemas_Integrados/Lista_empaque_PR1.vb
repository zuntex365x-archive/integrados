Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Imports System.IO

Public Class Lista_empaque_PR1
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim dt As New DataTable()
    Dim dr As DataRow
    Dim strSQl As String
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Embarque As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents regresa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_empaque_PR1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Embarque = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.regresa = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Embarque
        '
        Me.Embarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Embarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Embarque.Location = New System.Drawing.Point(128, 8)
        Me.Embarque.Name = "Embarque"
        Me.Embarque.Size = New System.Drawing.Size(200, 28)
        Me.Embarque.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.Embarque, "Embarque.")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(920, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 79
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Presione este Boton para Desplegar la Consulta.")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.E1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.E1.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.Black
        Me.E1.Image = CType(resources.GetObject("E1.Image"), System.Drawing.Image)
        Me.E1.Location = New System.Drawing.Point(968, 8)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(35, 35)
        Me.E1.TabIndex = 82
        Me.E1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.E1, "Presione este Boton para Borrar los datos seleccionados.")
        Me.E1.UseVisualStyleBackColor = False
        '
        'regresa
        '
        Me.regresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.regresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.regresa.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresa.ForeColor = System.Drawing.Color.Black
        Me.regresa.Image = CType(resources.GetObject("regresa.Image"), System.Drawing.Image)
        Me.regresa.Location = New System.Drawing.Point(920, 8)
        Me.regresa.Name = "regresa"
        Me.regresa.Size = New System.Drawing.Size(35, 35)
        Me.regresa.TabIndex = 83
        Me.regresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.regresa, "Otro Embarque")
        Me.regresa.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Embarque:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.Location = New System.Drawing.Point(1, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 19
        Me.fg.Size = New System.Drawing.Size(1008, 632)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 80
        '
        'Lista_empaque_PR1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 696)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.regresa)
        Me.Controls.Add(Me.E1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Embarque)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lista_empaque_PR1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elimina Lista empque de Primeras"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Lista_empaque_3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Embarque.KeyPress, AddressOf keypressed1
        setea_fg()
        llena_empaque()
    End Sub

    Private Sub llena_empaque()
        llena_combos(Embarque, "SELECT DISTINCT EMBARQUE, FECHA FROM PACKING_E WHERE (FACTURADO IS NULL) OR (FACTURADO = 'N') AND EMBARQUE = CPO AND EMBARQUE LIKE 'JTP-%'ORDER BY FECHA DESC", "EMBARQUE")
        Try
            Embarque.SelectedIndex = 0
        Catch
        End Try
        Button2.Visible = True
        regresa.Visible = False
        E1.Visible = False
    End Sub

    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_fg()
        Dim dt As New DataTable()
        Dim l As Integer = 1
        strSQl = "SELECT * FROM PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "'"
        llena_tablas(dt, strSQl, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each Me.dr In dt.Rows
            fg(l, 1) = dr("CAJA")
            fg(l, 2) = dr("CPO")
            fg(l, 3) = dr("ESTILO")
            fg(l, 4) = dr("COLOR")
            fg(l, 5) = dr("TIPO")
            fg(l, 6) = dr("PRENDAS")
            l = l + 1
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        llena_fg()
        Button2.Visible = False
        regresa.Visible = True
        E1.Visible = True
    End Sub

    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        Dim seguro As MsgBoxResult
        Dim ok As Boolean = False
        seguro = MsgBox("Esta completamente seguro de Eliminar el Embarque?  ", MsgBoxStyle.YesNo, "Eliminación de Lista de Empaque (Completa) !!!")
        If seguro = MsgBoxResult.Yes Then
            elimina_datos()
            llena_empaque()
            setea_fg()
        End If
    End Sub

    Private Sub regresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regresa.Click
        llena_empaque()
        setea_fg()
    End Sub

    Private Sub keypressed1(ByVal o As [Object], ByVal e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            e.Handled = True
            If Trim(Embarque.Text) <> "" Then
                Button2.Focus()
            End If
        End If
    End Sub 'keypressed



    '=================================================================================
    '                        Elimina Lista de empaque
    '=================================================================================
    Private Sub elimina_datos()
        Dim j As Integer
        Dim strsql As String
        Dim afectados As Integer
        Dim tipo As String
        Dim destino As String = ""
        Dim talla As String = "XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6"
        Dim tallas As String = "XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL"
        Dim tl() As String = talla.Split("|")
        Dim ts() As String = tallas.Split("|")
        Dim pr(9) As Integer
        Dim se(9) As Integer
        Dim corte As String
        Dim dt As New DataTable()
        Dim estilo As String
        Dim colores As String

        strsql = "SELECT * FROM PACKING_D WHERE EMBARQUE  = '" & Embarque.Text & "'"
        llena_tablas(dt, strsql, cnn)

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE PACKING_C WHERE EMBARQUE = '" & Embarque.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE PACKING_E WHERE EMBARQUE = '" & Embarque.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE EMBARQUES WHERE EMBARQUE = '" & Embarque.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            strsql = "DELETE S_STOCK WHERE EMBARQUE = '" & Embarque.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            For Each Me.dr In dt.Rows
                tipo = "Pri"
                corte = dr("CORTE")
                estilo = dr("ESTILO")
                colores = dr("COLOR")
                ' ================ ACTUALIZA EMBARQUES ==============================
                strsql = "UPDATE CORTES_E SET P0 = P0 - " & dr(8) & ", P1 = P1 - " & dr(9) & ", P2 = P2 - " & dr(10) & ",P3 = P3 - " & dr(11) & _
                                            ", P4 = P4 - " & dr(12) & ", P5 = P5 - " & dr(13) & ", P6 = P6 - " & dr(14) & ", P7 = P7 - " & dr(15) & _
                                            ", P8 = P8 - " & dr(16) & ", P9 = P9 - " & dr(17) & " WHERE CORTE = '" & corte & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()

                '======================================= ACTUALIZA STOCK =============================
                For j = 8 To 17
                    If dr(j) > 0 Then
                        strsql = "UPDATE STOCK SET UNIDADES = UNIDADES + " & dr(j) & " WHERE ESTILO = '" & estilo & "' AND COLOR = '" & colores & "' AND TIPO = '00' AND TALLA = '" & ts(j - 8) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()

                        strsql = "UPDATE E_STOCK SET EXPORT = EXPORT - " & dr(j) & " WHERE CORTE = '" & corte & "' AND ESTILO = '" & estilo & "' AND COLOR = '" & colores & "' AND TIPO = '00' AND TALLA = '" & ts(j - 8) & "'"
                        comando.CommandText = strsql
                        afectados = comando.ExecuteNonQuery()
                    End If
                Next j
            Next

            strsql = "DELETE PACKING_D WHERE EMBARQUE = '" & Embarque.Text & "'"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()


            transaccion.Commit()

        Catch e As Exception
            Try
                transaccion.Rollback()
            Catch ex As SqlClient.SqlException
                If Not transaccion.Connection Is Nothing Then
                    MsgBox("Ocurrió un error de tipo " & ex.GetType().ToString() & _
                                      " se generó cuando se trato de eliminar la transacción.", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_empaque()
        setea_fg()
    End Sub
End Class



