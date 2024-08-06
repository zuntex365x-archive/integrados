Imports C1.Win.C1FlexGrid

Public Class Cajas31
    Inherits System.Windows.Forms.Form
    Dim dt As New DataTable
    Dim pr As New DataTable
    Dim ac As New DataTable
    Dim co As New DataTable
    Dim dr As DataRow
    Dim cnn As New SqlClient.SqlConnection()
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Dim fechas As String
    Friend WithEvents graba As System.Windows.Forms.Button
    Dim obj As New empresas
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajas31))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.graba = New System.Windows.Forms.Button()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.fg.Location = New System.Drawing.Point(8, 60)
        Me.fg.Name = "fg"
        Me.fg.Rows.DefaultSize = 19
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(1027, 613)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.fg, "Area de Datos.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(8, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 40)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'graba
        '
        Me.graba.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.graba.Font = New System.Drawing.Font("Comic Sans MS", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graba.ForeColor = System.Drawing.Color.Black
        Me.graba.Image = CType(resources.GetObject("graba.Image"), System.Drawing.Image)
        Me.graba.Location = New System.Drawing.Point(12, 9)
        Me.graba.Name = "graba"
        Me.graba.Size = New System.Drawing.Size(60, 40)
        Me.graba.TabIndex = 98
        Me.graba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.graba.UseVisualStyleBackColor = False
        '
        'Cajas31
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 696)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.graba)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cajas31"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza Producción al Plan de Costura"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Push05_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setea_fg()
    End Sub
    Private Sub setea_fg()
        fg.Rows.Count = 1
        fg.Rows(0).Height = 30
        fg.Cols(0).Width = 0
    End Sub
    Private Sub proceso()
        elimina_cortes()
        llena_fg()
    End Sub
    Private Sub llena_fg()
        ' Dim strsql As String = "SELECT CAJAS04.CORTE,CPO,ESTILO,COLOR,SUM(CAJAS04.UNIDADES) AS UNIDADES FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO WHERE CAJAS04.CORTE IN (SELECT CORTE FROM PLAN_COSTURA_C)  GROUP BY CAJAS04.CORTE,CPO,ESTILO,COLOR"
        Dim strsql As String = "SELECT X.CORTE,X.CPO,X.ESTILO,X.COLOR, SUM (X.C01) AS UNIDADES from (
                                SELECT CAJAS04.CORTE,CPO,ESTILO,COLOR,SUM(CAJAS01.UNIDADES) AS C01 
                                FROM CAJAS04 
	                                LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE 
	                                LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS01.CORTE = CAJAS04.CORTE AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS01.TIPO 
                                WHERE CAJAS04.CORTE IN (SELECT CORTE FROM PLAN_COSTURA_C)  
                                GROUP BY CAJAS04.CORTE,CPO,ESTILO,COLOR
                                UNION ALL
                                SELECT CAJAS04.CORTE,CPO,ESTILO,COLOR,SUM(CAJAS05.UNIDADES) AS C01
                                FROM CAJAS04 
	                                LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE 
	                                LEFT JOIN CAJAS05 ON CAJAS04.CAJA = CAJAS05.CAJA AND CAJAS05.CORTE = CAJAS04.CORTE AND CAJAS05.TALLA =  CAJAS04.TALLA AND CAJAS04.TIPO = CAJAS05.TIPO 
                                WHERE CAJAS04.CORTE IN (SELECT CORTE FROM PLAN_COSTURA_C)  
                                GROUP BY CAJAS04.CORTE,CPO,ESTILO,COLOR
                                ) AS X
                                GROUP BY X.CORTE,X.CPO,X.ESTILO,X.COLOR"
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim l As Integer = 1
        llena_tablas(dt, strsql, cnn)
        fg.Rows.Count = dt.Rows.Count + 1
        For Each dr In dt.Rows
            fg(l, 1) = dr("CORTE")
            fg(l, 2) = dr("CPO")
            fg(l, 3) = dr("ESTILO")
            fg(l, 4) = dr("COLOR")
            fg(l, 5) = dr("UNIDADES")
            l = l + 1
        Next
    End Sub
  
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        proceso()
        Button1.Visible = False
        graba.Visible = True
    End Sub


    Private Sub graba_Click(sender As System.Object, e As System.EventArgs) Handles graba.Click
        GRABA_DATOS()
        Close()
    End Sub


    Private Sub elimina_cortes()
        Dim strsql As String
        Dim afectados As Integer
        cnn.ConnectionString = obj.constr

        cnn.Open()
        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            strsql = "DELETE PLAN_COSTURA_C WHERE (SELECT SUM(PRENDAS) FROM PROD_DIARIA WHERE CORTE = PLAN_COSTURA_C.CORTE) IS NOT NULL"
            comando.CommandText = strsql
            afectados = comando.ExecuteNonQuery()

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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

    Private Sub graba_datos()
        Dim strsql As String
        Dim afectados As Integer
        Dim i As Integer

        cnn.Open()

        ' Comienza la transacción
        Dim transaccion As SqlClient.SqlTransaction = cnn.BeginTransaction()

        ' Crea el comando para la transacción
        Dim comando As SqlClient.SqlCommand = cnn.CreateCommand()
        comando.Transaction = transaccion

        Try
            For i = 1 To fg.Rows.Count - 1
                strsql = "UPDATE PLAN_COSTURA_C SET PRODUCIDAS = '" & fg(i, 5) & "' WHERE CORTE = '" & fg(i, 1) & "'"
                comando.CommandText = strsql
                afectados = comando.ExecuteNonQuery()
            Next

            transaccion.Commit()

        Catch e As Exception
            Try
                MsgBox("Inconsistencia en Datos", MsgBoxStyle.Critical, "Por favor revise !!!!")
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
End Class
