Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Inventory

    Dim Receipt As New Receipt
    Dim InvetoryClass As New Inventory_Class
    Public Total As New Decimal
    Public Tendered As New Decimal

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Getpayment()

    End Sub

    Public Sub Getpayment()

        Dim Result As String = ""
        Dim Payment As New Payment
        Payment.Label1.Text = Label1.Text
        Payment.ShowDialog()

        Dim inputData As String = Payment.Payment()

        If inputData.Contains("true") Then

            Tendered = Decimal.Parse(Payment.TextBox1.Text)
            Deductquantity()
            PrintReceipt()
            NewOrder()

        End If

    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)


        Dim total_price As Decimal = 0

        Dim font As New Font("Courier New", 12)
        Dim fonts As New Font("Arial", 13)
        Dim fontHeader As New Font("Arial", 17)
        Dim lineHeight As Integer = font.Height + 5
        Dim xPos As Integer = 50
        Dim yPos As Integer = 50

        Dim brush As New SolidBrush(Color.Black)

        Dim columnWidth1 As Integer = 100
        Dim columnWidth2 As Integer = 150
        Dim columnWidth3 As Integer = 200
        Dim columnWidth4 As Integer = 120

        Dim xPos1 As Integer = xPos
        Dim xPos2 As Integer = xPos1 + columnWidth1
        Dim xPos3 As Integer = xPos2 + columnWidth2
        Dim xPos4 As Integer = xPos3 + columnWidth3

        Dim text1 As String = "Column 1"
        Dim text2 As String = "Column 2"
        Dim text3 As String = "Column 3"
        Dim text4 As String = "Column 4"


        e.Graphics.DrawString("LUCKY P AND A HARDWARE", fontHeader, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString("BARANGAY BACONG ILAYA", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString("VAT REG TIN 000-000-000-000000", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString("POS RC-PEN QUICK SERVICE IDF 10001 V1.0", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 2
        e.Graphics.DrawString("THIS SERVES AS YOUR OFFICIAL RECEIPT", fonts, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 2
        e.Graphics.DrawString("RECEIPT NO. " + InvetoryClass.InvoiceID(InvetoryClass.GetLastInvoice() - 1), font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString("CASHIER ADMIN", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString("==================================================", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 2

        For i As Integer = 0 To CartGrid.Rows.Count - 2

            Dim rect1 As New Rectangle(xPos1, yPos, columnWidth1, Height)
            Dim rect2 As New Rectangle(xPos2, yPos, columnWidth2, Height)
            Dim rect3 As New Rectangle(xPos3, yPos, columnWidth3, Height)
            Dim rect4 As New Rectangle(xPos4, yPos, columnWidth4, Height)

            Dim MultText As String = " x "

            Dim itemText As String = CartGrid.Rows(i).Cells(0).Value.ToString()
            Dim descText As String = CartGrid.Rows(i).Cells(1).Value.ToString()
            total_price += Decimal.Parse(CartGrid.Rows(i).Cells(4).Value).ToString("0.00")
            Dim priceText As String = Decimal.Parse(CartGrid.Rows(i).Cells(4).Value).ToString("0.00")
            Dim QtyText As String = CartGrid.Rows(i).Cells(2).Value.ToString() + " " + CartGrid.Rows(i).Cells(3).Value.ToString()

            e.Graphics.DrawString(itemText, font, brush, rect1)
            e.Graphics.DrawString(descText, font, brush, rect2)
            e.Graphics.DrawString(MultText & " " & QtyText, font, brush, rect3)
            e.Graphics.DrawString(priceText, font, brush, rect4)

            yPos += lineHeight * 1

        Next

        yPos += lineHeight * 1
        e.Graphics.DrawString("==================================================", font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1

        Dim change As Decimal = Tendered - total_price

        Dim totalText As String = "Total: "
        Dim totalLineText As String = String.Format("{0,-20}{1,10}", totalText, total_price.ToString("0.00"))
        Dim tenderText As String = "Cash Tendered: "
        Dim tenderLineText As String = String.Format("{0,-20}{1,10}", tenderText, Tendered.ToString("0.00"))
        Dim changeText As String = "Change: "
        Dim changeLineText As String = String.Format("{0,-20}{1,10}", changeText, change.ToString("0.00"))

        e.Graphics.DrawString(totalLineText, font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString(tenderLineText, font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 1
        e.Graphics.DrawString(changeLineText, font, Brushes.Black, xPos, yPos)
        yPos += lineHeight * 2

        Dim footerText As String = "Thank you for your purchase!"
        e.Graphics.DrawString(footerText, font, Brushes.Black, xPos, yPos)


    End Sub

    Public Sub PrintReceipt()

        Dim printDocument As New PrintDocument()
        AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage

        Dim printDialog As New PrintDialog()
        printDialog.Document = printDocument

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then

            searchItems(TextBox1.Text)
            TextBox2.Focus()
            e.Handled = True

        End If

    End Sub

    Private Sub Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button1.Text = "&Delete"
        Button2.Text = "&Add"
        Button6.Text = "&Payment"
        Button4.Text = "&New Order"
        Button5.Text = "&Reprint"
        viewItems()

    End Sub

    Public Sub searchItems(ByVal ProductName As System.Object)

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        conn.Open()

        Try

            myQuery = "SELECT [product_id] as BARCODE ,[product_name] as PRODUCT,[product_description] as DESCRIPTION,[unitmeasure] as UNITMEASURE,[quantity] as QUANTITY,[selling_price] as SELLINGPRICE,[Status] FROM [Inventory].[dbo].[Items] where product_name like ('%" & ProductName & "%') OR product_id like ('%" & ProductName & "%')"
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

    Public Sub Deductquantity()

        Dim invoice As String = InvetoryClass.GetLastInvoice()

        For i As Integer = 0 To CartGrid.Rows.Count - 2

            InvetoryClass.InsertReceipt(InvetoryClass.InvoiceID(invoice), CartGrid.Rows(i).Cells(0).Value.ToString(), InvetoryClass.GetProdName(CartGrid.Rows(i).Cells(0).Value.ToString()), CartGrid.Rows(i).Cells(2).Value.ToString(), CartGrid.Rows(i).Cells(4).Value.ToString(), Label1.Text, Tendered)
            lessItems(CartGrid.Rows(i).Cells(0).Value.ToString(), CartGrid.Rows(i).Cells(2).Value.ToString())

        Next

    End Sub

    Public Sub lessItems(ByVal ProductID As System.Object, ByVal Quantity As System.Object)


        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        conn.Open()

        Try

            myQuery = "UPDATE Items SET Quantity = Quantity - '" & Quantity & "' Where product_id = '" & ProductID & "'"
            mycommand = New SqlCommand(myQuery, conn)
            mycommand.CommandTimeout = 0
            mycommand.ExecuteNonQuery()

            conn.Close()

        Catch ex As Exception


        End Try

    End Sub

    Public Sub viewItems()


        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        conn.Open()

        Try

            myQuery = "SELECT [product_id] as BARCODE ,[product_name] as PRODUCT,[product_description] as DESCRIPTION,[unitmeasure] as UNITMEASURE,[quantity] as QUANTITY,[selling_price] as SELLINGPRICE,[Status] as STATUS FROM [Inventory].[dbo].[Items]"
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

    Public Sub addItems()

        If TextBox1.Text = "" Or TextBox2.Text = "" Then

            MsgBox("Please Input Value")
            Return

        End If

        Dim curr_price As Decimal = TextBox2.Text * Decimal.Parse(DataGridView1.CurrentRow.Cells(5).Value).ToString("0.00")
        Dim curr_total As Decimal = Total + curr_price

        CartGrid.Rows.Add(New String() {DataGridView1.CurrentRow.Cells(0).Value.ToString(), DataGridView1.CurrentRow.Cells(1).Value.ToString(), TextBox2.Text, DataGridView1.CurrentRow.Cells(3).Value.ToString(), curr_price.ToString("0.00")})

        Total = curr_total
        Label1.Text = Total.ToString("0.00")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If DataGridView1.CurrentRow.Cells(3).Value.ToString() = "kg" Then

            Dim result As DialogResult = MessageBox.Show("Item unit measure is KG, are you sure the measure is " + TextBox2.Text + "kg ?", _
                          "Title", _
                          MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                addItems()

            End If

        Else

            addItems()

        End If

    End Sub

    Public Sub ClearTextBox()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()

    End Sub

    Public Sub NewOrder()

        Label1.Text = "0.00"
        Total = Decimal.Parse(Label1.Text)
        TextBox1.Text = ""
        TextBox2.Text = ""
        CartGrid.Rows.Clear()
        viewItems()
        TextBox1.Focus()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        NewOrder()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim less As Decimal = 0.0

        If CartGrid.RowCount - 2 <> -1 Then

            less = Decimal.Parse(Label1.Text) - Decimal.Parse(CartGrid.CurrentRow.Cells(4).Value)
            Label1.Text = less.ToString("0.00")
            Total = Decimal.Parse(Label1.Text)
            CartGrid.Rows.RemoveAt(CartGrid.RowCount - 2)

        End If

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown

        If e.KeyCode = Keys.Enter Then

            If DataGridView1.RowCount = 0 Then

                Return
            End If

            If DataGridView1.CurrentRow.Cells(3).Value.ToString() = "kg" Then

                Dim result As DialogResult = MessageBox.Show("Item unit measure is KG, are you sure the measure is " + TextBox2.Text + "kg ?", _
                              "Title", _
                              MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then
                    addItems()
                    viewItems()
                    ClearTextBox()
                    e.Handled = True

                Else

                    ClearTextBox()
                    viewItems()

                End If

            Else

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this in your cart ?", _
              "Title", _
              MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then
                    addItems()
                    viewItems()
                    ClearTextBox()
                    e.Handled = True

                Else

                    ClearTextBox()
                    viewItems()

                End If

            End If

        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If

    End Sub

End Class