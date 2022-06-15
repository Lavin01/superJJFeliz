<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class todasventas
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
        Me.DataGridCool = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.botonUno = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridCool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridCool
        '
        Me.DataGridCool.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridCool.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridCool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCool.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.cantidad, Me.unidad, Me.seccion, Me.costo, Me.botonUno})
        Me.DataGridCool.Location = New System.Drawing.Point(12, 150)
        Me.DataGridCool.Name = "DataGridCool"
        Me.DataGridCool.Size = New System.Drawing.Size(776, 150)
        Me.DataGridCool.TabIndex = 5
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
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'unidad
        '
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.Name = "unidad"
        '
        'seccion
        '
        Me.seccion.HeaderText = "Seccion"
        Me.seccion.Name = "seccion"
        '
        'costo
        '
        Me.costo.HeaderText = "Precio"
        Me.costo.Name = "costo"
        Me.costo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.costo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'botonUno
        '
        Me.botonUno.HeaderText = "Editar"
        Me.botonUno.Name = "botonUno"
        '
        'todasventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridCool)
        Me.Name = "todasventas"
        Me.Text = "todasventas"
        CType(Me.DataGridCool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridCool As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents unidad As DataGridViewTextBoxColumn
    Friend WithEvents seccion As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents botonUno As DataGridViewButtonColumn
End Class
