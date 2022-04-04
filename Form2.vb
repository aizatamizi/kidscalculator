Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ayam1 As String = tx1.Text
        Dim ayam2 As String = tx2.Text

        tb3.Text = "My Name Is : " + ayam1 + Environment.NewLine
        tb3.Text = "My Age Is : " + ayam2 + Environment.NewLine


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.ShowDialog()
        BackColor = ColorDialog1.Color


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class