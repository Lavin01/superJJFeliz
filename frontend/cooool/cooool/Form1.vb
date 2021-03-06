Imports Newtonsoft.Json

Public Class Form1
    Dim valorItems = ""
    Dim valorPrecio As String = ""
    Dim PrecioGeneral As Double = 0.0

    Function LoadList() As String
        lstTicket.Items.Clear()
        lstTicket.Items.Add("                                         SUPER JJ FELIZ")
        lstTicket.Items.Add("                                      Tel: 868-000-0000")
        lstTicket.Items.Add("                                   RFC: GORDIS55CA1DC")
        lstTicket.Items.Add("------------------------------------------------ TICKET -------------------------------------------------------")
        Return 0
    End Function
    Function ApiUNProducto(ByVal codigo As String, ByVal tipo As String) As String
        Dim api = New DBApi

        Dim url = "http://btecvi.lavin.cool:3500/api/super/articulo?codigo=" + codigo
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)

        Dim objeto = JsonConvert.DeserializeObject(Of Articulo)(response)

        If objeto.id Then
            Select Case tipo
                Case "nombre"
                    valorPrecio += "," + objeto.precio
                    valorItems += "," + objeto.nombre
                    ActualizarDatos()
                    Return objeto.nombre
                Case Else
                    MsgBox("Otro")
            End Select
        End If
        Return 0
    End Function

    Function ActualizarDatos() As String
        Dim testArray() As String = Split(valorItems, ",")
        Dim testPrecio() As String = Split(valorPrecio, ",")

        LoadList()

        PrecioGeneral = 0.0

        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lstTicket.Items.Add(testArray(i) + " - " + testPrecio(i))
                Console.WriteLine(PrecioGeneral)

                PrecioGeneral += Val(testPrecio(i))
                lblTotal.Text = "$" + PrecioGeneral.ToString

                Console.WriteLine(testArray(i))
            End If
        Next
        Return 0
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstTicket.Items.Add("                                         SUPER JJ FELIZ")
        lstTicket.Items.Add("                                        Tel: 868-000-0000")
        lstTicket.Items.Add("                                    RFC: GORDIS55CA1DC")
        lstTicket.Items.Add("------------------------------------------------ TICKET -------------------------------------------------------")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New DBApi

        Dim url = "http://btecvi.lavin.cool:3500/api/super/articulo?codigo=do54h"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)

        Dim objeto = JsonConvert.DeserializeObject(Of Articulo)(response)

        MessageBox.Show("Articulo id: " + objeto.id + " // Nombre: " + objeto.nombre + " ----- Descripcion: " + objeto.descripcion)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim api = New DBApi

        Dim url = "http://btecvi.lavin.cool:3500/api/super/articulos"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)
        MsgBox(response(2))
        Console.WriteLine(response)
        Console.WriteLine("COOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL")

        Console.WriteLine(response)
        Console.WriteLine("COOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL")

        MsgBox(response(2))
        Dim objeto = JsonConvert.DeserializeObject(response)
        Console.WriteLine(objeto(1).ToString)
        Dim objeto2 = JsonConvert.DeserializeObject(Of Articulo)(objeto(1).ToString)
        MessageBox.Show(objeto2.descripcion)
        Console.WriteLine(objeto(1))
        Dim listadoNumero = 0
        ' objSL = El Objeto Seleccionado del Listado
        lstTicket.Items.Clear()

        While listadoNumero <= 50
            Try
                Dim objSL = JsonConvert.DeserializeObject(Of Articulo)(objeto(listadoNumero).ToString)
                ' MessageBox.Show(objSL.descripcion)
                lstTicket.Items.Add(objSL.descripcion)
                DataGridCool.Rows.Add(New String() {objSL.id, objSL.descripcion, objSL.nombre, "Editar"})
                ' DataGridCool.DataTable.AddRow(1, "John Doe", True)
            Catch ex As Exception
                Return
            End Try
            listadoNumero += 1
        End While
    End Sub

    Private Sub ingresarCodigo_Manualmente(sender As Object, e As EventArgs) Handles btnCodigo.Click
        Dim Message, Title, CDefault, MiCodigo
        Message = "Ingresa el codigo que tiene el producto que deseas registrar"    ' Set prompt.
        Title = "REGISTRAR PRODUCTO MANUALMENTE"    ' Set title.
        CDefault = ""    ' Set default.
        ' Display message, title, and default value.
        MiCodigo = InputBox(Message, Title, CDefault)
        If CStr(Len(MiCodigo)) > 0 Then
            'MsgBox(ApiUNProducto(MiCodigo, "nombre"))
            ApiUNProducto(MiCodigo, "nombre")
            'MsgBox("Registrate el codigo: " & Chr(13) & Chr(10) & MiCodigo & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "(MANZANA)")
        End If
    End Sub
End Class

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