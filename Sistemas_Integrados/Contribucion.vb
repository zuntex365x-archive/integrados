Imports System.Data.SqlClient
Imports C1.Win.C1FlexGrid
Imports System.IO

Public Class Contribucion
    Inherits System.Windows.Forms.Form

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonExport As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Public Sub New()
        MyBase.New()
        ' Este método de llamada es requerido por el diseñador de formularios de Windows Forms.
        InitializeComponent()
    End Sub

    ' Método requerido por el diseñador de Windows Forms
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DataGridView1.Location = New System.Drawing.Point(12, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1566, 678)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(476, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ejecutar Script"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonExport
        '
        Me.ButtonExport.Location = New System.Drawing.Point(586, 11)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(100, 23)
        Me.ButtonExport.TabIndex = 6
        Me.ButtonExport.Text = "Exportar a Excel"
        Me.ButtonExport.UseVisualStyleBackColor = True
        AddHandler Me.ButtonExport.Click, AddressOf Me.ButtonExport_Click
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        AddHandler Me.TextBox1.TextChanged, AddressOf Me.TextBox_TextChanged
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(355, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        AddHandler Me.TextBox2.TextChanged, AddressOf Me.TextBox_TextChanged
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Planilla Texsun y Innotex:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(249, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Planilla Texfor:"
        '
        'Contribucion
        '
        Me.ClientSize = New System.Drawing.Size(1595, 792)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Contribucion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Evento Click del botón
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EjecutarScriptYMostrar()
    End Sub

    ' Método para restringir la entrada a números solamente
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancela el evento si no es un número
        End If
    End Sub

    ' Método para verificar si ambos TextBox tienen datos
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Button1.Enabled = Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBox2.Text)
    End Sub

    ' Método para ejecutar el script SQL y mostrar los resultados en el DataGridView
    Private Sub EjecutarScriptYMostrar()
        Dim connectionString As String = "Data Source=192.9.200.3\TEXSUN;Initial Catalog=planilla;User ID=sa;Password=Messi19!"
        Dim num1 As String = TextBox1.Text
        Dim num2 As String = TextBox2.Text

        ' Script SQL a ejecutar
        Dim query As String = "
-- ESTE SCRIPT SE EJECUTA EN EL SERVIDOR TEXSUN Y BASE DE DATOS PLANILLA

use planilla

-- PASO 1: Verificar y eliminar si las tablas temporales existen
IF OBJECT_ID('tempdb..#ContribucionTexsunYTexfor') IS NOT NULL DROP TABLE #ContribucionTexsunYTexfor;
IF OBJECT_ID('tempdb..#PrendasTemporal') IS NOT NULL DROP TABLE #PrendasTemporal;
IF OBJECT_ID('tempdb..#PromedioDiarioTemporal') IS NOT NULL DROP TABLE #PromedioDiarioTemporal;
IF OBJECT_ID('tempdb..#PrendasPorOperarioTemporal') IS NOT NULL DROP TABLE #PrendasPorOperarioTemporal;
IF OBJECT_ID('tempdb..#FacturacionPorOperarioTemporal') IS NOT NULL DROP TABLE #FacturacionPorOperarioTemporal;
IF OBJECT_ID('tempdb..#OperariosTemporal') IS NOT NULL DROP TABLE #OperariosTemporal;
IF OBJECT_ID('tempdb..#SueldoTemporal') IS NOT NULL DROP TABLE #SueldoTemporal;
IF OBJECT_ID('tempdb..#HorasExtrasTemporal') IS NOT NULL DROP TABLE #HorasExtrasTemporal;
IF OBJECT_ID('tempdb..#BonificacionTemporal') IS NOT NULL DROP TABLE #BonificacionTemporal;
IF OBJECT_ID('tempdb..#BonificacionProduccionTemporal') IS NOT NULL DROP TABLE #BonificacionProduccionTemporal;
IF OBJECT_ID('tempdb..#PrestacionesLeyTemporal') IS NOT NULL DROP TABLE #PrestacionesLeyTemporal;
IF OBJECT_ID('tempdb..#TotalTemporal') IS NOT NULL DROP TABLE #TotalTemporal;
IF OBJECT_ID('tempdb..#CostoPorOperarioTemporal') IS NOT NULL DROP TABLE #CostoPorOperarioTemporal;
IF OBJECT_ID('tempdb..#CostoQTemporal') IS NOT NULL DROP TABLE #CostoQTemporal;
IF OBJECT_ID('tempdb..#CostoDolarTemporal') IS NOT NULL DROP TABLE #CostoDolarTemporal;
IF OBJECT_ID('tempdb..#PrecioUnitarioDolarTemporal') IS NOT NULL DROP TABLE #PrecioUnitarioDolarTemporal;
IF OBJECT_ID('tempdb..#CostoPorPrecioTemporal') IS NOT NULL DROP TABLE #CostoPorPrecioTemporal;
IF OBJECT_ID('tempdb..#AportacionUnitariaTemporal') IS NOT NULL DROP TABLE #AportacionUnitariaTemporal;
IF OBJECT_ID('tempdb..#TotalContribucionTemporal') IS NOT NULL DROP TABLE #TotalContribucionTemporal;


-- PASO 2: INICIO DE GENERACION DEL REPORTE DE CONTRIBUCIONES 

DECLARE @fec_inicio DATE, @fec_final DATE;

-- Obtener fechas de ciclo de planilla
SELECT 
    @fec_inicio = fec_inicio, 
    @fec_final = fec_final
FROM 
    TB_CICLO_PLANILLA 
WHERE 
    num_planilla = @planilla_texsun_innotex;

DECLARE @tipo_cambio DECIMAL(18,4);

SELECT 
    @tipo_cambio = TIPO_CAMBIO
FROM 
    PLANILLAS
WHERE 
    PLANILLA = @planilla_texsun_innotex AND FECHA_FINAL = @fec_final;

-- Fila 'PRENDAS PRODUCIDAS'
SELECT
    'PRENDAS PRODUCIDAS' AS DATO,
    SUM(CASE WHEN P.SECCION = 'A' THEN P.PRENDAS ELSE 0 END) AS A,
    SUM(CASE WHEN P.SECCION = 'B' THEN P.PRENDAS ELSE 0 END) AS B,
    SUM(CASE WHEN P.SECCION = 'C' THEN P.PRENDAS ELSE 0 END) AS C,
    SUM(CASE WHEN P.SECCION = 'D' THEN P.PRENDAS ELSE 0 END) AS D,
    SUM(CASE WHEN P.SECCION = 'TF_D' THEN P.PRENDAS ELSE 0 END) AS TF_D,
    SUM(CASE WHEN P.SECCION = 'E' THEN P.PRENDAS ELSE 0 END) AS E,
    SUM(CASE WHEN P.SECCION = 'F' THEN P.PRENDAS ELSE 0 END) AS F,
    SUM(CASE WHEN P.SECCION = 'G' THEN P.PRENDAS ELSE 0 END) AS G,
    SUM(CASE WHEN P.SECCION = 'H' THEN P.PRENDAS ELSE 0 END) AS H,
    SUM(CASE WHEN P.SECCION = 'I' THEN P.PRENDAS ELSE 0 END) AS I,
    SUM(CASE WHEN P.SECCION = 'J' THEN P.PRENDAS ELSE 0 END) AS J,
    SUM(CASE WHEN P.SECCION = 'K' THEN P.PRENDAS ELSE 0 END) AS K,
    SUM(CASE WHEN P.SECCION = 'M' THEN P.PRENDAS ELSE 0 END) AS M,
    SUM(CASE WHEN P.SECCION = 'N' THEN P.PRENDAS ELSE 0 END) AS N,
    SUM(CASE WHEN P.SECCION = 'O' THEN P.PRENDAS ELSE 0 END) AS O,
    SUM(CASE WHEN P.SECCION = 'O' THEN P.PRENDAS ELSE 0 END) AS TF_O,
    SUM(CASE WHEN P.SECCION = 'P' THEN P.PRENDAS ELSE 0 END) AS P,
    SUM(CASE WHEN P.SECCION = 'Q' THEN P.PRENDAS ELSE 0 END) AS Q,
    SUM(CASE WHEN P.SECCION = 'TF_Q' THEN P.PRENDAS ELSE 0 END) AS TF_Q,
    SUM(CASE WHEN P.SECCION = 'R' THEN P.PRENDAS ELSE 0 END) AS R,
    SUM(CASE WHEN P.SECCION = 'T' THEN P.PRENDAS ELSE 0 END) AS T,
    SUM(CASE WHEN P.SECCION = 'TF_T' THEN P.PRENDAS ELSE 0 END) AS TF_T,
    SUM(CASE WHEN P.SECCION = 'U' THEN P.PRENDAS ELSE 0 END) AS U,
    SUM(CASE WHEN P.SECCION = 'TF_U' THEN P.PRENDAS ELSE 0 END) AS TF_U,
    SUM(CASE WHEN P.SECCION = 'W' THEN P.PRENDAS ELSE 0 END) AS W,
	SUM(CASE WHEN P.SECCION = 'TF_W' THEN P.PRENDAS ELSE 0 END) AS TF_W,
	SUM(CASE WHEN P.SECCION = 'IN_A' THEN P.PRENDAS ELSE 0 END) AS IN_A,
    SUM(CASE WHEN P.SECCION = 'IN_B' THEN P.PRENDAS ELSE 0 END) AS IN_B,
    SUM(CASE WHEN P.SECCION = 'IN_C' THEN P.PRENDAS ELSE 0 END) AS IN_C,
    SUM(CASE WHEN P.SECCION = 'IN_D' THEN P.PRENDAS ELSE 0 END) AS IN_D,
    SUM(CASE WHEN P.SECCION = 'IN_E' THEN P.PRENDAS ELSE 0 END) AS IN_E,
    SUM(CASE WHEN P.SECCION = 'IN_F' THEN P.PRENDAS ELSE 0 END) AS IN_F,
    SUM(CASE WHEN P.SECCION = 'IN_H' THEN P.PRENDAS ELSE 0 END) AS IN_H,
    SUM(CASE WHEN P.SECCION = 'IN_I' THEN P.PRENDAS ELSE 0 END) AS IN_I,
    SUM(CASE WHEN P.SECCION = 'IN_J' THEN P.PRENDAS ELSE 0 END) AS IN_J,
    SUM(CASE WHEN P.SECCION = 'IN_K' THEN P.PRENDAS ELSE 0 END) AS IN_K,
    SUM(CASE WHEN P.SECCION = 'IN_M' THEN P.PRENDAS ELSE 0 END) AS IN_M,
    SUM(CASE WHEN P.SECCION = 'IN_O' THEN P.PRENDAS ELSE 0 END) AS IN_O,
    SUM(
        CASE 
            WHEN P.SECCION IN (
                'A', 'B', 'C', 'D', 'TF_D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'P', 'Q', 'TF_Q', 'R', 
                'T', 'TF_T', 'U', 'TF_U', 'W', 'TF_W', 'IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 
                'IN_J', 'IN_K', 'IN_M', 'IN_O'
            ) THEN P.PRENDAS 
            ELSE 0 
        END
    ) AS TOTAL
INTO #PrendasTemporal
FROM 
    [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P
WHERE 
    P.FECHA BETWEEN @fec_inicio AND @fec_final;



-- Fila 'SUELDOS Q.'
SELECT
    'SUELDOS Q.' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T1.SECCION = 'G-2' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T1.SECCION = 'G-3' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T1.SECCION = 'G-4' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS
        WHEN T2.SECCION = 'XG-2' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS
        WHEN T2.SECCION = 'XG-3' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        WHEN T2.SECCION = 'XG-4' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' THEN T1.SUELDOS 
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' THEN T1.SUELDOS 
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.SUELDOS 
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN T2.SUELDOS 
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' THEN T1.SUELDOS 
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' THEN T1.SUELDOS 
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' THEN T1.SUELDOS 
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' THEN T2.SUELDOS 
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.SUELDOS 
        ELSE 0 
    END) AS IN_O,
	SUM(
    CASE 
        WHEN (T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z') AND T1.PLANILLA = @planilla_texsun_innotex) 
        OR (T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y') AND T2.PLANILLA = @planilla_texfor) 
        OR (T3.SECCION IN ('IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 'IN_J', 'IN_K', 'IN_M', 'IN_O') AND T3.PLANILLA = @planilla_texsun_innotex)
        THEN COALESCE(T1.SUELDOS, 0) + COALESCE(T2.SUELDOS, 0) + COALESCE(T3.SUELDOS, 0)
        ELSE 0 
    END
) AS TOTAL
INTO #SueldoTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION
WHERE 
    (T1.PLANILLA = @planilla_texsun_innotex AND T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z')) 
OR 
    (T2.PLANILLA = @planilla_texfor AND T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y'))
OR
    (T3.PLANILLA = @planilla_texsun_innotex AND T3.SECCION IN ('IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 'IN_J', 'IN_K', 'IN_M', 'IN_O'));


-- Fila 'OPERARIOS'
SELECT
    'OPERARIOS' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T1.SECCION = 'G-2' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T1.SECCION = 'G-3' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T1.SECCION = 'G-4' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS
        WHEN T2.SECCION = 'XG-2' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS
        WHEN T2.SECCION = 'XG-3' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        WHEN T2.SECCION = 'XG-4' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' THEN T1.OPERARIOS 
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' THEN T1.OPERARIOS 
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.OPERARIOS 
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN T2.OPERARIOS 
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' THEN T1.OPERARIOS 
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' THEN T1.OPERARIOS 
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' THEN T1.OPERARIOS 
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' THEN T2.OPERARIOS 
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.OPERARIOS 
        ELSE 0 
    END) AS IN_O,
	SUM(
    CASE 
        WHEN (T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z') AND T1.PLANILLA = @planilla_texsun_innotex) 
        OR (T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y') AND T2.PLANILLA = @planilla_texfor) 
        OR (T3.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'H', 'I', 'J', 'K', 'M', 'O') AND T3.PLANILLA = @planilla_texsun_innotex)
        THEN COALESCE(T1.OPERARIOS, 0) + COALESCE(T2.OPERARIOS, 0) + COALESCE(T3.OPERARIOS, 0)
        ELSE 0 
    END
) AS TOTAL

INTO #OperariosTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION
WHERE 
    (T1.PLANILLA = @planilla_texsun_innotex AND T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z')) 
OR 
    (T2.PLANILLA = @planilla_texfor AND T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y'))
OR
    (T3.PLANILLA = @planilla_texsun_innotex AND T3.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'H', 'I', 'J', 'K', 'M', 'O'));


-- Fila 'PROMEDIO DIARIO'
SELECT
    'PROMEDIO DIARIO' AS DATO,
    SUM(CASE WHEN P.SECCION = 'A' THEN P.PRENDAS ELSE 0 END) / 5 AS A,
    SUM(CASE WHEN P.SECCION = 'B' THEN P.PRENDAS ELSE 0 END) / 5 AS B,
    SUM(CASE WHEN P.SECCION = 'C' THEN P.PRENDAS ELSE 0 END) / 5 AS C,
    SUM(CASE WHEN P.SECCION = 'D' THEN P.PRENDAS ELSE 0 END) / 5 AS D,
    SUM(CASE WHEN P.SECCION = 'TF_D' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_D,
    SUM(CASE WHEN P.SECCION = 'E' THEN P.PRENDAS ELSE 0 END) / 5 AS E,
    SUM(CASE WHEN P.SECCION = 'F' THEN P.PRENDAS ELSE 0 END) / 5 AS F,
    SUM(CASE WHEN P.SECCION = 'G' THEN P.PRENDAS ELSE 0 END) / 5 AS G,
    SUM(CASE WHEN P.SECCION = 'H' THEN P.PRENDAS ELSE 0 END) / 5 AS H,
    SUM(CASE WHEN P.SECCION = 'I' THEN P.PRENDAS ELSE 0 END) / 5 AS I,
    SUM(CASE WHEN P.SECCION = 'J' THEN P.PRENDAS ELSE 0 END) / 5 AS J,
    SUM(CASE WHEN P.SECCION = 'K' THEN P.PRENDAS ELSE 0 END) / 5 AS K,
    SUM(CASE WHEN P.SECCION = 'M' THEN P.PRENDAS ELSE 0 END) / 5 AS M,
    SUM(CASE WHEN P.SECCION = 'N' THEN P.PRENDAS ELSE 0 END) / 5 AS N,
    SUM(CASE WHEN P.SECCION = 'O' THEN P.PRENDAS ELSE 0 END) / 5 AS O,
    SUM(CASE WHEN P.SECCION = 'O' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_O,
    SUM(CASE WHEN P.SECCION = 'P' THEN P.PRENDAS ELSE 0 END) / 5 AS P,
    SUM(CASE WHEN P.SECCION = 'Q' THEN P.PRENDAS ELSE 0 END) / 5 AS Q,
    SUM(CASE WHEN P.SECCION = 'TF_Q' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_Q,
    SUM(CASE WHEN P.SECCION = 'R' THEN P.PRENDAS ELSE 0 END) / 5 AS R,
    SUM(CASE WHEN P.SECCION = 'T' THEN P.PRENDAS ELSE 0 END) / 5 AS T,
    SUM(CASE WHEN P.SECCION = 'TF_T' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_T,
    SUM(CASE WHEN P.SECCION = 'U' THEN P.PRENDAS ELSE 0 END) / 5 AS U,
    SUM(CASE WHEN P.SECCION = 'TF_U' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_U,
    SUM(CASE WHEN P.SECCION = 'W' THEN P.PRENDAS ELSE 0 END) / 5 AS W,
	SUM(CASE WHEN P.SECCION = 'TF_W' THEN P.PRENDAS ELSE 0 END) / 5 AS TF_W,
    SUM(CASE WHEN P.SECCION = 'IN_A' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_A,
    SUM(CASE WHEN P.SECCION = 'IN_B' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_B,
    SUM(CASE WHEN P.SECCION = 'IN_C' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_C,
    SUM(CASE WHEN P.SECCION = 'IN_D' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_D,
    SUM(CASE WHEN P.SECCION = 'IN_E' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_E,
    SUM(CASE WHEN P.SECCION = 'IN_F' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_F,
    SUM(CASE WHEN P.SECCION = 'IN_H' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_H,
    SUM(CASE WHEN P.SECCION = 'IN_I' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_I,
    SUM(CASE WHEN P.SECCION = 'IN_J' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_J,
    SUM(CASE WHEN P.SECCION = 'IN_K' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_K,
    SUM(CASE WHEN P.SECCION = 'IN_M' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_M,
    SUM(CASE WHEN P.SECCION = 'IN_O' THEN P.PRENDAS ELSE 0 END) / 5 AS IN_O,
	SUM(
    CASE 
        WHEN P.SECCION IN ('A', 'B', 'C', 'D', 'TF_D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'TF_O', 'P', 'Q', 'TF_Q', 'R', 'T', 'TF_T', 'U', 'TF_U', 'W', 'TF_W', 'IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 'IN_J', 'IN_K', 'IN_M', 'IN_O')
        THEN P.PRENDAS
        ELSE 0 
    END
) / 5 AS TOTAL
INTO #PromedioDiarioTemporal
FROM 
    [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P
WHERE 
    P.FECHA BETWEEN @fec_inicio AND @fec_final;


-- Fila 'PRENDAS POR OPERARIO'
SELECT
    'PRENDAS POR OPERARIO' AS DATO,
    ISNULL(CAST(PD.A AS DECIMAL(18,2)) / NULLIF(CAST(O.A AS DECIMAL(18,2)), 0), 0) AS A,
    ISNULL(CAST(PD.B AS DECIMAL(18,2)) / NULLIF(CAST(O.B AS DECIMAL(18,2)), 0), 0) AS B,
    ISNULL(CAST(PD.C AS DECIMAL(18,2)) / NULLIF(CAST(O.C AS DECIMAL(18,2)), 0), 0) AS C,
    ISNULL(CAST(PD.D AS DECIMAL(18,2)) / NULLIF(CAST(O.D AS DECIMAL(18,2)), 0), 0) AS D,
    ISNULL(CAST(PD.TF_D AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_D AS DECIMAL(18,2)), 0), 0) AS TF_D,
    ISNULL(CAST(PD.E AS DECIMAL(18,2)) / NULLIF(CAST(O.E AS DECIMAL(18,2)), 0), 0) AS E,
    ISNULL(CAST(PD.F AS DECIMAL(18,2)) / NULLIF(CAST(O.F AS DECIMAL(18,2)), 0), 0) AS F,
    ISNULL(CAST(PD.G AS DECIMAL(18,2)) / NULLIF(CAST(O.G AS DECIMAL(18,2)), 0), 0) AS G,
    ISNULL(CAST(PD.H AS DECIMAL(18,2)) / NULLIF(CAST(O.H AS DECIMAL(18,2)), 0), 0) AS H,
    ISNULL(CAST(PD.I AS DECIMAL(18,2)) / NULLIF(CAST(O.I AS DECIMAL(18,2)), 0), 0) AS I,
    ISNULL(CAST(PD.J AS DECIMAL(18,2)) / NULLIF(CAST(O.J AS DECIMAL(18,2)), 0), 0) AS J,
    ISNULL(CAST(PD.K AS DECIMAL(18,2)) / NULLIF(CAST(O.K AS DECIMAL(18,2)), 0), 0) AS K,
    ISNULL(CAST(PD.M AS DECIMAL(18,2)) / NULLIF(CAST(O.M AS DECIMAL(18,2)), 0), 0) AS M,
    ISNULL(CAST(PD.N AS DECIMAL(18,2)) / NULLIF(CAST(O.N AS DECIMAL(18,2)), 0), 0) AS N,
    ISNULL(CAST(PD.O AS DECIMAL(18,2)) / NULLIF(CAST(O.O AS DECIMAL(18,2)), 0), 0) AS O,
    ISNULL(CAST(PD.TF_O AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_O AS DECIMAL(18,2)), 0), 0) AS TF_O,
    ISNULL(CAST(PD.P AS DECIMAL(18,2)) / NULLIF(CAST(O.P AS DECIMAL(18,2)), 0), 0) AS P,
    ISNULL(CAST(PD.Q AS DECIMAL(18,2)) / NULLIF(CAST(O.Q AS DECIMAL(18,2)), 0), 0) AS Q,
    ISNULL(CAST(PD.TF_Q AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_Q AS DECIMAL(18,2)), 0), 0) AS TF_Q,
    ISNULL(CAST(PD.R AS DECIMAL(18,2)) / NULLIF(CAST(O.R AS DECIMAL(18,2)), 0), 0) AS R,
    ISNULL(CAST(PD.T AS DECIMAL(18,2)) / NULLIF(CAST(O.T AS DECIMAL(18,2)), 0), 0) AS T,
    ISNULL(CAST(PD.TF_T AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_T AS DECIMAL(18,2)), 0), 0) AS TF_T,
    ISNULL(CAST(PD.U AS DECIMAL(18,2)) / NULLIF(CAST(O.U AS DECIMAL(18,2)), 0), 0) AS U,
    ISNULL(CAST(PD.TF_U AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_U AS DECIMAL(18,2)), 0), 0) AS TF_U,
    ISNULL(CAST(PD.W AS DECIMAL(18,2)) / NULLIF(CAST(O.W AS DECIMAL(18,2)), 0), 0) AS W,
	ISNULL(CAST(PD.TF_W AS DECIMAL(18,2)) / NULLIF(CAST(O.TF_W AS DECIMAL(18,2)), 0), 0) AS TF_W,
    ISNULL(CAST(PD.IN_A AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_A AS DECIMAL(18,2)), 0), 0) AS IN_A,
    ISNULL(CAST(PD.IN_B AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_B AS DECIMAL(18,2)), 0), 0) AS IN_B,
    ISNULL(CAST(PD.IN_C AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_C AS DECIMAL(18,2)), 0), 0) AS IN_C,
    ISNULL(CAST(PD.IN_D AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_D AS DECIMAL(18,2)), 0), 0) AS IN_D,
    ISNULL(CAST(PD.IN_E AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_E AS DECIMAL(18,2)), 0), 0) AS IN_E,
    ISNULL(CAST(PD.IN_F AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_F AS DECIMAL(18,2)), 0), 0) AS IN_F,
    ISNULL(CAST(PD.IN_H AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_H AS DECIMAL(18,2)), 0), 0) AS IN_H,
    ISNULL(CAST(PD.IN_I AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_I AS DECIMAL(18,2)), 0), 0) AS IN_I,
    ISNULL(CAST(PD.IN_J AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_J AS DECIMAL(18,2)), 0), 0) AS IN_J,
    ISNULL(CAST(PD.IN_K AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_K AS DECIMAL(18,2)), 0), 0) AS IN_K,
    ISNULL(CAST(PD.IN_M AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_M AS DECIMAL(18,2)), 0), 0) AS IN_M,
    ISNULL(CAST(PD.IN_O AS DECIMAL(18,2)) / NULLIF(CAST(O.IN_O AS DECIMAL(18,2)), 0), 0) AS IN_O,
	ISNULL(
    CAST(
        (PD.A + PD.B + PD.C + PD.D + PD.TF_D + PD.E + PD.F + PD.G + PD.H + PD.I + PD.J + PD.K + PD.M + PD.N + PD.O + PD.TF_O + 
        PD.P + PD.Q + PD.TF_Q + PD.R + PD.T + PD.TF_T + PD.U + PD.TF_U + PD.W + PD.TF_W + PD.IN_A + PD.IN_B + PD.IN_C + 
        PD.IN_D + PD.IN_E + PD.IN_F + PD.IN_H + PD.IN_I + PD.IN_J + PD.IN_K + PD.IN_M + PD.IN_O) 
        AS DECIMAL(18,2)
    ) 
    / NULLIF(
        CAST(
            (O.A + O.B + O.C + O.D + O.TF_D + O.E + O.F + O.G + O.H + O.I + O.J + O.K + O.M + O.N + O.O + O.TF_O + 
            O.P + O.Q + O.TF_Q + O.R + O.T + O.TF_T + O.U + O.TF_U + O.W + O.TF_W + O.IN_A + O.IN_B + O.IN_C + 
            O.IN_D + O.IN_E + O.IN_F + O.IN_H + O.IN_I + O.IN_J + O.IN_K + O.IN_M + O.IN_O) 
            AS DECIMAL(18,2)
        ), 
        0
    ), 
    0
) AS TOTAL
INTO #PrendasPorOperarioTemporal
FROM #PromedioDiarioTemporal PD
INNER JOIN #OperariosTemporal O ON 1=1;


-- Fila 'FACTURACION POR OPERARIO'
SELECT
    'FACTURACION POR OPERARIO' AS DATO,
    ISNULL((ValorPromedio.A * PP.A) / NULLIF(O.A, 0), 0) AS A,
    ISNULL((ValorPromedio.B * PP.B) / NULLIF(O.B, 0), 0) AS B,
    ISNULL((ValorPromedio.C * PP.C) / NULLIF(O.C, 0), 0) AS C,
    ISNULL((ValorPromedio.D * PP.D) / NULLIF(O.D, 0), 0) AS D,
    ISNULL((ValorPromedio.TF_D * PP.TF_D) / NULLIF(O.TF_D, 0), 0) AS TF_D,
    ISNULL((ValorPromedio.E * PP.E) / NULLIF(O.E, 0), 0) AS E,
    ISNULL((ValorPromedio.F * PP.F) / NULLIF(O.F, 0), 0) AS F,
    ISNULL((ValorPromedio.G * PP.G) / NULLIF(O.G, 0), 0) AS G,
    ISNULL((ValorPromedio.H * PP.H) / NULLIF(O.H, 0), 0) AS H,
    ISNULL((ValorPromedio.I * PP.I) / NULLIF(O.I, 0), 0) AS I,
    ISNULL((ValorPromedio.J * PP.J) / NULLIF(O.J, 0), 0) AS J,
    ISNULL((ValorPromedio.K * PP.K) / NULLIF(O.K, 0), 0) AS K,
    ISNULL((ValorPromedio.M * PP.M) / NULLIF(O.M, 0), 0) AS M,
    ISNULL((ValorPromedio.N * PP.N) / NULLIF(O.N, 0), 0) AS N,
    ISNULL((ValorPromedio.O * PP.O) / NULLIF(O.O, 0), 0) AS O,
    ISNULL((ValorPromedio.TF_O * PP.TF_O) / NULLIF(O.TF_O, 0), 0) AS TF_O,
    ISNULL((ValorPromedio.P * PP.P) / NULLIF(O.P, 0), 0) AS P,
    ISNULL((ValorPromedio.Q * PP.Q) / NULLIF(O.Q, 0), 0) AS Q,
    ISNULL((ValorPromedio.TF_Q * PP.TF_Q) / NULLIF(O.TF_Q, 0), 0) AS TF_Q,
    ISNULL((ValorPromedio.R * PP.R) / NULLIF(O.R, 0), 0) AS R,
    ISNULL((ValorPromedio.T * PP.T) / NULLIF(O.T, 0), 0) AS T,
    ISNULL((ValorPromedio.TF_T * PP.TF_T) / NULLIF(O.TF_T, 0), 0) AS TF_T,
    ISNULL((ValorPromedio.U * PP.U) / NULLIF(O.U, 0), 0) AS U,
    ISNULL((ValorPromedio.TF_U * PP.TF_U) / NULLIF(O.TF_U, 0), 0) AS TF_U,
    ISNULL((ValorPromedio.W * PP.W) / NULLIF(O.W, 0), 0) AS W,
    ISNULL((ValorPromedio.TF_W * PP.TF_W) / NULLIF(O.TF_W, 0), 0) AS TF_W,
    ISNULL((ValorPromedio.IN_A * PP.IN_A) / NULLIF(O.IN_A, 0), 0) AS IN_A,
    ISNULL((ValorPromedio.IN_B * PP.IN_B) / NULLIF(O.IN_B, 0), 0) AS IN_B,
    ISNULL((ValorPromedio.IN_C * PP.IN_C) / NULLIF(O.IN_C, 0), 0) AS IN_C,
    ISNULL((ValorPromedio.IN_D * PP.IN_D) / NULLIF(O.IN_D, 0), 0) AS IN_D,
    ISNULL((ValorPromedio.IN_E * PP.IN_E) / NULLIF(O.IN_E, 0), 0) AS IN_E,
    ISNULL((ValorPromedio.IN_F * PP.IN_F) / NULLIF(O.IN_F, 0), 0) AS IN_F,
    ISNULL((ValorPromedio.IN_H * PP.IN_H) / NULLIF(O.IN_H, 0), 0) AS IN_H,
    ISNULL((ValorPromedio.IN_I * PP.IN_I) / NULLIF(O.IN_I, 0), 0) AS IN_I,
    ISNULL((ValorPromedio.IN_J * PP.IN_J) / NULLIF(O.IN_J, 0), 0) AS IN_J,
    ISNULL((ValorPromedio.IN_K * PP.IN_K) / NULLIF(O.IN_K, 0), 0) AS IN_K,
    ISNULL((ValorPromedio.IN_M * PP.IN_M) / NULLIF(O.IN_M, 0), 0) AS IN_M,
    ISNULL((ValorPromedio.IN_O * PP.IN_O) / NULLIF(O.IN_O, 0), 0) AS IN_O,
	(
	ISNULL((ValorPromedio.A * PP.A) / NULLIF(O.A, 0), 0) +
	ISNULL((ValorPromedio.B * PP.B) / NULLIF(O.B, 0), 0) +
	ISNULL((ValorPromedio.C * PP.C) / NULLIF(O.C, 0), 0) +
	ISNULL((ValorPromedio.D * PP.D) / NULLIF(O.D, 0), 0) +
	ISNULL((ValorPromedio.TF_D * PP.TF_D) / NULLIF(O.TF_D, 0), 0) +
	ISNULL((ValorPromedio.E * PP.E) / NULLIF(O.E, 0), 0) +
	ISNULL((ValorPromedio.F * PP.F) / NULLIF(O.F, 0), 0) +
	ISNULL((ValorPromedio.G * PP.G) / NULLIF(O.G, 0), 0) +
	ISNULL((ValorPromedio.H * PP.H) / NULLIF(O.H, 0), 0) +
	ISNULL((ValorPromedio.I * PP.I) / NULLIF(O.I, 0), 0) +
	ISNULL((ValorPromedio.J * PP.J) / NULLIF(O.J, 0), 0) +
	ISNULL((ValorPromedio.K * PP.K) / NULLIF(O.K, 0), 0) +
	ISNULL((ValorPromedio.M * PP.M) / NULLIF(O.M, 0), 0) +
	ISNULL((ValorPromedio.N * PP.N) / NULLIF(O.N, 0), 0) +
	ISNULL((ValorPromedio.O * PP.O) / NULLIF(O.O, 0), 0) +
	ISNULL((ValorPromedio.TF_O * PP.TF_O) / NULLIF(O.TF_O, 0), 0) +
	ISNULL((ValorPromedio.P * PP.P) / NULLIF(O.P, 0), 0) +
	ISNULL((ValorPromedio.Q * PP.Q) / NULLIF(O.Q, 0), 0) +
	ISNULL((ValorPromedio.TF_Q * PP.TF_Q) / NULLIF(O.TF_Q, 0), 0) +
	ISNULL((ValorPromedio.R * PP.R) / NULLIF(O.R, 0), 0) +
	ISNULL((ValorPromedio.T * PP.T) / NULLIF(O.T, 0), 0) +
	ISNULL((ValorPromedio.TF_T * PP.TF_T) / NULLIF(O.TF_T, 0), 0) +
	ISNULL((ValorPromedio.U * PP.U) / NULLIF(O.U, 0), 0) +
	ISNULL((ValorPromedio.TF_U * PP.TF_U) / NULLIF(O.TF_U, 0), 0) +
	ISNULL((ValorPromedio.W * PP.W) / NULLIF(O.W, 0), 0) +
	ISNULL((ValorPromedio.TF_W * PP.TF_W) / NULLIF(O.TF_W, 0), 0) +
	ISNULL((ValorPromedio.IN_A * PP.IN_A) / NULLIF(O.IN_A, 0), 0) +
	ISNULL((ValorPromedio.IN_B * PP.IN_B) / NULLIF(O.IN_B, 0), 0) +
	ISNULL((ValorPromedio.IN_C * PP.IN_C) / NULLIF(O.IN_C, 0), 0) +
	ISNULL((ValorPromedio.IN_D * PP.IN_D) / NULLIF(O.IN_D, 0), 0) +
	ISNULL((ValorPromedio.IN_E * PP.IN_E) / NULLIF(O.IN_E, 0), 0) +
	ISNULL((ValorPromedio.IN_F * PP.IN_F) / NULLIF(O.IN_F, 0), 0) +
	ISNULL((ValorPromedio.IN_H * PP.IN_H) / NULLIF(O.IN_H, 0), 0) +
	ISNULL((ValorPromedio.IN_I * PP.IN_I) / NULLIF(O.IN_I, 0), 0) +
	ISNULL((ValorPromedio.IN_J * PP.IN_J) / NULLIF(O.IN_J, 0), 0) +
	ISNULL((ValorPromedio.IN_K * PP.IN_K) / NULLIF(O.IN_K, 0), 0) +
	ISNULL((ValorPromedio.IN_M * PP.IN_M) / NULLIF(O.IN_M, 0), 0) +
	ISNULL((ValorPromedio.IN_O * PP.IN_O) / NULLIF(O.IN_O, 0), 0)) AS TOTAL
INTO #FacturacionPorOperarioTemporal
FROM 
(
    SELECT
        ISNULL(AVG(CASE WHEN P.SECCION = 'A' THEN P.VALOR ELSE NULL END), 0) AS A,
        ISNULL(AVG(CASE WHEN P.SECCION = 'B' THEN P.VALOR ELSE NULL END), 0) AS B,
        ISNULL(AVG(CASE WHEN P.SECCION = 'C' THEN P.VALOR ELSE NULL END), 0) AS C,
        ISNULL(AVG(CASE WHEN P.SECCION = 'D' THEN P.VALOR ELSE NULL END), 0) AS D,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_D' THEN P.VALOR ELSE NULL END), 0) AS TF_D,
        ISNULL(AVG(CASE WHEN P.SECCION = 'E' THEN P.VALOR ELSE NULL END), 0) AS E,
        ISNULL(AVG(CASE WHEN P.SECCION = 'F' THEN P.VALOR ELSE NULL END), 0) AS F,
        ISNULL(AVG(CASE WHEN P.SECCION = 'G' THEN P.VALOR ELSE NULL END), 0) AS G,
        ISNULL(AVG(CASE WHEN P.SECCION = 'H' THEN P.VALOR ELSE NULL END), 0) AS H,
        ISNULL(AVG(CASE WHEN P.SECCION = 'I' THEN P.VALOR ELSE NULL END), 0) AS I,
        ISNULL(AVG(CASE WHEN P.SECCION = 'J' THEN P.VALOR ELSE NULL END), 0) AS J,
        ISNULL(AVG(CASE WHEN P.SECCION = 'K' THEN P.VALOR ELSE NULL END), 0) AS K,
        ISNULL(AVG(CASE WHEN P.SECCION = 'M' THEN P.VALOR ELSE NULL END), 0) AS M,
        ISNULL(AVG(CASE WHEN P.SECCION = 'N' THEN P.VALOR ELSE NULL END), 0) AS N,
        ISNULL(AVG(CASE WHEN P.SECCION = 'O' THEN P.VALOR ELSE NULL END), 0) AS O,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_O' THEN P.VALOR ELSE NULL END), 0) AS TF_O,
        ISNULL(AVG(CASE WHEN P.SECCION = 'P' THEN P.VALOR ELSE NULL END), 0) AS P,
        ISNULL(AVG(CASE WHEN P.SECCION = 'Q' THEN P.VALOR ELSE NULL END), 0) AS Q,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_Q' THEN P.VALOR ELSE NULL END), 0) AS TF_Q,
        ISNULL(AVG(CASE WHEN P.SECCION = 'R' THEN P.VALOR ELSE NULL END), 0) AS R,
        ISNULL(AVG(CASE WHEN P.SECCION = 'T' THEN P.VALOR ELSE NULL END), 0) AS T,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_T' THEN P.VALOR ELSE NULL END), 0) AS TF_T,
        ISNULL(AVG(CASE WHEN P.SECCION = 'U' THEN P.VALOR ELSE NULL END), 0) AS U,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_U' THEN P.VALOR ELSE NULL END), 0) AS TF_U,
        ISNULL(AVG(CASE WHEN P.SECCION = 'W' THEN P.VALOR ELSE NULL END), 0) AS W,
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_W' THEN P.VALOR ELSE NULL END), 0) AS TF_W,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_A' THEN P.VALOR ELSE NULL END), 0) AS IN_A,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_B' THEN P.VALOR ELSE NULL END), 0) AS IN_B,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_C' THEN P.VALOR ELSE NULL END), 0) AS IN_C,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_D' THEN P.VALOR ELSE NULL END), 0) AS IN_D,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_E' THEN P.VALOR ELSE NULL END), 0) AS IN_E,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_F' THEN P.VALOR ELSE NULL END), 0) AS IN_F,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_H' THEN P.VALOR ELSE NULL END), 0) AS IN_H,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_I' THEN P.VALOR ELSE NULL END), 0) AS IN_I,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_J' THEN P.VALOR ELSE NULL END), 0) AS IN_J,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_K' THEN P.VALOR ELSE NULL END), 0) AS IN_K,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_M' THEN P.VALOR ELSE NULL END), 0) AS IN_M,
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_O' THEN P.VALOR ELSE NULL END), 0) AS IN_O,
		(
		ISNULL(AVG(CASE WHEN P.SECCION = 'A' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'B' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'C' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'D' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_D' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'E' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'F' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'G' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'H' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'I' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'J' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'K' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'M' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'N' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'O' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_O' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'P' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'Q' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_Q' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'R' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'T' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_T' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'U' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_U' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'W' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'TF_W' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_A' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_B' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_C' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_D' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_E' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_F' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_H' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_I' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_J' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_K' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_M' THEN P.VALOR ELSE NULL END), 0) +
        ISNULL(AVG(CASE WHEN P.SECCION = 'IN_O' THEN P.VALOR ELSE NULL END), 0)) TOTAL

    FROM 
        [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P
    WHERE 
        P.FECHA BETWEEN @fec_inicio AND @fec_final
) AS ValorPromedio,
#PrendasTemporal AS PP,
#OperariosTemporal AS O;


-- Fila 'HORAS EXTRAS'
SELECT
    'HORAS EXTRAS' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T1.SECCION = 'G-2' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T1.SECCION = 'G-3' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T1.SECCION = 'G-4' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS
        WHEN T2.SECCION = 'XG-2' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS
        WHEN T2.SECCION = 'XG-3' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XG-4' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS 
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' AND T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS 
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS 
        ELSE 0 
    END) AS IN_O,
	SUM(CASE 
    WHEN T1.PLANILLA = @planilla_texsun_innotex THEN T1.HORAS_EXTRAS
    WHEN T2.PLANILLA = @planilla_texfor THEN T2.HORAS_EXTRAS
    WHEN T3.PLANILLA = @planilla_texsun_innotex THEN T3.HORAS_EXTRAS
    ELSE 0 
END) AS TOTAL
INTO #HorasExtrasTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION;


-- Fila 'BONIFICACION'
SELECT
    'BONIFICACION' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T1.SECCION = 'G-2' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T1.SECCION = 'G-3' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T1.SECCION = 'G-4' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA
        WHEN T2.SECCION = 'XG-2' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA
        WHEN T2.SECCION = 'XG-3' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        WHEN T2.SECCION = 'XG-4' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA 
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' AND T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA 
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA 
        ELSE 0 
    END) AS IN_O,
	SUM(CASE 
    WHEN T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONIFICA
    WHEN T2.PLANILLA = @planilla_texfor THEN T2.BONIFICA
    WHEN T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONIFICA
    ELSE 0 
END) AS TOTAL
INTO #BonificacionTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION;


-- Fila 'BONIFICACION PRODUCCION'
SELECT
    'BONIFICACION PRODUCCION' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T1.SECCION IN ('G-2', 'G-3', 'G-4') AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD
        WHEN T2.SECCION IN ('XG-2', 'XG-3', 'XG-4') AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' AND T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD 
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' AND T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD 
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD 
        ELSE 0 
    END) AS IN_O,
	SUM(CASE 
    WHEN T1.PLANILLA = @planilla_texsun_innotex THEN T1.BONO_PROD
    WHEN T2.PLANILLA = @planilla_texfor THEN T2.BONO_PROD
    WHEN T3.PLANILLA = @planilla_texsun_innotex THEN T3.BONO_PROD
    ELSE 0 
END) AS TOTAL
INTO #BonificacionProduccionTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION
WHERE 
    (T1.PLANILLA = @planilla_texsun_innotex AND T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z')) 
OR 
    (T2.PLANILLA = @planilla_texfor AND T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y'))
OR
    (T3.PLANILLA = @planilla_texsun_innotex AND T3.SECCION IN ('IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 'IN_J', 'IN_K', 'IN_M', 'IN_O'));


-- Fila 'PRESTACIONES DE LEY'
SELECT
    'PRESTACIONES DE LEY' AS DATO,
    SUM(CASE 
        WHEN T1.SECCION = 'A' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XA' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS A,
    SUM(CASE 
        WHEN T1.SECCION = 'B' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XB' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS B,
    SUM(CASE 
        WHEN T1.SECCION = 'C' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XC' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS C,
    SUM(CASE 
        WHEN T1.SECCION = 'D' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS D,
    SUM(CASE 
        WHEN T2.SECCION = 'D' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_D,
    SUM(CASE 
        WHEN T1.SECCION = 'E' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XE' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS E,
    SUM(CASE 
        WHEN T1.SECCION = 'F' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XF' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS F,
    SUM(CASE 
        WHEN T1.SECCION = 'G' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T1.SECCION IN ('G-2', 'G-3', 'G-4') AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XG' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION IN ('XG-2', 'XG-3', 'XG-4') AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS G,
    SUM(CASE 
        WHEN T1.SECCION = 'H' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XH' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS H,
    SUM(CASE 
        WHEN T1.SECCION = 'I' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XI' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS I,
    SUM(CASE 
        WHEN T1.SECCION = 'J' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XJ' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS J,
    SUM(CASE 
        WHEN T1.SECCION = 'K' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XK' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS K,
    SUM(CASE 
        WHEN T1.SECCION = 'M' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XM' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS M,
    SUM(CASE 
        WHEN T1.SECCION = 'N' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XN' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS N,
    SUM(CASE 
        WHEN T1.SECCION = 'O' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T1.SECCION = 'O-1' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XO-1' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS O,
    SUM(CASE 
        WHEN T2.SECCION = 'O' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_O,
    SUM(CASE 
        WHEN T1.SECCION = 'P' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS P,
    SUM(CASE 
        WHEN T1.SECCION = 'Q' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS Q,
    SUM(CASE 
        WHEN T2.SECCION = 'Q' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_Q,
    SUM(CASE 
        WHEN T1.SECCION = 'R' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        WHEN T2.SECCION = 'XR' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS R,
    SUM(CASE 
        WHEN T1.SECCION = 'T' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS T,
    SUM(CASE 
        WHEN T2.SECCION = 'T' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_T,
    SUM(CASE 
        WHEN T1.SECCION = 'U' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS U,
    SUM(CASE 
        WHEN T2.SECCION = 'U' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_U,
    SUM(CASE 
        WHEN T1.SECCION = 'W' AND T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS W,
    SUM(CASE 
        WHEN T2.SECCION = 'W' AND T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS TF_W,
    SUM(CASE 
        WHEN T3.SECCION = 'A' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_A,
    SUM(CASE 
        WHEN T3.SECCION = 'B' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_B,
    SUM(CASE 
        WHEN T3.SECCION = 'C' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_C,
    SUM(CASE 
        WHEN T3.SECCION = 'D' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_D,
    SUM(CASE 
        WHEN T3.SECCION = 'E' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_E,
    SUM(CASE 
        WHEN T3.SECCION = 'F' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_F,
    SUM(CASE 
        WHEN T3.SECCION = 'H' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_H,
    SUM(CASE 
        WHEN T3.SECCION = 'I' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_I,
    SUM(CASE 
        WHEN T3.SECCION = 'J' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_J,
    SUM(CASE 
        WHEN T3.SECCION = 'K' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_K,
    SUM(CASE 
        WHEN T3.SECCION = 'M' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_M,
    SUM(CASE 
        WHEN T3.SECCION = 'O' AND T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
        ELSE 0 
    END) AS IN_O,
	SUM(CASE 
    WHEN T1.PLANILLA = @planilla_texsun_innotex THEN (T1.SUELDOS + ISNULL(T1.HORAS_EXTRAS, 0)) * 0.3905
    WHEN T2.PLANILLA = @planilla_texfor THEN (T2.SUELDOS + ISNULL(T2.HORAS_EXTRAS, 0)) * 0.3905
    WHEN T3.PLANILLA = @planilla_texsun_innotex THEN (T3.SUELDOS + ISNULL(T3.HORAS_EXTRAS, 0)) * 0.3905
    ELSE 0 
END) AS TOTAL
INTO #PrestacionesLeyTemporal
FROM 
    [planilla].[dbo].[SUELDOS] AS T1
FULL OUTER JOIN
    [planilla_tf].[dbo].[SUELDOS] AS T2
ON
    T1.PLANILLA = T2.PLANILLA 
    AND T1.SECCION = T2.SECCION
FULL OUTER JOIN
    [planilla_in].[dbo].[SUELDOS] AS T3
ON
    T1.PLANILLA = T3.PLANILLA 
    AND T1.SECCION = T3.SECCION
WHERE 
    (T1.PLANILLA = @planilla_texsun_innotex AND T1.SECCION IN ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'G-2', 'G-3', 'G-4', 'H', 'I', 'J', 'K', 'M', 'N', 'O', 'O-1', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z')) 
OR 
    (T2.PLANILLA = @planilla_texfor AND T2.SECCION IN ('D', 'O', 'Q', 'T', 'U', 'W', 'XA', 'XB', 'XC', 'XE', 'XF', 'XG', 'XG-2', 'XG-3', 'XG-4', 'XH', 'XI', 'XJ', 'XK', 'XM', 'XN', 'XO-1', 'XR', 'XS', 'XV', 'XZ', 'Y'))
OR
    (T3.PLANILLA = @planilla_texsun_innotex AND T3.SECCION IN ('IN_A', 'IN_B', 'IN_C', 'IN_D', 'IN_E', 'IN_F', 'IN_H', 'IN_I', 'IN_J', 'IN_K', 'IN_M', 'IN_O'));


-- Fila 'TOTAL'
SELECT
    'TOTAL' AS DATO,
    (ISNULL(SUM_SUELDO.A, 0) + ISNULL(SUM_HORAS_EXTRAS.A, 0) + ISNULL(SUM_BONIFICACION.A, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.A, 0) + ISNULL(SUM_PRESTACIONES_LEY.A, 0)) AS A,
    (ISNULL(SUM_SUELDO.B, 0) + ISNULL(SUM_HORAS_EXTRAS.B, 0) + ISNULL(SUM_BONIFICACION.B, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.B, 0) + ISNULL(SUM_PRESTACIONES_LEY.B, 0)) AS B,
    (ISNULL(SUM_SUELDO.C, 0) + ISNULL(SUM_HORAS_EXTRAS.C, 0) + ISNULL(SUM_BONIFICACION.C, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.C, 0) + ISNULL(SUM_PRESTACIONES_LEY.C, 0)) AS C,
    (ISNULL(SUM_SUELDO.D, 0) + ISNULL(SUM_HORAS_EXTRAS.D, 0) + ISNULL(SUM_BONIFICACION.D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.D, 0) + ISNULL(SUM_PRESTACIONES_LEY.D, 0)) AS D,
    (ISNULL(SUM_SUELDO.TF_D, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_D, 0) + ISNULL(SUM_BONIFICACION.TF_D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_D, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_D, 0)) AS TF_D,
    (ISNULL(SUM_SUELDO.E, 0) + ISNULL(SUM_HORAS_EXTRAS.E, 0) + ISNULL(SUM_BONIFICACION.E, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.E, 0) + ISNULL(SUM_PRESTACIONES_LEY.E, 0)) AS E,
    (ISNULL(SUM_SUELDO.F, 0) + ISNULL(SUM_HORAS_EXTRAS.F, 0) + ISNULL(SUM_BONIFICACION.F, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.F, 0) + ISNULL(SUM_PRESTACIONES_LEY.F, 0)) AS F,
    (ISNULL(SUM_SUELDO.G, 0) + ISNULL(SUM_HORAS_EXTRAS.G, 0) + ISNULL(SUM_BONIFICACION.G, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.G, 0) + ISNULL(SUM_PRESTACIONES_LEY.G, 0)) AS G,
    (ISNULL(SUM_SUELDO.H, 0) + ISNULL(SUM_HORAS_EXTRAS.H, 0) + ISNULL(SUM_BONIFICACION.H, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.H, 0) + ISNULL(SUM_PRESTACIONES_LEY.H, 0)) AS H,
    (ISNULL(SUM_SUELDO.I, 0) + ISNULL(SUM_HORAS_EXTRAS.I, 0) + ISNULL(SUM_BONIFICACION.I, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.I, 0) + ISNULL(SUM_PRESTACIONES_LEY.I, 0)) AS I,
    (ISNULL(SUM_SUELDO.J, 0) + ISNULL(SUM_HORAS_EXTRAS.J, 0) + ISNULL(SUM_BONIFICACION.J, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.J, 0) + ISNULL(SUM_PRESTACIONES_LEY.J, 0)) AS J,
    (ISNULL(SUM_SUELDO.K, 0) + ISNULL(SUM_HORAS_EXTRAS.K, 0) + ISNULL(SUM_BONIFICACION.K, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.K, 0) + ISNULL(SUM_PRESTACIONES_LEY.K, 0)) AS K,
    (ISNULL(SUM_SUELDO.M, 0) + ISNULL(SUM_HORAS_EXTRAS.M, 0) + ISNULL(SUM_BONIFICACION.M, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.M, 0) + ISNULL(SUM_PRESTACIONES_LEY.M, 0)) AS M,
    (ISNULL(SUM_SUELDO.N, 0) + ISNULL(SUM_HORAS_EXTRAS.N, 0) + ISNULL(SUM_BONIFICACION.N, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.N, 0) + ISNULL(SUM_PRESTACIONES_LEY.N, 0)) AS N,
    (ISNULL(SUM_SUELDO.O, 0) + ISNULL(SUM_HORAS_EXTRAS.O, 0) + ISNULL(SUM_BONIFICACION.O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.O, 0) + ISNULL(SUM_PRESTACIONES_LEY.O, 0)) AS O,
    (ISNULL(SUM_SUELDO.TF_O, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_O, 0) + ISNULL(SUM_BONIFICACION.TF_O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_O, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_O, 0)) AS TF_O,
    (ISNULL(SUM_SUELDO.P, 0) + ISNULL(SUM_HORAS_EXTRAS.P, 0) + ISNULL(SUM_BONIFICACION.P, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.P, 0) + ISNULL(SUM_PRESTACIONES_LEY.P, 0)) AS P,
    (ISNULL(SUM_SUELDO.Q, 0) + ISNULL(SUM_HORAS_EXTRAS.Q, 0) + ISNULL(SUM_BONIFICACION.Q, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.Q, 0) + ISNULL(SUM_PRESTACIONES_LEY.Q, 0)) AS Q,
    (ISNULL(SUM_SUELDO.TF_Q, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_Q, 0) + ISNULL(SUM_BONIFICACION.TF_Q, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_Q, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_Q, 0)) AS TF_Q,
    (ISNULL(SUM_SUELDO.R, 0) + ISNULL(SUM_HORAS_EXTRAS.R, 0) + ISNULL(SUM_BONIFICACION.R, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.R, 0) + ISNULL(SUM_PRESTACIONES_LEY.R, 0)) AS R,
    (ISNULL(SUM_SUELDO.T, 0) + ISNULL(SUM_HORAS_EXTRAS.T, 0) + ISNULL(SUM_BONIFICACION.T, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.T, 0) + ISNULL(SUM_PRESTACIONES_LEY.T, 0)) AS T,
    (ISNULL(SUM_SUELDO.TF_T, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_T, 0) + ISNULL(SUM_BONIFICACION.TF_T, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_T, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_T, 0)) AS TF_T,
    (ISNULL(SUM_SUELDO.U, 0) + ISNULL(SUM_HORAS_EXTRAS.U, 0) + ISNULL(SUM_BONIFICACION.U, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.U, 0) + ISNULL(SUM_PRESTACIONES_LEY.U, 0)) AS U,
    (ISNULL(SUM_SUELDO.TF_U, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_U, 0) + ISNULL(SUM_BONIFICACION.TF_U, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_U, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_U, 0)) AS TF_U,
    (ISNULL(SUM_SUELDO.W, 0) + ISNULL(SUM_HORAS_EXTRAS.W, 0) + ISNULL(SUM_BONIFICACION.W, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.W, 0) + ISNULL(SUM_PRESTACIONES_LEY.W, 0)) AS W,
    (ISNULL(SUM_SUELDO.TF_W, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_W, 0) + ISNULL(SUM_BONIFICACION.TF_W, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_W, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_W, 0)) AS TF_W,
    (ISNULL(SUM_SUELDO.IN_A, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_A, 0) + ISNULL(SUM_BONIFICACION.IN_A, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_A, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_A, 0)) AS IN_A,
    (ISNULL(SUM_SUELDO.IN_B, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_B, 0) + ISNULL(SUM_BONIFICACION.IN_B, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_B, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_B, 0)) AS IN_B,
    (ISNULL(SUM_SUELDO.IN_C, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_C, 0) + ISNULL(SUM_BONIFICACION.IN_C, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_C, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_C, 0)) AS IN_C,
    (ISNULL(SUM_SUELDO.IN_D, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_D, 0) + ISNULL(SUM_BONIFICACION.IN_D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_D, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_D, 0)) AS IN_D,
    (ISNULL(SUM_SUELDO.IN_E, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_E, 0) + ISNULL(SUM_BONIFICACION.IN_E, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_E, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_E, 0)) AS IN_E,
    (ISNULL(SUM_SUELDO.IN_F, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_F, 0) + ISNULL(SUM_BONIFICACION.IN_F, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_F, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_F, 0)) AS IN_F,
    (ISNULL(SUM_SUELDO.IN_H, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_H, 0) + ISNULL(SUM_BONIFICACION.IN_H, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_H, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_H, 0)) AS IN_H,
    (ISNULL(SUM_SUELDO.IN_I, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_I, 0) + ISNULL(SUM_BONIFICACION.IN_I, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_I, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_I, 0)) AS IN_I,
    (ISNULL(SUM_SUELDO.IN_J, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_J, 0) + ISNULL(SUM_BONIFICACION.IN_J, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_J, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_J, 0)) AS IN_J,
    (ISNULL(SUM_SUELDO.IN_K, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_K, 0) + ISNULL(SUM_BONIFICACION.IN_K, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_K, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_K, 0)) AS IN_K,
    (ISNULL(SUM_SUELDO.IN_M, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_M, 0) + ISNULL(SUM_BONIFICACION.IN_M, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_M, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_M, 0)) AS IN_M,
    (ISNULL(SUM_SUELDO.IN_O, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_O, 0) + ISNULL(SUM_BONIFICACION.IN_O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_O, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_O, 0)) AS IN_O,
	--------

	(ISNULL(SUM_SUELDO.A, 0) + ISNULL(SUM_HORAS_EXTRAS.A, 0) + ISNULL(SUM_BONIFICACION.A, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.A, 0) + ISNULL(SUM_PRESTACIONES_LEY.A, 0) +
    ISNULL(SUM_SUELDO.B, 0) + ISNULL(SUM_HORAS_EXTRAS.B, 0) + ISNULL(SUM_BONIFICACION.B, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.B, 0) + ISNULL(SUM_PRESTACIONES_LEY.B, 0) +
    ISNULL(SUM_SUELDO.C, 0) + ISNULL(SUM_HORAS_EXTRAS.C, 0) + ISNULL(SUM_BONIFICACION.C, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.C, 0) + ISNULL(SUM_PRESTACIONES_LEY.C, 0) +
    ISNULL(SUM_SUELDO.D, 0) + ISNULL(SUM_HORAS_EXTRAS.D, 0) + ISNULL(SUM_BONIFICACION.D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.D, 0) + ISNULL(SUM_PRESTACIONES_LEY.D, 0) +
    ISNULL(SUM_SUELDO.TF_D, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_D, 0) + ISNULL(SUM_BONIFICACION.TF_D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_D, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_D, 0) +
    ISNULL(SUM_SUELDO.E, 0) + ISNULL(SUM_HORAS_EXTRAS.E, 0) + ISNULL(SUM_BONIFICACION.E, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.E, 0) + ISNULL(SUM_PRESTACIONES_LEY.E, 0) +
    ISNULL(SUM_SUELDO.F, 0) + ISNULL(SUM_HORAS_EXTRAS.F, 0) + ISNULL(SUM_BONIFICACION.F, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.F, 0) + ISNULL(SUM_PRESTACIONES_LEY.F, 0) +
    ISNULL(SUM_SUELDO.G, 0) + ISNULL(SUM_HORAS_EXTRAS.G, 0) + ISNULL(SUM_BONIFICACION.G, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.G, 0) + ISNULL(SUM_PRESTACIONES_LEY.G, 0) +
    ISNULL(SUM_SUELDO.H, 0) + ISNULL(SUM_HORAS_EXTRAS.H, 0) + ISNULL(SUM_BONIFICACION.H, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.H, 0) + ISNULL(SUM_PRESTACIONES_LEY.H, 0) +
    ISNULL(SUM_SUELDO.I, 0) + ISNULL(SUM_HORAS_EXTRAS.I, 0) + ISNULL(SUM_BONIFICACION.I, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.I, 0) + ISNULL(SUM_PRESTACIONES_LEY.I, 0) +
    ISNULL(SUM_SUELDO.J, 0) + ISNULL(SUM_HORAS_EXTRAS.J, 0) + ISNULL(SUM_BONIFICACION.J, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.J, 0) + ISNULL(SUM_PRESTACIONES_LEY.J, 0) +
    ISNULL(SUM_SUELDO.K, 0) + ISNULL(SUM_HORAS_EXTRAS.K, 0) + ISNULL(SUM_BONIFICACION.K, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.K, 0) + ISNULL(SUM_PRESTACIONES_LEY.K, 0) +
    ISNULL(SUM_SUELDO.M, 0) + ISNULL(SUM_HORAS_EXTRAS.M, 0) + ISNULL(SUM_BONIFICACION.M, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.M, 0) + ISNULL(SUM_PRESTACIONES_LEY.M, 0) +
    ISNULL(SUM_SUELDO.N, 0) + ISNULL(SUM_HORAS_EXTRAS.N, 0) + ISNULL(SUM_BONIFICACION.N, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.N, 0) + ISNULL(SUM_PRESTACIONES_LEY.N, 0) +
    ISNULL(SUM_SUELDO.O, 0) + ISNULL(SUM_HORAS_EXTRAS.O, 0) + ISNULL(SUM_BONIFICACION.O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.O, 0) + ISNULL(SUM_PRESTACIONES_LEY.O, 0) +
    ISNULL(SUM_SUELDO.TF_O, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_O, 0) + ISNULL(SUM_BONIFICACION.TF_O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_O, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_O, 0) +
    ISNULL(SUM_SUELDO.P, 0) + ISNULL(SUM_HORAS_EXTRAS.P, 0) + ISNULL(SUM_BONIFICACION.P, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.P, 0) + ISNULL(SUM_PRESTACIONES_LEY.P, 0) +
    ISNULL(SUM_SUELDO.Q, 0) + ISNULL(SUM_HORAS_EXTRAS.Q, 0) + ISNULL(SUM_BONIFICACION.Q, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.Q, 0) + ISNULL(SUM_PRESTACIONES_LEY.Q, 0) +
    ISNULL(SUM_SUELDO.TF_Q, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_Q, 0) + ISNULL(SUM_BONIFICACION.TF_Q, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_Q, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_Q, 0) +
    ISNULL(SUM_SUELDO.R, 0) + ISNULL(SUM_HORAS_EXTRAS.R, 0) + ISNULL(SUM_BONIFICACION.R, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.R, 0) + ISNULL(SUM_PRESTACIONES_LEY.R, 0) +
    ISNULL(SUM_SUELDO.T, 0) + ISNULL(SUM_HORAS_EXTRAS.T, 0) + ISNULL(SUM_BONIFICACION.T, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.T, 0) + ISNULL(SUM_PRESTACIONES_LEY.T, 0) +
    ISNULL(SUM_SUELDO.TF_T, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_T, 0) + ISNULL(SUM_BONIFICACION.TF_T, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_T, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_T, 0) +
    ISNULL(SUM_SUELDO.U, 0) + ISNULL(SUM_HORAS_EXTRAS.U, 0) + ISNULL(SUM_BONIFICACION.U, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.U, 0) + ISNULL(SUM_PRESTACIONES_LEY.U, 0) +
    ISNULL(SUM_SUELDO.TF_U, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_U, 0) + ISNULL(SUM_BONIFICACION.TF_U, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_U, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_U, 0) +
    ISNULL(SUM_SUELDO.W, 0) + ISNULL(SUM_HORAS_EXTRAS.W, 0) + ISNULL(SUM_BONIFICACION.W, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.W, 0) + ISNULL(SUM_PRESTACIONES_LEY.W, 0) +
    ISNULL(SUM_SUELDO.TF_W, 0) + ISNULL(SUM_HORAS_EXTRAS.TF_W, 0) + ISNULL(SUM_BONIFICACION.TF_W, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.TF_W, 0) + ISNULL(SUM_PRESTACIONES_LEY.TF_W, 0) +
    ISNULL(SUM_SUELDO.IN_A, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_A, 0) + ISNULL(SUM_BONIFICACION.IN_A, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_A, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_A, 0) +
    ISNULL(SUM_SUELDO.IN_B, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_B, 0) + ISNULL(SUM_BONIFICACION.IN_B, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_B, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_B, 0) +
    ISNULL(SUM_SUELDO.IN_C, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_C, 0) + ISNULL(SUM_BONIFICACION.IN_C, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_C, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_C, 0) +
    ISNULL(SUM_SUELDO.IN_D, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_D, 0) + ISNULL(SUM_BONIFICACION.IN_D, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_D, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_D, 0) +
    ISNULL(SUM_SUELDO.IN_E, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_E, 0) + ISNULL(SUM_BONIFICACION.IN_E, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_E, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_E, 0) +
    ISNULL(SUM_SUELDO.IN_F, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_F, 0) + ISNULL(SUM_BONIFICACION.IN_F, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_F, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_F, 0) +
    ISNULL(SUM_SUELDO.IN_H, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_H, 0) + ISNULL(SUM_BONIFICACION.IN_H, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_H, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_H, 0) +
    ISNULL(SUM_SUELDO.IN_I, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_I, 0) + ISNULL(SUM_BONIFICACION.IN_I, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_I, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_I, 0) +
    ISNULL(SUM_SUELDO.IN_J, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_J, 0) + ISNULL(SUM_BONIFICACION.IN_J, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_J, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_J, 0) +
    ISNULL(SUM_SUELDO.IN_K, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_K, 0) + ISNULL(SUM_BONIFICACION.IN_K, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_K, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_K, 0) +
    ISNULL(SUM_SUELDO.IN_M, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_M, 0) + ISNULL(SUM_BONIFICACION.IN_M, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_M, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_M, 0) +
    ISNULL(SUM_SUELDO.IN_O, 0) + ISNULL(SUM_HORAS_EXTRAS.IN_O, 0) + ISNULL(SUM_BONIFICACION.IN_O, 0) + ISNULL(SUM_BONIFICACION_PRODUCCION.IN_O, 0) + ISNULL(SUM_PRESTACIONES_LEY.IN_O, 0))
	AS TOTAL
INTO #TotalTemporal
FROM 
(
    SELECT * FROM #SueldoTemporal
) AS SUM_SUELDO
INNER JOIN 
(
    SELECT * FROM #HorasExtrasTemporal
) AS SUM_HORAS_EXTRAS ON 1=1
INNER JOIN 
(
    SELECT * FROM #BonificacionTemporal
) AS SUM_BONIFICACION ON 1=1
INNER JOIN 
(
    SELECT * FROM #BonificacionProduccionTemporal
) AS SUM_BONIFICACION_PRODUCCION ON 1=1
INNER JOIN 
(
    SELECT * FROM #PrestacionesLeyTemporal
) AS SUM_PRESTACIONES_LEY ON 1=1;


-- Fila 'COSTO POR OPERARIO'
SELECT
    'COSTO POR OPERARIO' AS DATO,
    ISNULL(CAST(TOTAL.A AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.A, 0) / @tipo_cambio, 0) AS A,
    ISNULL(CAST(TOTAL.B AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.B, 0) / @tipo_cambio, 0) AS B,
    ISNULL(CAST(TOTAL.C AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.C, 0) / @tipo_cambio, 0) AS C,
    ISNULL(CAST(TOTAL.D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.D, 0) / @tipo_cambio, 0) AS D,
    ISNULL(CAST(TOTAL.TF_D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_D, 0) / @tipo_cambio, 0) AS TF_D,
    ISNULL(CAST(TOTAL.E AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.E, 0) / @tipo_cambio, 0) AS E,
    ISNULL(CAST(TOTAL.F AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.F, 0) / @tipo_cambio, 0) AS F,
    ISNULL(CAST(TOTAL.G AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.G, 0) / @tipo_cambio, 0) AS G,
    ISNULL(CAST(TOTAL.H AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.H, 0) / @tipo_cambio, 0) AS H,
    ISNULL(CAST(TOTAL.I AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.I, 0) / @tipo_cambio, 0) AS I,
    ISNULL(CAST(TOTAL.J AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.J, 0) / @tipo_cambio, 0) AS J,
    ISNULL(CAST(TOTAL.K AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.K, 0) / @tipo_cambio, 0) AS K,
    ISNULL(CAST(TOTAL.M AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.M, 0) / @tipo_cambio, 0) AS M,
    ISNULL(CAST(TOTAL.N AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.N, 0) / @tipo_cambio, 0) AS N,
    ISNULL(CAST(TOTAL.O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.O, 0) / @tipo_cambio, 0) AS O,
    ISNULL(CAST(TOTAL.TF_O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_O, 0) / @tipo_cambio, 0) AS TF_O,
    ISNULL(CAST(TOTAL.P AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.P, 0) / @tipo_cambio, 0) AS P,
    ISNULL(CAST(TOTAL.Q AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.Q, 0) / @tipo_cambio, 0) AS Q,
    ISNULL(CAST(TOTAL.TF_Q AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_Q, 0) / @tipo_cambio, 0) AS TF_Q,
    ISNULL(CAST(TOTAL.R AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.R, 0) / @tipo_cambio, 0) AS R,
    ISNULL(CAST(TOTAL.T AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.T, 0) / @tipo_cambio, 0) AS T,
    ISNULL(CAST(TOTAL.TF_T AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_T, 0) / @tipo_cambio, 0) AS TF_T,
    ISNULL(CAST(TOTAL.U AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.U, 0) / @tipo_cambio, 0) AS U,
    ISNULL(CAST(TOTAL.TF_U AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_U, 0) / @tipo_cambio, 0) AS TF_U,
    ISNULL(CAST(TOTAL.W AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.W, 0) / @tipo_cambio, 0) AS W,
    ISNULL(CAST(TOTAL.TF_W AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_W, 0) / @tipo_cambio, 0) AS TF_W,
    ISNULL(CAST(TOTAL.IN_A AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_A, 0) / @tipo_cambio, 0) AS IN_A,
    ISNULL(CAST(TOTAL.IN_B AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_B, 0) / @tipo_cambio, 0) AS IN_B,
    ISNULL(CAST(TOTAL.IN_C AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_C, 0) / @tipo_cambio, 0) AS IN_C,
    ISNULL(CAST(TOTAL.IN_D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_D, 0) / @tipo_cambio, 0) AS IN_D,
    ISNULL(CAST(TOTAL.IN_E AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_E, 0) / @tipo_cambio, 0) AS IN_E,
    ISNULL(CAST(TOTAL.IN_F AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_F, 0) / @tipo_cambio, 0) AS IN_F,
    ISNULL(CAST(TOTAL.IN_H AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_H, 0) / @tipo_cambio, 0) AS IN_H,
    ISNULL(CAST(TOTAL.IN_I AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_I, 0) / @tipo_cambio, 0) AS IN_I,
    ISNULL(CAST(TOTAL.IN_J AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_J, 0) / @tipo_cambio, 0) AS IN_J,
    ISNULL(CAST(TOTAL.IN_K AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_K, 0) / @tipo_cambio, 0) AS IN_K,
    ISNULL(CAST(TOTAL.IN_M AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_M, 0) / @tipo_cambio, 0) AS IN_M,
    ISNULL(CAST(TOTAL.IN_O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_O, 0) / @tipo_cambio, 0) AS IN_O,
	---
	(
	ISNULL(CAST(TOTAL.A AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.A, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.B AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.B, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.C AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.C, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.D, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_D, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.E AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.E, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.F AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.F, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.G AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.G, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.H AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.H, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.I AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.I, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.J AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.J, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.K AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.K, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.M AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.M, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.N AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.N, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.O, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_O, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.P AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.P, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.Q AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.Q, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_Q AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_Q, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.R AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.R, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.T AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.T, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_T AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_T, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.U AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.U, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_U AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_U, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.W AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.W, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.TF_W AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.TF_W, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_A AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_A, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_B AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_B, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_C AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_C, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_D AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_D, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_E AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_E, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_F AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_F, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_H AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_H, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_I AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_I, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_J AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_J, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_K AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_K, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_M AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_M, 0) / @tipo_cambio, 0) +
    ISNULL(CAST(TOTAL.IN_O AS DECIMAL(18, 2)) / NULLIF(OPERARIOS.IN_O, 0) / @tipo_cambio, 0)) AS TOTAL
INTO #CostoPorOperarioTemporal
FROM #TotalTemporal AS TOTAL
INNER JOIN #OperariosTemporal AS OPERARIOS ON 1=1;


-- Fila 'COSTO Q'
SELECT
    'COSTO Q' AS DATO,
    ISNULL(CAST(TOTAL.A AS DECIMAL(18, 2)) / NULLIF(PRENDAS.A, 0), 0) AS A,
    ISNULL(CAST(TOTAL.B AS DECIMAL(18, 2)) / NULLIF(PRENDAS.B, 0), 0) AS B,
    ISNULL(CAST(TOTAL.C AS DECIMAL(18, 2)) / NULLIF(PRENDAS.C, 0), 0) AS C,
    ISNULL(CAST(TOTAL.D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.D, 0), 0) AS D,
    ISNULL(CAST(TOTAL.TF_D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_D, 0), 0) AS TF_D,
    ISNULL(CAST(TOTAL.E AS DECIMAL(18, 2)) / NULLIF(PRENDAS.E, 0), 0) AS E,
    ISNULL(CAST(TOTAL.F AS DECIMAL(18, 2)) / NULLIF(PRENDAS.F, 0), 0) AS F,
    ISNULL(CAST(TOTAL.G AS DECIMAL(18, 2)) / NULLIF(PRENDAS.G, 0), 0) AS G,
    ISNULL(CAST(TOTAL.H AS DECIMAL(18, 2)) / NULLIF(PRENDAS.H, 0), 0) AS H,
    ISNULL(CAST(TOTAL.I AS DECIMAL(18, 2)) / NULLIF(PRENDAS.I, 0), 0) AS I,
    ISNULL(CAST(TOTAL.J AS DECIMAL(18, 2)) / NULLIF(PRENDAS.J, 0), 0) AS J,
    ISNULL(CAST(TOTAL.K AS DECIMAL(18, 2)) / NULLIF(PRENDAS.K, 0), 0) AS K,
    ISNULL(CAST(TOTAL.M AS DECIMAL(18, 2)) / NULLIF(PRENDAS.M, 0), 0) AS M,
    ISNULL(CAST(TOTAL.N AS DECIMAL(18, 2)) / NULLIF(PRENDAS.N, 0), 0) AS N,
    ISNULL(CAST(TOTAL.O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.O, 0), 0) AS O,
    ISNULL(CAST(TOTAL.TF_O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_O, 0), 0) AS TF_O,
    ISNULL(CAST(TOTAL.P AS DECIMAL(18, 2)) / NULLIF(PRENDAS.P, 0), 0) AS P,
    ISNULL(CAST(TOTAL.Q AS DECIMAL(18, 2)) / NULLIF(PRENDAS.Q, 0), 0) AS Q,
    ISNULL(CAST(TOTAL.TF_Q AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_Q, 0), 0) AS TF_Q,
    ISNULL(CAST(TOTAL.R AS DECIMAL(18, 2)) / NULLIF(PRENDAS.R, 0), 0) AS R,
    ISNULL(CAST(TOTAL.T AS DECIMAL(18, 2)) / NULLIF(PRENDAS.T, 0), 0) AS T,
    ISNULL(CAST(TOTAL.TF_T AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_T, 0), 0) AS TF_T,
    ISNULL(CAST(TOTAL.U AS DECIMAL(18, 2)) / NULLIF(PRENDAS.U, 0), 0) AS U,
    ISNULL(CAST(TOTAL.TF_U AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_U, 0), 0) AS TF_U,
    ISNULL(CAST(TOTAL.W AS DECIMAL(18, 2)) / NULLIF(PRENDAS.W, 0), 0) AS W,
    ISNULL(CAST(TOTAL.TF_W AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_W, 0), 0) AS TF_W,
    ISNULL(CAST(TOTAL.IN_A AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_A, 0), 0) AS IN_A,
    ISNULL(CAST(TOTAL.IN_B AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_B, 0), 0) AS IN_B,
    ISNULL(CAST(TOTAL.IN_C AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_C, 0), 0) AS IN_C,
    ISNULL(CAST(TOTAL.IN_D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_D, 0), 0) AS IN_D,
    ISNULL(CAST(TOTAL.IN_E AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_E, 0), 0) AS IN_E,
    ISNULL(CAST(TOTAL.IN_F AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_F, 0), 0) AS IN_F,
    ISNULL(CAST(TOTAL.IN_H AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_H, 0), 0) AS IN_H,
    ISNULL(CAST(TOTAL.IN_I AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_I, 0), 0) AS IN_I,
    ISNULL(CAST(TOTAL.IN_J AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_J, 0), 0) AS IN_J,
    ISNULL(CAST(TOTAL.IN_K AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_K, 0), 0) AS IN_K,
    ISNULL(CAST(TOTAL.IN_M AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_M, 0), 0) AS IN_M,
    ISNULL(CAST(TOTAL.IN_O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_O, 0), 0) AS IN_O,
	-----
	(
    ISNULL(CAST(TOTAL.A AS DECIMAL(18, 2)) / NULLIF(PRENDAS.A, 0), 0) +
    ISNULL(CAST(TOTAL.B AS DECIMAL(18, 2)) / NULLIF(PRENDAS.B, 0), 0) +
    ISNULL(CAST(TOTAL.C AS DECIMAL(18, 2)) / NULLIF(PRENDAS.C, 0), 0) +
    ISNULL(CAST(TOTAL.D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.D, 0), 0) +
    ISNULL(CAST(TOTAL.TF_D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_D, 0), 0) +
    ISNULL(CAST(TOTAL.E AS DECIMAL(18, 2)) / NULLIF(PRENDAS.E, 0), 0) +
    ISNULL(CAST(TOTAL.F AS DECIMAL(18, 2)) / NULLIF(PRENDAS.F, 0), 0) +
    ISNULL(CAST(TOTAL.G AS DECIMAL(18, 2)) / NULLIF(PRENDAS.G, 0), 0) +
    ISNULL(CAST(TOTAL.H AS DECIMAL(18, 2)) / NULLIF(PRENDAS.H, 0), 0) +
    ISNULL(CAST(TOTAL.I AS DECIMAL(18, 2)) / NULLIF(PRENDAS.I, 0), 0) +
    ISNULL(CAST(TOTAL.J AS DECIMAL(18, 2)) / NULLIF(PRENDAS.J, 0), 0) +
    ISNULL(CAST(TOTAL.K AS DECIMAL(18, 2)) / NULLIF(PRENDAS.K, 0), 0) +
    ISNULL(CAST(TOTAL.M AS DECIMAL(18, 2)) / NULLIF(PRENDAS.M, 0), 0) +
    ISNULL(CAST(TOTAL.N AS DECIMAL(18, 2)) / NULLIF(PRENDAS.N, 0), 0) +
    ISNULL(CAST(TOTAL.O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.O, 0), 0) +
    ISNULL(CAST(TOTAL.TF_O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_O, 0), 0) +
    ISNULL(CAST(TOTAL.P AS DECIMAL(18, 2)) / NULLIF(PRENDAS.P, 0), 0) +
    ISNULL(CAST(TOTAL.Q AS DECIMAL(18, 2)) / NULLIF(PRENDAS.Q, 0), 0) +
    ISNULL(CAST(TOTAL.TF_Q AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_Q, 0), 0) +
    ISNULL(CAST(TOTAL.R AS DECIMAL(18, 2)) / NULLIF(PRENDAS.R, 0), 0) +
    ISNULL(CAST(TOTAL.T AS DECIMAL(18, 2)) / NULLIF(PRENDAS.T, 0), 0) +
    ISNULL(CAST(TOTAL.TF_T AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_T, 0), 0) +
    ISNULL(CAST(TOTAL.U AS DECIMAL(18, 2)) / NULLIF(PRENDAS.U, 0), 0) +
    ISNULL(CAST(TOTAL.TF_U AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_U, 0), 0) +
    ISNULL(CAST(TOTAL.W AS DECIMAL(18, 2)) / NULLIF(PRENDAS.W, 0), 0) +
    ISNULL(CAST(TOTAL.TF_W AS DECIMAL(18, 2)) / NULLIF(PRENDAS.TF_W, 0), 0) +
    ISNULL(CAST(TOTAL.IN_A AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_A, 0), 0) +
    ISNULL(CAST(TOTAL.IN_B AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_B, 0), 0) +
    ISNULL(CAST(TOTAL.IN_C AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_C, 0), 0) +
    ISNULL(CAST(TOTAL.IN_D AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_D, 0), 0) +
    ISNULL(CAST(TOTAL.IN_E AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_E, 0), 0) +
    ISNULL(CAST(TOTAL.IN_F AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_F, 0), 0) +
    ISNULL(CAST(TOTAL.IN_H AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_H, 0), 0) +
    ISNULL(CAST(TOTAL.IN_I AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_I, 0), 0) +
    ISNULL(CAST(TOTAL.IN_J AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_J, 0), 0) +
    ISNULL(CAST(TOTAL.IN_K AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_K, 0), 0) +
    ISNULL(CAST(TOTAL.IN_M AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_M, 0), 0) +
    ISNULL(CAST(TOTAL.IN_O AS DECIMAL(18, 2)) / NULLIF(PRENDAS.IN_O, 0), 0)) AS TOTAL
INTO #CostoQTemporal
FROM #TotalTemporal AS TOTAL
INNER JOIN #PrendasTemporal AS PRENDAS ON 1=1;


-- Fila 'COSTO $'
SELECT
    'COSTO $' AS DATO,
    ISNULL(CAST(CQ.A AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS A,
    ISNULL(CAST(CQ.B AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS B,
    ISNULL(CAST(CQ.C AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS C,
    ISNULL(CAST(CQ.D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS D,
    ISNULL(CAST(CQ.TF_D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_D,
    ISNULL(CAST(CQ.E AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS E,
    ISNULL(CAST(CQ.F AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS F,
    ISNULL(CAST(CQ.G AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS G,
    ISNULL(CAST(CQ.H AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS H,
    ISNULL(CAST(CQ.I AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS I,
    ISNULL(CAST(CQ.J AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS J,
    ISNULL(CAST(CQ.K AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS K,
    ISNULL(CAST(CQ.M AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS M,
    ISNULL(CAST(CQ.N AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS N,
    ISNULL(CAST(CQ.O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS O,
    ISNULL(CAST(CQ.TF_O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_O,
    ISNULL(CAST(CQ.P AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS P,
    ISNULL(CAST(CQ.Q AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS Q,
    ISNULL(CAST(CQ.TF_Q AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_Q,
    ISNULL(CAST(CQ.R AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS R,
    ISNULL(CAST(CQ.T AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS T,
    ISNULL(CAST(CQ.TF_T AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_T,
    ISNULL(CAST(CQ.U AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS U,
    ISNULL(CAST(CQ.TF_U AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_U,
    ISNULL(CAST(CQ.W AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS W,
    ISNULL(CAST(CQ.TF_W AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS TF_W,
    ISNULL(CAST(CQ.IN_A AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_A,
    ISNULL(CAST(CQ.IN_B AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_B,
    ISNULL(CAST(CQ.IN_C AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_C,
    ISNULL(CAST(CQ.IN_D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_D,
    ISNULL(CAST(CQ.IN_E AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_E,
    ISNULL(CAST(CQ.IN_F AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_F,
    ISNULL(CAST(CQ.IN_H AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_H,
    ISNULL(CAST(CQ.IN_I AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_I,
    ISNULL(CAST(CQ.IN_J AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_J,
    ISNULL(CAST(CQ.IN_K AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_K,
    ISNULL(CAST(CQ.IN_M AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_M,
    ISNULL(CAST(CQ.IN_O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) AS IN_O,
	-----
	(
	ISNULL(CAST(CQ.A AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.B AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.C AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.E AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.F AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.G AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.H AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.I AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.J AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.K AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.M AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.N AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.P AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.Q AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_Q AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.R AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.T AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_T AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.U AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_U AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.W AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.TF_W AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_A AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_B AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_C AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_D AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_E AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_F AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_H AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_I AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_J AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_K AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_M AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0) +
    ISNULL(CAST(CQ.IN_O AS DECIMAL(18, 2)) / NULLIF(@tipo_cambio, 0), 0)) AS TOTAL
INTO #CostoDolarTemporal
FROM #CostoQTemporal AS CQ;


-- Fila 'PRECIO UNITARIO $'
SELECT
    'PRECIO UNITARIO $' AS DATO,
    ISNULL(AVG(CASE WHEN P.SECCION = 'A' THEN P.VALOR ELSE NULL END), 0) AS A,
    ISNULL(AVG(CASE WHEN P.SECCION = 'B' THEN P.VALOR ELSE NULL END), 0) AS B,
    ISNULL(AVG(CASE WHEN P.SECCION = 'C' THEN P.VALOR ELSE NULL END), 0) AS C,
    ISNULL(AVG(CASE WHEN P.SECCION = 'D' THEN P.VALOR ELSE NULL END), 0) AS D,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_D' THEN P.VALOR ELSE NULL END), 0) AS TF_D,
    ISNULL(AVG(CASE WHEN P.SECCION = 'E' THEN P.VALOR ELSE NULL END), 0) AS E,
    ISNULL(AVG(CASE WHEN P.SECCION = 'F' THEN P.VALOR ELSE NULL END), 0) AS F,
    ISNULL(AVG(CASE WHEN P.SECCION = 'G' THEN P.VALOR ELSE NULL END), 0) AS G,
    ISNULL(AVG(CASE WHEN P.SECCION = 'H' THEN P.VALOR ELSE NULL END), 0) AS H,
    ISNULL(AVG(CASE WHEN P.SECCION = 'I' THEN P.VALOR ELSE NULL END), 0) AS I,
    ISNULL(AVG(CASE WHEN P.SECCION = 'J' THEN P.VALOR ELSE NULL END), 0) AS J,
    ISNULL(AVG(CASE WHEN P.SECCION = 'K' THEN P.VALOR ELSE NULL END), 0) AS K,
    ISNULL(AVG(CASE WHEN P.SECCION = 'M' THEN P.VALOR ELSE NULL END), 0) AS M,
    ISNULL(AVG(CASE WHEN P.SECCION = 'N' THEN P.VALOR ELSE NULL END), 0) AS N,
    ISNULL(AVG(CASE WHEN P.SECCION = 'O' THEN P.VALOR ELSE NULL END), 0) AS O,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_O' THEN P.VALOR ELSE NULL END), 0) AS TF_O,
    ISNULL(AVG(CASE WHEN P.SECCION = 'P' THEN P.VALOR ELSE NULL END), 0) AS P,
    ISNULL(AVG(CASE WHEN P.SECCION = 'Q' THEN P.VALOR ELSE NULL END), 0) AS Q,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_Q' THEN P.VALOR ELSE NULL END), 0) AS TF_Q,
    ISNULL(AVG(CASE WHEN P.SECCION = 'R' THEN P.VALOR ELSE NULL END), 0) AS R,
    ISNULL(AVG(CASE WHEN P.SECCION = 'T' THEN P.VALOR ELSE NULL END), 0) AS T,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_T' THEN P.VALOR ELSE NULL END), 0) AS TF_T,
    ISNULL(AVG(CASE WHEN P.SECCION = 'U' THEN P.VALOR ELSE NULL END), 0) AS U,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_U' THEN P.VALOR ELSE NULL END), 0) AS TF_U,
    ISNULL(AVG(CASE WHEN P.SECCION = 'W' THEN P.VALOR ELSE NULL END), 0) AS W,
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_W' THEN P.VALOR ELSE NULL END), 0) AS TF_W,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_A' THEN P.VALOR ELSE NULL END), 0) AS IN_A,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_B' THEN P.VALOR ELSE NULL END), 0) AS IN_B,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_C' THEN P.VALOR ELSE NULL END), 0) AS IN_C,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_D' THEN P.VALOR ELSE NULL END), 0) AS IN_D,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_E' THEN P.VALOR ELSE NULL END), 0) AS IN_E,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_F' THEN P.VALOR ELSE NULL END), 0) AS IN_F,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_H' THEN P.VALOR ELSE NULL END), 0) AS IN_H,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_I' THEN P.VALOR ELSE NULL END), 0) AS IN_I,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_J' THEN P.VALOR ELSE NULL END), 0) AS IN_J,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_K' THEN P.VALOR ELSE NULL END), 0) AS IN_K,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_M' THEN P.VALOR ELSE NULL END), 0) AS IN_M,
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_O' THEN P.VALOR ELSE NULL END), 0) AS IN_O,
	---------
	(
	ISNULL(AVG(CASE WHEN P.SECCION = 'A' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'B' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'C' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'D' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_D' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'E' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'F' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'G' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'H' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'I' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'J' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'K' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'M' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'N' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'O' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_O' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'P' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'Q' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_Q' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'R' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'T' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_T' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'U' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_U' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'W' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'TF_W' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_A' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_B' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_C' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_D' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_E' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_F' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_H' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_I' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_J' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_K' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_M' THEN P.VALOR ELSE NULL END), 0) +
    ISNULL(AVG(CASE WHEN P.SECCION = 'IN_O' THEN P.VALOR ELSE NULL END), 0)) AS TOTAL
INTO #PrecioUnitarioDolarTemporal
FROM 
    [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P
WHERE 
    P.FECHA BETWEEN @fec_inicio AND @fec_final;


-- Fila 'COSTO/PRECIO'
SELECT
    'COSTO/PRECIO' AS DATO,
    ISNULL(ROUND((CPQ.A / NULLIF(PU.A, 0)) * 100, 0), 0) AS A,
    ISNULL(ROUND((CPQ.B / NULLIF(PU.B, 0)) * 100, 0), 0) AS B,
    ISNULL(ROUND((CPQ.C / NULLIF(PU.C, 0)) * 100, 0), 0) AS C,
    ISNULL(ROUND((CPQ.D / NULLIF(PU.D, 0)) * 100, 0), 0) AS D,
    ISNULL(ROUND((CPQ.TF_D / NULLIF(PU.TF_D, 0)) * 100, 0), 0) AS TF_D,
    ISNULL(ROUND((CPQ.E / NULLIF(PU.E, 0)) * 100, 0), 0) AS E,
    ISNULL(ROUND((CPQ.F / NULLIF(PU.F, 0)) * 100, 0), 0) AS F,
    ISNULL(ROUND((CPQ.G / NULLIF(PU.G, 0)) * 100, 0), 0) AS G,
    ISNULL(ROUND((CPQ.H / NULLIF(PU.H, 0)) * 100, 0), 0) AS H,
    ISNULL(ROUND((CPQ.I / NULLIF(PU.I, 0)) * 100, 0), 0) AS I,
    ISNULL(ROUND((CPQ.J / NULLIF(PU.J, 0)) * 100, 0), 0) AS J,
    ISNULL(ROUND((CPQ.K / NULLIF(PU.K, 0)) * 100, 0), 0) AS K,
    ISNULL(ROUND((CPQ.M / NULLIF(PU.M, 0)) * 100, 0), 0) AS M,
    ISNULL(ROUND((CPQ.N / NULLIF(PU.N, 0)) * 100, 0), 0) AS N,
    ISNULL(ROUND((CPQ.O / NULLIF(PU.O, 0)) * 100, 0), 0) AS O,
    ISNULL(ROUND((CPQ.TF_O / NULLIF(PU.TF_O, 0)) * 100, 0), 0) AS TF_O,
    ISNULL(ROUND((CPQ.P / NULLIF(PU.P, 0)) * 100, 0), 0) AS P,
    ISNULL(ROUND((CPQ.Q / NULLIF(PU.Q, 0)) * 100, 0), 0) AS Q,
    ISNULL(ROUND((CPQ.TF_Q / NULLIF(PU.TF_Q, 0)) * 100, 0), 0) AS TF_Q,
    ISNULL(ROUND((CPQ.R / NULLIF(PU.R, 0)) * 100, 0), 0) AS R,
    ISNULL(ROUND((CPQ.T / NULLIF(PU.T, 0)) * 100, 0), 0) AS T,
    ISNULL(ROUND((CPQ.TF_T / NULLIF(PU.TF_T, 0)) * 100, 0), 0) AS TF_T,
    ISNULL(ROUND((CPQ.U / NULLIF(PU.U, 0)) * 100, 0), 0) AS U,
    ISNULL(ROUND((CPQ.TF_U / NULLIF(PU.TF_U, 0)) * 100, 0), 0) AS TF_U,
    ISNULL(ROUND((CPQ.W / NULLIF(PU.W, 0)) * 100, 0), 0) AS W,
    ISNULL(ROUND((CPQ.TF_W / NULLIF(PU.TF_W, 0)) * 100, 0), 0) AS TF_W,
    ISNULL(ROUND((CPQ.IN_A / NULLIF(PU.IN_A, 0)) * 100, 0), 0) AS IN_A,
    ISNULL(ROUND((CPQ.IN_B / NULLIF(PU.IN_B, 0)) * 100, 0), 0) AS IN_B,
    ISNULL(ROUND((CPQ.IN_C / NULLIF(PU.IN_C, 0)) * 100, 0), 0) AS IN_C,
    ISNULL(ROUND((CPQ.IN_D / NULLIF(PU.IN_D, 0)) * 100, 0), 0) AS IN_D,
    ISNULL(ROUND((CPQ.IN_E / NULLIF(PU.IN_E, 0)) * 100, 0), 0) AS IN_E,
    ISNULL(ROUND((CPQ.IN_F / NULLIF(PU.IN_F, 0)) * 100, 0), 0) AS IN_F,
    ISNULL(ROUND((CPQ.IN_H / NULLIF(PU.IN_H, 0)) * 100, 0), 0) AS IN_H,
    ISNULL(ROUND((CPQ.IN_I / NULLIF(PU.IN_I, 0)) * 100, 0), 0) AS IN_I,
    ISNULL(ROUND((CPQ.IN_J / NULLIF(PU.IN_J, 0)) * 100, 0), 0) AS IN_J,
    ISNULL(ROUND((CPQ.IN_K / NULLIF(PU.IN_K, 0)) * 100, 0), 0) AS IN_K,
    ISNULL(ROUND((CPQ.IN_M / NULLIF(PU.IN_M, 0)) * 100, 0), 0) AS IN_M,
    ISNULL(ROUND((CPQ.IN_O / NULLIF(PU.IN_O, 0)) * 100, 0), 0) AS IN_O,
	----------
	(
	ISNULL(ROUND((CPQ.A / NULLIF(PU.A, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.B / NULLIF(PU.B, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.C / NULLIF(PU.C, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.D / NULLIF(PU.D, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_D / NULLIF(PU.TF_D, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.E / NULLIF(PU.E, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.F / NULLIF(PU.F, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.G / NULLIF(PU.G, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.H / NULLIF(PU.H, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.I / NULLIF(PU.I, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.J / NULLIF(PU.J, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.K / NULLIF(PU.K, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.M / NULLIF(PU.M, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.N / NULLIF(PU.N, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.O / NULLIF(PU.O, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_O / NULLIF(PU.TF_O, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.P / NULLIF(PU.P, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.Q / NULLIF(PU.Q, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_Q / NULLIF(PU.TF_Q, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.R / NULLIF(PU.R, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.T / NULLIF(PU.T, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_T / NULLIF(PU.TF_T, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.U / NULLIF(PU.U, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_U / NULLIF(PU.TF_U, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.W / NULLIF(PU.W, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.TF_W / NULLIF(PU.TF_W, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_A / NULLIF(PU.IN_A, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_B / NULLIF(PU.IN_B, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_C / NULLIF(PU.IN_C, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_D / NULLIF(PU.IN_D, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_E / NULLIF(PU.IN_E, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_F / NULLIF(PU.IN_F, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_H / NULLIF(PU.IN_H, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_I / NULLIF(PU.IN_I, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_J / NULLIF(PU.IN_J, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_K / NULLIF(PU.IN_K, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_M / NULLIF(PU.IN_M, 0)) * 100, 0), 0) +
    ISNULL(ROUND((CPQ.IN_O / NULLIF(PU.IN_O, 0)) * 100, 0), 0)) AS TOTAL
INTO #CostoPorPrecioTemporal
FROM #CostoDolarTemporal AS CPQ
INNER JOIN #PrecioUnitarioDolarTemporal AS PU ON 1=1;


-- Fila 'APORTACION UNITARIA'
SELECT
    'APORTACION UNITARIA' AS DATO,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'A' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.A / @tipo_cambio), 0) AS A,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'B' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.B / @tipo_cambio), 0) AS B,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'C' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.C / @tipo_cambio), 0) AS C,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.D / @tipo_cambio), 0) AS D,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_D / @tipo_cambio), 0) AS TF_D,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'E' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.E / @tipo_cambio), 0) AS E,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'F' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.F / @tipo_cambio), 0) AS F,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'G' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.G / @tipo_cambio), 0) AS G,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'H' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.H / @tipo_cambio), 0) AS H,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'I' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.I / @tipo_cambio), 0) AS I,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'J' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.J / @tipo_cambio), 0) AS J,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'K' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.K / @tipo_cambio), 0) AS K,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'M' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.M / @tipo_cambio), 0) AS M,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'N' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.N / @tipo_cambio), 0) AS N,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.O / @tipo_cambio), 0) AS O,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_O / @tipo_cambio), 0) AS TF_O,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'P' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.P / @tipo_cambio), 0) AS P,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'Q' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.Q / @tipo_cambio), 0) AS Q,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_Q' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_Q / @tipo_cambio), 0) AS TF_Q,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'R' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.R / @tipo_cambio), 0) AS R,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'T' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.T / @tipo_cambio), 0) AS T,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_T' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_T / @tipo_cambio), 0) AS TF_T,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'U' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.U / @tipo_cambio), 0) AS U,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_U' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_U / @tipo_cambio), 0) AS TF_U,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'W' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.W / @tipo_cambio), 0) AS W,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_W' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_W / @tipo_cambio), 0) AS TF_W,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_A' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_A / @tipo_cambio), 0) AS IN_A,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_B' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_B / @tipo_cambio), 0) AS IN_B,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_C' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_C / @tipo_cambio), 0) AS IN_C,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_D / @tipo_cambio), 0) AS IN_D,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_E' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_E / @tipo_cambio), 0) AS IN_E,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_F' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_F / @tipo_cambio), 0) AS IN_F,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_H' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_H / @tipo_cambio), 0) AS IN_H,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_I' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_I / @tipo_cambio), 0) AS IN_I,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_J' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_J / @tipo_cambio), 0) AS IN_J,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_K' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_K / @tipo_cambio), 0) AS IN_K,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_M' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_M / @tipo_cambio), 0) AS IN_M,
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_O / @tipo_cambio), 0) AS IN_O,
	-----------
	(
	ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'A' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.A / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'B' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.B / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'C' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.C / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.D / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_D / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'E' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.E / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'F' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.F / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'G' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.G / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'H' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.H / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'I' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.I / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'J' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.J / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'K' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.K / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'M' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.M / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'N' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.N / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.O / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_O / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'P' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.P / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'Q' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.Q / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_Q' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_Q / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'R' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.R / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'T' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.T / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_T' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_T / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'U' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.U / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_U' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_U / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'W' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.W / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'TF_W' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.TF_W / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_A' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_A / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_B' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_B / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_C' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_C / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_D' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_D / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_E' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_E / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_F' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_F / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_H' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_H / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_I' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_I / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_J' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_J / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_K' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_K / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_M' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_M / @tipo_cambio), 0) +
    ISNULL((SELECT AVG(P.VALOR) FROM [192.9.200.3\JT].[inventarios].[dbo].[PRODUCCION] AS P WHERE P.SECCION = 'IN_O' AND P.FECHA BETWEEN @fec_inicio AND @fec_final) - (CQ.IN_O / @tipo_cambio), 0)) AS TOTAL
INTO #AportacionUnitariaTemporal
FROM #CostoQTemporal AS CQ;


-- Fila 'TOTAL CONTRIBUCION'
SELECT
    'TOTAL CONTRIBUCION' AS DATO,
    (PU.A * PP.A) - (T.A / @tipo_cambio) AS A,
    (PU.B * PP.B) - (T.B / @tipo_cambio) AS B,
    (PU.C * PP.C) - (T.C / @tipo_cambio) AS C,
    (PU.D * PP.D) - (T.D / @tipo_cambio) AS D,
    (PU.TF_D * PP.TF_D) - (T.TF_D / @tipo_cambio) AS TF_D,
    (PU.E * PP.E) - (T.E / @tipo_cambio) AS E,
    (PU.F * PP.F) - (T.F / @tipo_cambio) AS F,
    (PU.G * PP.G) - (T.G / @tipo_cambio) AS G,
    (PU.H * PP.H) - (T.H / @tipo_cambio) AS H,
    (PU.I * PP.I) - (T.I / @tipo_cambio) AS I,
    (PU.J * PP.J) - (T.J / @tipo_cambio) AS J,
    (PU.K * PP.K) - (T.K / @tipo_cambio) AS K,
    (PU.M * PP.M) - (T.M / @tipo_cambio) AS M,
    (PU.N * PP.N) - (T.N / @tipo_cambio) AS N,
    (PU.O * PP.O) - (T.O / @tipo_cambio) AS O,
    (PU.TF_O * PP.TF_O) - (T.TF_O / @tipo_cambio) AS TF_O,
    (PU.P * PP.P) - (T.P / @tipo_cambio) AS P,
    (PU.Q * PP.Q) - (T.Q / @tipo_cambio) AS Q,
    (PU.TF_Q * PP.TF_Q) - (T.TF_Q / @tipo_cambio) AS TF_Q,
    (PU.R * PP.R) - (T.R / @tipo_cambio) AS R,
    (PU.T * PP.T) - (T.T / @tipo_cambio) AS T,
    (PU.TF_T * PP.TF_T) - (T.TF_T / @tipo_cambio) AS TF_T,
    (PU.U * PP.U) - (T.U / @tipo_cambio) AS U,
    (PU.TF_U * PP.TF_U) - (T.TF_U / @tipo_cambio) AS TF_U,
    (PU.W * PP.W) - (T.W / @tipo_cambio) AS W,
    (PU.TF_W * PP.TF_W) - (T.TF_W / @tipo_cambio) AS TF_W,
    (PU.IN_A * PP.IN_A) - (T.IN_A / @tipo_cambio) AS IN_A,
    (PU.IN_B * PP.IN_B) - (T.IN_B / @tipo_cambio) AS IN_B,
    (PU.IN_C * PP.IN_C) - (T.IN_C / @tipo_cambio) AS IN_C,
    (PU.IN_D * PP.IN_D) - (T.IN_D / @tipo_cambio) AS IN_D,
    (PU.IN_E * PP.IN_E) - (T.IN_E / @tipo_cambio) AS IN_E,
    (PU.IN_F * PP.IN_F) - (T.IN_F / @tipo_cambio) AS IN_F,
    (PU.IN_H * PP.IN_H) - (T.IN_H / @tipo_cambio) AS IN_H,
    (PU.IN_I * PP.IN_I) - (T.IN_I / @tipo_cambio) AS IN_I,
    (PU.IN_J * PP.IN_J) - (T.IN_J / @tipo_cambio) AS IN_J,
    (PU.IN_K * PP.IN_K) - (T.IN_K / @tipo_cambio) AS IN_K,
    (PU.IN_M * PP.IN_M) - (T.IN_M / @tipo_cambio) AS IN_M,
    (PU.IN_O * PP.IN_O) - (T.IN_O / @tipo_cambio) AS IN_O,
	----
	(
	(PU.A * PP.A) - (T.A / @tipo_cambio) +
    (PU.B * PP.B) - (T.B / @tipo_cambio) +
    (PU.C * PP.C) - (T.C / @tipo_cambio) +
    (PU.D * PP.D) - (T.D / @tipo_cambio) +
    (PU.TF_D * PP.TF_D) - (T.TF_D / @tipo_cambio) +
    (PU.E * PP.E) - (T.E / @tipo_cambio) +
    (PU.F * PP.F) - (T.F / @tipo_cambio) +
    (PU.G * PP.G) - (T.G / @tipo_cambio) +
    (PU.H * PP.H) - (T.H / @tipo_cambio) +
    (PU.I * PP.I) - (T.I / @tipo_cambio) +
    (PU.J * PP.J) - (T.J / @tipo_cambio) +
    (PU.K * PP.K) - (T.K / @tipo_cambio) +
    (PU.M * PP.M) - (T.M / @tipo_cambio) +
    (PU.N * PP.N) - (T.N / @tipo_cambio) +
    (PU.O * PP.O) - (T.O / @tipo_cambio) +
    (PU.TF_O * PP.TF_O) - (T.TF_O / @tipo_cambio) +
    (PU.P * PP.P) - (T.P / @tipo_cambio) +
    (PU.Q * PP.Q) - (T.Q / @tipo_cambio) +
    (PU.TF_Q * PP.TF_Q) - (T.TF_Q / @tipo_cambio) +
    (PU.R * PP.R) - (T.R / @tipo_cambio) +
    (PU.T * PP.T) - (T.T / @tipo_cambio) +
    (PU.TF_T * PP.TF_T) - (T.TF_T / @tipo_cambio) +
    (PU.U * PP.U) - (T.U / @tipo_cambio) +
    (PU.TF_U * PP.TF_U) - (T.TF_U / @tipo_cambio) +
    (PU.W * PP.W) - (T.W / @tipo_cambio) +
    (PU.TF_W * PP.TF_W) - (T.TF_W / @tipo_cambio) +
    (PU.IN_A * PP.IN_A) - (T.IN_A / @tipo_cambio) +
    (PU.IN_B * PP.IN_B) - (T.IN_B / @tipo_cambio) +
    (PU.IN_C * PP.IN_C) - (T.IN_C / @tipo_cambio) +
    (PU.IN_D * PP.IN_D) - (T.IN_D / @tipo_cambio) +
    (PU.IN_E * PP.IN_E) - (T.IN_E / @tipo_cambio) +
    (PU.IN_F * PP.IN_F) - (T.IN_F / @tipo_cambio) +
    (PU.IN_H * PP.IN_H) - (T.IN_H / @tipo_cambio) +
    (PU.IN_I * PP.IN_I) - (T.IN_I / @tipo_cambio) +
    (PU.IN_J * PP.IN_J) - (T.IN_J / @tipo_cambio) +
    (PU.IN_K * PP.IN_K) - (T.IN_K / @tipo_cambio) +
    (PU.IN_M * PP.IN_M) - (T.IN_M / @tipo_cambio) +
    (PU.IN_O * PP.IN_O) - (T.IN_O / @tipo_cambio)) AS TOTAL
INTO #TotalContribucionTemporal
FROM 
    #TotalTemporal T
CROSS APPLY 
    (SELECT 
        A, B, C, D, TF_D, E, F, G, H, I, J, K, M, N, O, TF_O, P, Q, TF_Q, R, T, TF_T, U, TF_U, W, TF_W,
        IN_A, IN_B, IN_C, IN_D, IN_E, IN_F, IN_H, IN_I, IN_J, IN_K, IN_M, IN_O, TOTAL
     FROM #PrecioUnitarioDolarTemporal) AS PU
CROSS APPLY 
    (SELECT 
        A, B, C, D, TF_D, E, F, G, H, I, J, K, M, N, O, TF_O, P, Q, TF_Q, R, T, TF_T, U, TF_U, W, TF_W,
        IN_A, IN_B, IN_C, IN_D, IN_E, IN_F, IN_H, IN_I, IN_J, IN_K, IN_M, IN_O, TOTAL
     FROM #PrendasTemporal) AS PP;


-- Creación de la tabla temporal 'ContribucionTexsunYTexfor'
CREATE TABLE #ContribucionTexsunYTexfor (
    DATO NVARCHAR(255),
    A DECIMAL(18, 2) NULL,
    B DECIMAL(18, 2) NULL,
    C DECIMAL(18, 2) NULL,
    D DECIMAL(18, 2) NULL,
    TF_D DECIMAL(18, 2) NULL,
    E DECIMAL(18, 2) NULL,
    F DECIMAL(18, 2) NULL,
    G DECIMAL(18, 2) NULL,
    H DECIMAL(18, 2) NULL,
    I DECIMAL(18, 2) NULL,
    J DECIMAL(18, 2) NULL,
    K DECIMAL(18, 2) NULL,
    M DECIMAL(18, 2) NULL,
    N DECIMAL(18, 2) NULL,
    O DECIMAL(18, 2) NULL,
    TF_O DECIMAL(18, 2) NULL,
    P DECIMAL(18, 2) NULL,
    Q DECIMAL(18, 2) NULL,
    TF_Q DECIMAL(18, 2) NULL,
    R DECIMAL(18, 2) NULL,
    T DECIMAL(18, 2) NULL,
    TF_T DECIMAL(18, 2) NULL,
    U DECIMAL(18, 2) NULL,
    TF_U DECIMAL(18, 2) NULL,
    W DECIMAL(18, 2) NULL,
    TF_W DECIMAL(18, 2) NULL,
    IN_A DECIMAL(18, 2) NULL,
    IN_B DECIMAL(18, 2) NULL,
    IN_C DECIMAL(18, 2) NULL,
    IN_D DECIMAL(18, 2) NULL,
    IN_E DECIMAL(18, 2) NULL,
    IN_F DECIMAL(18, 2) NULL,
    IN_H DECIMAL(18, 2) NULL,
    IN_I DECIMAL(18, 2) NULL,
    IN_J DECIMAL(18, 2) NULL,
    IN_K DECIMAL(18, 2) NULL,
    IN_M DECIMAL(18, 2) NULL,
    IN_O DECIMAL(18, 2) NULL,
	TOTAL DECIMAL(18, 2) NULL
);


-- Unión de todos los resultados
INSERT INTO #ContribucionTexsunYTexfor
SELECT * FROM #PrendasTemporal   
UNION ALL
SELECT * FROM #PromedioDiarioTemporal
UNION ALL
SELECT * FROM #OperariosTemporal
UNION ALL
SELECT * FROM #PrendasPorOperarioTemporal
UNION ALL
SELECT * FROM #FacturacionPorOperarioTemporal
UNION ALL
SELECT * FROM #CostoPorOperarioTemporal
UNION ALL
SELECT * FROM #SueldoTemporal
UNION ALL
SELECT * FROM #HorasExtrasTemporal
UNION ALL
SELECT * FROM #BonificacionTemporal
UNION ALL
SELECT * FROM #BonificacionProduccionTemporal
UNION ALL
SELECT * FROM #PrestacionesLeyTemporal
UNION ALL
SELECT * FROM #TotalTemporal
UNION ALL
SELECT * FROM #CostoQTemporal
UNION ALL
SELECT * FROM #CostoDolarTemporal
UNION ALL
SELECT * FROM #PrecioUnitarioDolarTemporal
UNION ALL
SELECT * FROM #CostoPorPrecioTemporal
UNION ALL
SELECT * FROM #AportacionUnitariaTemporal
UNION ALL
SELECT * FROM #TotalContribucionTemporal;

SELECT * FROM #ContribucionTexsunYTexfor;
"


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@planilla_texsun_innotex", num1)
                command.Parameters.AddWithValue("@planilla_texfor", num2)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
                Me.DataGridView1.Columns(0).Frozen = True
                Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Catch ex As Exception
                MessageBox.Show("Error al ejecutar el script: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Método para exportar a Excel usando ComponentOne
    Private Sub ButtonExport_Click(sender As Object, e As EventArgs)
        Dim path As String = "C:\reportes\contribucion.xlsx"
        Try
            ' Crear una instancia de C1FlexGrid y cargar los datos del DataGridView
            Dim flexGrid As New C1FlexGrid()
            flexGrid.Rows.Count = DataGridView1.Rows.Count + 1
            flexGrid.Cols.Count = DataGridView1.Columns.Count

            ' Copiar los encabezados de columna
            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                flexGrid(0, col) = DataGridView1.Columns(col).HeaderText
            Next

            ' Copiar los datos de las celdas
            For row As Integer = 0 To DataGridView1.Rows.Count - 1
                For col As Integer = 0 To DataGridView1.Columns.Count - 1
                    flexGrid(row + 1, col) = DataGridView1.Rows(row).Cells(col).Value
                Next
            Next

            ' Guardar el archivo Excel
            If File.Exists(path) Then
                File.Delete(path)
            End If
            flexGrid.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells)
            MessageBox.Show("Los datos se han exportado exitosamente a Excel en la ruta: " & path, "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Diagnostics.Process.Start(path)
        Catch ex As Exception
            MessageBox.Show("Error al exportar los datos a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class