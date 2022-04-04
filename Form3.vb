Public Class Form3
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text

        Dim str_add As String = str1 + str2
        txt3.Text = str_add
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text

        Dim str_minus As String = str1 - str2
        txt3.Text = str_minus
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text

        Dim str_multiplication As String = str1 * str2
        txt3.Text = str_multiplication
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text

        Dim str_division As String = str1 / str2
        txt3.Text = str_division
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub
End Class