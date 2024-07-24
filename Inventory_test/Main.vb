Public Class Main

    Dim InventoryMainform As New InventoryMain
    Dim LoginClass As New LoginClass
    Dim POS As New Inventory
    Dim InvetoryClass As New Inventory_Class

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button7.Click

        InventoryMainform.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        POS.ShowDialog()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        NotificationBtn.Text = InvetoryClass.GetCritItems()
        If NotificationBtn.Text = "0" Then

            NotificationBtn.Visible = False

        Else

            NotificationBtn.Visible = True

        End If

    End Sub
End Class