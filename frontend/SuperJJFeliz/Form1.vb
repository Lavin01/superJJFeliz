Imports System.Net
Imports Newtonsoft.Json
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Message, Title, CDefault, MyValue
        Message = "Ingresa el codigo que tiene el producto que deseas registrar"    ' Set prompt.
        Title = "REGISTRAR PRODUCTO MANUALMENTE"    ' Set title.
        CDefault = ""    ' Set default.
        ' Display message, title, and default value.
        MyValue = InputBox(Message, Title, CDefault)
        If CStr(Len(MyValue)) > 0 Then
            MsgBox("Registrate el codigo: " & Chr(13) & Chr(10) & MyValue & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "(MANZANA)")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsTicket.Items.Add("                                         SUPER JJ FELIZ")
        lsTicket.Items.Add("                                      Tel: 868-000-0000")
        lsTicket.Items.Add("                                   RFC: GORDIS55CA1DC")
        lsTicket.Items.Add("---------------------------- TICKET --------------------------------")
        Debug.WriteLine("sE CLICKEO")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim origResponse As HttpWebResponse

        Try
#Disable Warning SYSLIB0014 ' El tipo o el miembro están obsoletos
            Dim Request As HttpWebRequest = DirectCast(HttpWebRequest.Create("http://btecvi.lavin.cool:3500/api/super/articulo?codigo=do54h"), HttpWebRequest)
#Enable Warning SYSLIB0014 ' El tipo o el miembro están obsoletos
            Request.UserAgent = "Test"
            Request.Method = "GET"


            Dim Response As HttpWebResponse = Request.GetResponse
            Dim ResponseStream As System.IO.Stream = Response.GetResponseStream

            Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            Dim Data As String = StreamReader.ReadToEnd
            Try
                origResponse = DirectCast(Request.GetResponse(), HttpWebResponse)
                Dim Stream As Stream = origResponse.GetResponseStream()
                Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
                Dim str As String = sr.ReadToEnd()
                Debug.WriteLine(str)
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try

            Debug.WriteLine("Llego aqui")
            StreamReader.Close()
        Catch ex As Exception

            MsgBox("Algo salio mal")

        End Try
    End Sub
End Class
