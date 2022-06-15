Imports Newtonsoft.Json



Public Class Form1
    Dim valorItems = ""
    Dim valorPrecio As String = ""
    Dim PrecioGeneral As Double = 0.0
    Dim valorCodigo = ""
    Dim valorIndex = ""
    Dim intIndex = 0

    Function ResetearParametros() As String
        LoadList()
        lstActividad.Items.Clear()

        valorItems = ""
        valorPrecio = ""
        valorCodigo = ""
        PrecioGeneral = 0.0

        lblTotal.Text = "$0"
        Return 0
    End Function

    Function LoadList() As String
        lstTicket.Items.Clear()
        lstTicket.Items.Add("                                         SUPER JJ FELIZ")
        lstTicket.Items.Add("                                        Tel: 868-000-0000")
        lstTicket.Items.Add("                                    RFC: SUPRJSJ5FAELI")
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

        If objeto IsNot Nothing Then
            Select Case tipo
                Case "nombre"
                    valorPrecio += objeto.precio + ","
                    valorItems += objeto.nombre + ","
                    valorCodigo += objeto.codigo + ","
                    ' 
                    Dim minicalculo = Val(intIndex) + 1
                    intIndex += 1

                    valorIndex += minicalculo.ToString + ","

                    ActualizarDatos()
                    ActualizarActividad(1, objeto)
                    Return objeto.nombre
                Case Else
                    MsgBox("Otro")
            End Select
        Else
            MsgBox("Codigo no validado")
        End If
        Return 0
    End Function
    Function ApiGuardarVenta() As String
        Dim api = New DBApi

        Dim url = "http://localhost:3500/api/super/articulo/venta"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim datosVenta = New Venta()
        datosVenta.pv = valorItems
        datosVenta.pc = valorPrecio
        datosVenta.vp = "Fulanito de Tal"
        datosVenta.codigo = valorCodigo

        Dim solicitud = api.Post(url, headers, parametros, datosVenta)
        Dim objeto = JsonConvert.DeserializeObject(Of respuestaBasica)(solicitud)
        If objeto.status > 300 Then
            MsgBox("Lo sentimos, se presento un error")
        End If
        If objeto.status > 390 Then
            MsgBox("No se selecciono la suficiente informacion")
        End If

        If objeto.status = 201 Then
            MsgBox("Venta registrada CORRECTAMENTE")
        End If
        Console.WriteLine(objeto.status)
        Return 0
    End Function

    Function ActualizarDatos() As String
        Dim testArray() As String = Split(valorItems, ",")
        Dim testPrecio() As String = Split(valorPrecio, ",")
        Console.WriteLine(testArray(0))
        LoadList()

        PrecioGeneral = 0.0

        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lstTicket.Items.Add(testArray(i) + " (1)   -   $" + testPrecio(i))
                Console.WriteLine(PrecioGeneral)

                PrecioGeneral += Val(testPrecio(i))
                lblTotal.Text = "$" + PrecioGeneral.ToString

                Console.WriteLine(testArray(i))
            End If
        Next
        lstTicket.Items.Add("")
        lstTicket.Items.Add("")
        lstTicket.Items.Add("********** TOTAL A PAGAR **********")
        lstTicket.Items.Add("$" + PrecioGeneral.ToString + " pesos")
        Return 0
    End Function

    Function ActualizarActividad(tipoActualizacion As String, accion As Object) As String
        lstActividad.Items.Clear()

        Select Case tipoActualizacion
            Case 1
                lstActividad.Items.Add("*** PRODUCTO AGREGADO ***")
                lstActividad.Items.Add("")
                lstActividad.Items.Add("- - - Nombre del producto:")
                lstActividad.Items.Add(accion.nombre)
                lstActividad.Items.Add("")
                lstActividad.Items.Add("- - - Precio del producto:")
                lstActividad.Items.Add("$" + accion.precio)
                lstActividad.Items.Add("")
                lstActividad.Items.Add("- - - Codigo del producto:")
                lstActividad.Items.Add(accion.codigo)
                lstActividad.Items.Add("")
                lstActividad.Items.Add("- - - Descripcion del producto:")
                lstActividad.Items.Add(accion.descripcion)
            Case Else
                MsgBox("Otro")
        End Select
        Return 0
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstTicket.Items.Add("                                         SUPER JJ FELIZ")
        lstTicket.Items.Add("                                        Tel: 868-000-0000")
        lstTicket.Items.Add("                                    RFC: SUPRJSJ5FAELI")
        lstTicket.Items.Add("------------------------------------------------ TICKET -------------------------------------------------------")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim api = New DBApi

        Dim url = "http://btecvi.lavin.cool:3500/api/super/articulo?codigo=do54h"
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)

        Dim response = api.MGet(url, headers, parametros)

        Dim objeto = JsonConvert.DeserializeObject(Of Articulo)(response)

        MessageBox.Show("Articulo id: " + objeto.id + " // Nombre: " + objeto.nombre + " ----- Descripcion: " + objeto.descripcion)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ingresarCodigo_Manualmente(sender As Object, e As EventArgs) Handles btnCodigo.Click
        Dim Message, Title, CDefault, MiCodigo
        Message = "Ingresa el codigo que tiene el producto que deseas registrar"    ' Set prompt.
        Title = "REGISTRAR PRODUCTO MANUALMENTE"    ' Set title.
        CDefault = ""    ' Set default.
        ' Display message, title, and default value.
        MiCodigo = InputBox(Message, Title, CDefault)
        If CStr(Len(MiCodigo)) > 0 Then
            ApiUNProducto(MiCodigo, "nombre")
        End If
    End Sub

    Private Sub ProcesarCompra(sender As Object, e As EventArgs) Handles btnProcesar.Click
        ApiGuardarVenta()
        ResetearParametros()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub lstTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTicket.SelectedIndexChanged
        Console.WriteLine(lstTicket.SelectedIndex)
        Console.WriteLine(lstTicket.SelectedItem)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testArray() As String = Split(valorItems, ",")
        Dim testPrecio() As String = Split(valorPrecio, ",")
        Dim testIndex() As String = Split(valorIndex, ",")

        Dim valorTicketSeleccionado = (lstTicket.SelectedIndex - 3)

        Array.Clear(testPrecio, valorTicketSeleccionado, 1)
        PrecioGeneral = 0.0

        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                lstTicket.Items.Add(testArray(i) + " (1)   -   $" + testPrecio(i))
                Console.WriteLine(PrecioGeneral)

                PrecioGeneral += Val(testPrecio(i))
                lblTotal.Text = "$" + PrecioGeneral.ToString

                Console.WriteLine(testArray(i))
            End If
        Next


        Console.WriteLine("Valor TESTINDEX: " + testIndex.Length.ToString)
        Console.WriteLine("Valor seleccionado: " + valorTicketSeleccionado.ToString)
        Console.WriteLine("Valor testIndex object: " + valorIndex.ToString)

        'Array.Clear(testArray, valorTicketSeleccionado, 1)
        'Array.Clear(testArray)
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

Class Venta
    Public Property pv As String
    Public Property pc As String

    Public Property vp As String

    Public Property codigo As String
End Class

Class respuestaBasica
    Public Property status As Integer

End Class