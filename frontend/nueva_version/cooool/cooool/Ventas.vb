Imports Newtonsoft.Json

Public Class Ventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim api = New DBApi

        Dim url = "http://btecvi.lavin.cool:3500/api/super/articulos"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        Dim objeto = JsonConvert.DeserializeObject(response)
        Console.WriteLine(objeto(1).ToString)
        Dim objeto2 = JsonConvert.DeserializeObject(Of Articulo)(objeto(1).ToString)
        MessageBox.Show(objeto2.descripcion)
        Dim listadoNumero = 0

        While listadoNumero <= 50
            Try
                Dim objSL = JsonConvert.DeserializeObject(Of Articulo)(objeto(listadoNumero).ToString)
                ' MessageBox.Show(objSL.descripcion)
                DataGridCool.Rows.Add(New String() {objSL.codigo, objSL.nombre, objSL.cantidad, objSL.unidad, objSL.seccion, objSL.precio, "Editar"})
                ' DataGridCool.DataTable.AddRow(1, "John Doe", True)
            Catch ex As Exception
                Return
            End Try
            listadoNumero += 1
        End While
    End Sub

    Private Sub DataGridCool_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCool.CellContentClick

    End Sub

    Class Articulo
        Public Property id As String
        Public Property nombre As String
        Public Property descripcion As String

        Public Property cantidad As Double

        Public Property unidad As Integer

        Public Property codigo As String

        Public Property seccion As Integer

        Public Property precio As String
    End Class
End Class