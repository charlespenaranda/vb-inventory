Public Class Payment

    Private _Payment As String
    Dim Receipt As New Receipt

    Public Property Payment() As String
        Get
            Return _Payment
        End Get
        Set(ByVal value As String)
            _Payment = value
        End Set
    End Property

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp

        Dim change As Decimal

        If e.KeyCode = Keys.Enter Then

            If Double.Parse(Label1.Text) <= Double.Parse(TextBox1.Text) Then
                change = Double.Parse(TextBox1.Text) - Double.Parse(Label1.Text)
                Receipt.Label1.Text = change.ToString("0.00")
                Receipt.ShowDialog()

                _Payment = "true"
                Me.Close()

            Else

                MsgBox("Money cannot be tender")

            End If

        End If

    End Sub
End Class