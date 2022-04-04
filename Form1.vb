Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterationToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim message As String

        message = "This program is design by MUHAMMAD AIZAT BIN AMIZI, 10DDT20F1021, JTMK "

        MessageBox.Show(message, "Verification", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
