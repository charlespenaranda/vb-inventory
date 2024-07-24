Public Class AddItems

    Dim InventoryClass As New Inventory_Class

    Private Sub AddItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ComboBox2.Items.Add("30%")
        ComboBox2.Items.Add("40%")
        ComboBox2.Items.Add("50%")
        ComboBox2.Items.Add("60%")

        ComboBox1.Items.Add("5%")
        ComboBox1.Items.Add("10%")
        ComboBox1.Items.Add("15%")
        ComboBox1.Items.Add("20%")

        ComboBox3.Items.Add("pc")
        ComboBox3.Items.Add("kg")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If TextBox_ID.Text = "" Or TextBox_Name.Text = "" Or RichTextBox_Desc.Text = "" Or TextBox_Qty.Text = "" Or ComboBox1.Text = "" Or TextBox_Price.Text = "" Then

            MsgBox("Please complete the product details")
            Return

        End If


        If InventoryClass.GetItems(TextBox_ID.Text) = True Then

            MsgBox("Product already exist")
            Return

        End If

        Dim sellprice As Long = TextBox_Price.Text
        Dim total As Long

        If ComboBox1.Text = "5%" Then

            total = sellprice * 0.05
            total = total + sellprice

        End If

        If ComboBox1.Text = "10%" Then

            total = sellprice * 0.1
            total = total + sellprice

        End If

        If ComboBox1.Text = "15%" Then

            total = sellprice * 0.15
            total = total + sellprice

        End If

        If ComboBox1.Text = "20%" Then

            total = sellprice * 0.2
            total = total + sellprice

        End If

        Dim critqty As Long = TextBox_Qty.Text
        Dim totalcrit As Long

        If ComboBox2.Text = "30%" Then

            totalcrit = critqty * 0.3
            totalcrit = totalcrit

        End If

        If ComboBox2.Text = "40%" Then

            totalcrit = critqty * 0.4
            totalcrit = totalcrit

        End If

        If ComboBox2.Text = "50%" Then

            totalcrit = critqty * 0.5
            totalcrit = totalcrit

        End If

        If ComboBox2.Text = "60%" Then

            totalcrit = critqty * 0.6
            totalcrit = totalcrit

        End If


        InventoryClass.InsertItems(TextBox_ID.Text, TextBox_Name.Text, RichTextBox_Desc.Text, TextBox_Qty.Text, ComboBox3.Text, totalcrit, TextBox_Price.Text, total)
        MsgBox("Successfully Added")

        TextBox_ID.Text = ""
        TextBox_Name.Text = ""
        RichTextBox_Desc.Text = ""
        TextBox_Qty.Text = ""
        ComboBox1.Text = ""
        TextBox_Price.Text = ""
        ComboBox2.Text = ""

    End Sub



End Class