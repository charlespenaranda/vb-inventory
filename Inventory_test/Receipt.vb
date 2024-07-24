Public Class Receipt

    Private Sub Receipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Close()

        End If

    End Sub

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

End Class