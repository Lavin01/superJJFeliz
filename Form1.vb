Public Class Form1
    Private Sub lblCheck_Click(sender As Object, e As EventArgs)

    End Sub

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
        lsTicket.Items.Add("                                      SUPER JJ FELIZ")
        lsTicket.Items.Add("                                   Tel: 868-000-0000")
        lsTicket.Items.Add("                                RFC: GORDIS55CA1DC")
        lsTicket.Items.Add("-------------------------- TICKET ------------------------------")
    End Sub
End Class
