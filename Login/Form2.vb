Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Bem Vindo!")
        Else
            MsgBox("Tente Outra Vez!")
        End If
    End Sub
End Class