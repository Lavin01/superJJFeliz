<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstTicket = New System.Windows.Forms.ListBox()
        Me.DataGridCool = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonUno = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCodigo = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridCool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1220, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Un Articulo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1114, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(304, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "50 > Articulos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstTicket
        '
        Me.lstTicket.FormattingEnabled = True
        Me.lstTicket.Location = New System.Drawing.Point(18, 21)
        Me.lstTicket.Name = "lstTicket"
        Me.lstTicket.Size = New System.Drawing.Size(360, 693)
        Me.lstTicket.TabIndex = 2
        '
        'DataGridCool
        '
        Me.DataGridCool.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridCool.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridCool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCool.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.descripcion, Me.botonUno})
        Me.DataGridCool.Location = New System.Drawing.Point(991, 366)
        Me.DataGridCool.Name = "DataGridCool"
        Me.DataGridCool.Size = New System.Drawing.Size(541, 150)
        Me.DataGridCool.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "Identificador"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'botonUno
        '
        Me.botonUno.HeaderText = "Editar"
        Me.botonUno.Name = "botonUno"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox3.Image = Global.cooool.My.Resources.Resources.bg_white_bold
        Me.PictureBox3.Location = New System.Drawing.Point(404, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(398, 710)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cooool.My.Resources.Resources.bg_500_cbold
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 739)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.cooool.My.Resources.Resources.bg_500_bold
        Me.PictureBox2.Location = New System.Drawing.Point(378, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(886, 739)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = ""
        '
        'btnCodigo
        '
        Me.btnCodigo.BackColor = System.Drawing.Color.White
        Me.btnCodigo.FlatAppearance.BorderSize = 0
        Me.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCodigo.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodigo.ForeColor = System.Drawing.Color.Green
        Me.btnCodigo.Image = Global.cooool.My.Resources.Resources.addX128
        Me.btnCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCodigo.Location = New System.Drawing.Point(486, 183)
        Me.btnCodigo.Name = "btnCodigo"
        Me.btnCodigo.Size = New System.Drawing.Size(235, 175)
        Me.btnCodigo.TabIndex = 7
        Me.btnCodigo.Text = "INGRESAR CODIGO"
        Me.btnCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCodigo.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(558, 58)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 61)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "$0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 61)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1430, 734)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCodigo)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.DataGridCool)
        Me.Controls.Add(Me.lstTicket)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridCool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lstTicket As ListBox
    Friend WithEvents DataGridCool As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents botonUno As DataGridViewButtonColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCodigo As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
End Class
