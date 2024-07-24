Imports System.Data
Imports System.Data.SqlClient

Public Class InventoryMain


    Dim AddItems As New AddItems
    Dim InventoryClass As New Inventory_Class

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp


        searchItems(TextBox1.Text)
        critItems()

    End Sub

    Private Sub InventoryMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        viewItems()
        critItems()

    End Sub

    Public Sub critItems()

        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            Dim qty As Integer = DataGridView1.Rows(i).Cells(3).Value.ToString
            Dim crtqty As Integer = DataGridView1.Rows(i).Cells(4).Value.ToString

            If qty <= crtqty Then

                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

            End If

        Next

    End Sub

    Public Sub viewItems()


        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        conn.Open()

        Try

            myQuery = "SELECT [product_id] as BARCODE ,[product_name] as PRODUCT,[product_description] as DESCRIPTION,[quantity] as QUANTITY,[crit_qty] as CRITICALQTY,[price] as PRICE,[selling_price] as SELLINGPRICE,[Status] as STATUS FROM [Inventory].[dbo].[Items]"
            mycommand = New SqlCommand(myQuery, conn)
            Dim dataadapter As New SqlDataAdapter(mycommand)
            Dim table As New DataSet()

            dataadapter.Fill(table, "Items")
            conn.Close()
            DataGridView1.DataSource = table
            DataGridView1.DataMember = "Items"

        Catch ex As Exception


        End Try

    End Sub

    Public Sub searchItems(ByVal ProductName As System.Object)

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        conn.Open()

        Try

            myQuery = "SELECT [product_id] as BARCODE ,[product_name] as PRODUCT,[product_description] as DESCRIPTION,[quantity] as QUANTITY,[crit_qty] as CRITICALQTY,[price] as PRICE,[selling_price] as SELLINGPRICE,[Status] as STATUS FROM [Inventory].[dbo].[Items] where product_name like ('%" & ProductName & "%')"
            mycommand = New SqlCommand(myQuery, conn)
            Dim dataadapter As New SqlDataAdapter(mycommand)
            Dim table As New DataSet()

            dataadapter.Fill(table, "Items")
            conn.Close()
            DataGridView1.DataSource = table
            DataGridView1.DataMember = "Items"

        Catch ex As Exception


        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        viewItems()
        critItems()

    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click

        AddItems.ShowDialog()

    End Sub
End Class