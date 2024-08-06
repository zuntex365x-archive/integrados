Imports C1.Win.C1FlexGrid
Imports System.IO
Imports System.Drawing.Printing
Imports System.Collections.Specialized
Imports C1.C1Excel
Imports System.Threading

Public Class inv_telas02
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents lector As System.Windows.Forms.Button
    Friend WithEvents Graba As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lec As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inv_telas02))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lector = New System.Windows.Forms.Button()
        Me.Graba = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lec = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lector
        '
        Me.lector.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lector.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lector.ForeColor = System.Drawing.Color.Black
        Me.lector.Image = CType(resources.GetObject("lector.Image"), System.Drawing.Image)
        Me.lector.Location = New System.Drawing.Point(269, 4)
        Me.lector.Name = "lector"
        Me.lector.Size = New System.Drawing.Size(60, 40)
        Me.lector.TabIndex = 52
        Me.lector.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.lector, "Presione este Boton para descargar Datos del Lector.")
        Me.lector.UseVisualStyleBackColor = False
        '
        'Graba
        '
        Me.Graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Graba.ForeColor = System.Drawing.Color.Black
        Me.Graba.Image = CType(resources.GetObject("Graba.Image"), System.Drawing.Image)
        Me.Graba.Location = New System.Drawing.Point(269, 3)
        Me.Graba.Name = "Graba"
        Me.Graba.Size = New System.Drawing.Size(60, 40)
        Me.Graba.TabIndex = 68
        Me.Graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Graba, "Actualiza Ubicaciones")
        Me.Graba.UseVisualStyleBackColor = False
        Me.Graba.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(269, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 40)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "C"
        Me.ToolTip1.SetToolTip(Me.Button1, "Presione este Boton para continuar con el proceso de Actualización")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free
        Me.fg.AutoGenerateColumns = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 49)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.fg.Size = New System.Drawing.Size(1061, 639)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 23
        '
        'lec
        '
        Me.lec.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lec.IntegralHeight = False
        Me.lec.Items.AddRange(New Object() {"L01", "L02", "L03", "L04", "L05", "L06", "L07", "L08", "L09", "L10", "L11", "L12", "L13", "L14", "L15", "L16", "L17", "L18", "L19", "L20"})
        Me.lec.Location = New System.Drawing.Point(128, 17)
        Me.lec.MaxLength = 10
        Me.lec.Name = "lec"
        Me.lec.Size = New System.Drawing.Size(106, 24)
        Me.lec.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Lector No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'inv_telas02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 700)
        Me.Controls.Add(Me.lec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lector)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Graba)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inv_telas02"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copia Datos del Lector"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim h As String = "##,###,##0.00"
    Dim strsql As String
    Dim cnn As New SqlClient.SqlConnection()
    Dim obj As New empresas()
    Dim usuario As String = obj.usuario
    Dim path = "c:\telas\ubica"
    Dim codigos As String = ""
    Dim ruta As String
    Private Sub Inventario_fis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_grid()
        lec.SelectedIndex = 0
        crea_sub_inventario(ruta)
    End Sub

    Private Sub setea_grid()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
    End Sub

    Private Sub llena_grid()
        Dim dt As New DataTable()
        Dim dr As DataRow
        Dim dd As DataRow()
        Dim l As Integer = 1
        strsql = "SELECT * FROM ROLLOS WHERE BARRA IN (" & codigos & ") ORDER BY BATCH,ROLLO"
        llena_tablas(dt, strsql, cnn)
        For l = 1 To fg.Rows.Count - 1
            dd = dt.Select("BARRA = '" & fg(l, 2) & "'")
            If dd.Length > 0 Then
                dr = dd(0)
                fg(l, 3) = dr("BATCH")
                fg(l, 4) = dr("ROLLO")
                fg(l, 5) = dr("KNIT")
                fg(l, 6) = dr("COLOR")
                fg(l, 7) = dr("YARDAS")
            End If
        Next
        fg.Sort(SortFlags.Ascending, 3)
        Do While fg(1, 3) = ""
            fg.Rows.Remove(1)
        Loop

    End Sub

    Private Sub lector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lector.Click
        Dim forma As New HJ6300()
        forma.motor = "ubica.txt"
        Try
            File.Delete(path)
        Catch
        End Try
        forma.ShowDialog()
        lector.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub procesa_descarga()
        Thread.Sleep(3000)
        Dim l As Integer = 1
        Dim c As Integer
        Dim ubica As String
        Dim dg As New OpenFileDialog
        Dim archivo As String = path
        Dim sr As New StreamReader(archivo)
        Dim codigo As String
        Dim lineast As String
        Cursor = Cursors.WaitCursor
        fg.Rows.Count = 2000
        Do
            lineast = sr.ReadLine()
            If lineast <> Nothing Then
                If lineast.Length > 0 Then

                    lineast = lineast
                    c = lineast.IndexOf(",")
                    codigo = Mid(lineast, 1, c)
                    ubica = Mid(lineast, c + 2)
                    fg(l, 2) = codigo
                    fg(l, 1) = ubica
                    If codigos.IndexOf(codigo) < 0 Then
                        codigos = codigos + "'" & codigo & "',"
                    End If
                    l = l + 1
                End If
            End If
        Loop Until lineast Is Nothing
        sr.Close()
        If codigos.Length > 0 Then
            fg.Rows.Count = l
            codigos = Mid(codigos, 1, codigos.Length - 1)
            llena_grid()
        End If
    End Sub

    Private Sub Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graba.Click
        Dim ok As Boolean
        Dim forma As New HJ6300()
        If fg.Rows.Count > 1 Then
            Dim seguro As MsgBoxResult
            seguro = MsgBox("Está completamente seguro de querer guardar los datos del Lector", MsgBoxStyle.YesNo, "Graba Datos del Lector")
            If seguro = MsgBoxResult.Yes Then
                copia_datos(ok)
                If ok Then
                    Close()
                End If
            End If
        Else
            MsgBox("Al menos debe haber un rollo para Actualizar", MsgBoxStyle.Critical, "Por favor revise !!!!")
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            procesa_descarga()
        Catch
        End Try
        Cursor = Cursors.Default
        Graba.Visible = True
    End Sub

    Private Sub corte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lec.KeyPress
        AutoCompletar(lec, e)
    End Sub

    Private Sub copia_datos(ByRef ok As Boolean)
        Dim archivo As String = ruta + "\" + lec.Text + "_" + Format(Now, "yyyy_MM_dd_HH_mm_ss")
        Dim forma As New HJ6300()
        ok = False
        Try
            If Not Directory.Exists(ruta) Then
                Directory.CreateDirectory(ruta)
            End If
        Catch ex As Exception
        End Try
        Try
            File.Copy(path, archivo)
            Cursor = Cursors.WaitCursor
            forma.motor = "ubica_d.txt"
            forma.ShowDialog()
            Cursor = Cursors.Default
            ok = True
        Catch ex As Exception
            MsgBox("Error al Copiar Archivo", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
