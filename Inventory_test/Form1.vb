Public Class Login

    Dim LoginClass As New LoginClass
    Dim Mainform As New Main

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim auth As String = LoginClass.GetLogin(TextBox_User.Text, TextBox_Pass.Text)

        If auth = "True" Then

            Mainform.Label1.Text = LoginClass.Auth()
            Mainform.Show()
            Me.Hide()

        Else

            MsgBox("User does not exist")

        End If


    End Sub

End Class
