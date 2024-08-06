Imports C1.Win.C1FlexGrid
Imports System.Drawing.Printing
Imports System.IO
Public Class PA_SE_0
    Inherits System.Windows.Forms.Form
    Dim cnn As New SqlClient.SqlConnection()
    Dim strsql As String
    Dim path = "c:\reportes\prod_ad.xls"
    Dim filtro As New C1.Win.C1FlexGrid.ConditionFilter

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
    Friend WithEvents proceso As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents estado As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Impri As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PA_SE_0))
        Me.proceso = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Impri = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'proceso
        '
        Me.proceso.BackColor = System.Drawing.Color.White
        Me.proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceso.ForeColor = System.Drawing.Color.Black
        Me.proceso.Items.AddRange(New Object() {"Serigrafia", "Bordado"})
        Me.proceso.Location = New System.Drawing.Point(112, 8)
        Me.proceso.Name = "proceso"
        Me.proceso.Size = New System.Drawing.Size(164, 24)
        Me.proceso.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Proceso:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.fg.Location = New System.Drawing.Point(8, 48)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1008, 600)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.SubtotalPosition = C1.Win.C1FlexGrid.SubtotalPositionEnum.BelowData
        Me.fg.TabIndex = 76
        '
        'estado
        '
        Me.estado.BackColor = System.Drawing.Color.White
        Me.estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.ForeColor = System.Drawing.Color.Black
        Me.estado.Items.AddRange(New Object() {"Completo", "En Proceso"})
        Me.estado.Location = New System.Drawing.Point(520, 8)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(164, 24)
        Me.estado.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Estado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(808, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(35, 35)
        Me.Button3.TabIndex = 81
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Impri
        '
        Me.Impri.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Impri.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Impri.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impri.ForeColor = System.Drawing.Color.Black
        Me.Impri.Image = CType(resources.GetObject("Impri.Image"), System.Drawing.Image)
        Me.Impri.Location = New System.Drawing.Point(760, 8)
        Me.Impri.Name = "Impri"
        Me.Impri.Size = New System.Drawing.Size(35, 35)
        Me.Impri.TabIndex = 80
        Me.Impri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Impri.UseVisualStyleBackColor = False
        '
        'PA_SE_0
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Impri)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.proceso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PA_SE_0"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prendas con Procesos Adicionales"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PA_SE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.Width = Me.Width - 30
        fg.Height = Me.Height - 100
        fg.Rows(0).Height = 30
        Try
            filtro.Condition1.Operator = ConditionOperator.Contains
            fg.Cols(3).Filter = filtro
            fg.ApplyFilters()
        Catch
        End Try
        Try
            proceso.SelectedIndex = 0
            estado.SelectedIndex = 0
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        llena_grid()
    End Sub


    Private Sub llena_grid()
        Dim dt As New DataTable
        Dim strsql As String
        Dim dr As DataRow
        Dim p As Decimal
        strsql = "SELECT * FROM CORTES_PA LEFT JOIN CORTES ON CORTES_PA.CORTE = CORTES.CORTE LEFT JOIN ESTILOS ON CORTES.ESTILO = ESTILOS.ESTILO AND CORTES.CLIENTE = ESTILOS.CLIENTE LEFT JOIN CORTES_PAR ON CORTES_PA.CORTE = CORTES_PAR.CORTE AND CORTES_PA.PROCESO = CORTES_PAR.PROCESO AND CORTES_PAR.TIPO = 'Envio' WHERE CORTES_PA.PROCESO =  '" & proceso.Text & "' AND (SELECT COUNT(PRENDAS) FROM PROD_DIARIA WHERE PROD_DIARIA.CORTE = CORTES.CORTE) = 0 AND EXPORTADO = 'N'"
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = 1
        For Each dr In dt.Rows
            Try
                p = (dr("TOTAL_REC") / dr("TOTAL_ENV"))
            Catch
                p = 0
            End Try
            If estado.SelectedIndex > 0 Then
                If p < 0.9 Then
                    llena_registro(dr)
                End If
            Else
                If p > 0.9 Then
                    llena_registro(dr)
                End If
            End If
        Next
        subtotales()
    End Sub
    Private Sub subtotales()
        Try
            fg.Subtotal(AggregateEnum.Clear)
            fg.Subtotal(AggregateEnum.Sum, -1, -1, -1, fg.Cols("PRENDAS").Index, "TOTALON")
        Catch
        End Try
    End Sub



    Private Sub llena_registro(ByVal dr)
        Dim l As Integer = fg.Rows.Count
        fg.Rows.Count = l + 1
        fg(l, 1) = dr("CLIENTE")
        fg(l, 2) = dr("CORTE")
        fg(l, 3) = dr("CPO")
        fg(l, 4) = dr("ESTILO")
        fg(l, 5) = dr("COLOR")
        fg(l, 6) = dr("TOTAL_ENV")
        fg(l, 7) = dr("DESCRIPCION")
        fg(l, 8) = estado.Text
        fg(l, 9) = dr("LUGAR")
        fg(l, 10) = dr("FECHA")
        fg(l, 11) = dr("PROCESO")
    End Sub

    Private Sub proceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceso.SelectedIndexChanged
        Try
            llena_grid()
        Catch
        End Try
    End Sub

    Private Sub estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estado.SelectedIndexChanged
        llena_grid()
    End Sub

    Private Sub Impri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Impri.Click
        Print_fg()
    End Sub

    Private Sub Print_fg()
        Dim pd As PrintDocument
        Dim fecha As String
        Dim MAL As String = ""
        fecha = Format(Today, "dd/MM/yyyy")
        pd = fg.PrintParameters.PrintDocument()
        With pd.DefaultPageSettings
            .Landscape = True
            .Margins.Left = 20
            .Margins.Right = 50
            .Margins.Top = 50
            .Margins.Bottom = 50
        End With
        fg.PrintParameters.HeaderFont = New Font("Arial Narrow", 14, FontStyle.Bold)
        fg.PrintParameters.FooterFont = New Font("Arial Narrow", 12, FontStyle.Italic)
        fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog, "Reporte de Cortes con proceso de " & proceso.Text & " " & estado.Text & " al : " + fecha + "    " + MAL + Chr(9) + Chr(9) + "Pagina {0}", "")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ok As Boolean
        llena_hoja(ok)
        If ok Then
            MsgBox("Sus datos fueron trasladados a Excel en el directorio: " + path, MsgBoxStyle.OkOnly, "TRASLADO DE DATOS ")
            Close()
        End If
    End Sub

    Private Sub llena_hoja(ByRef ok As Boolean)
        Try
            If File.Exists(path) Then
                File.Delete(path)
            End If
            a_excel(fg, path, ok)
            System.Diagnostics.Process.Start(path)
            ok = True
        Catch
            MsgBox("Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, "Atencion ")
            ok = False
        End Try
    End Sub

    Private Sub fg_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim f As Integer = fg.RowSel
        If f > 0 Then
            Try
                Dim forma As New PA_SE1()
                forma.corte = fg(f, 2)
                forma.proceso = proceso.Text
                forma.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub fg_AfterFilter(sender As Object, e As System.EventArgs) Handles fg.AfterFilter
        subtotales()
    End Sub
End Class
