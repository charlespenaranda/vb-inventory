Imports System.Data
Imports System.Data.SqlClient

Public Class Inventory_Class

    Public Sub InsertItems(ByVal ProductID As System.Object, ByVal ProductName As System.Object, ByVal ProductDescription As System.Object, ByVal Quantity As System.Object, ByVal Unit_Measure As System.Object, ByVal Crit_Quantity As System.Object, ByVal Price As System.Object, ByVal SellPrice As System.Object)


        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim _Auth As String = ""
        Dim Result As String = ""
        conn.Open()

        Try

            myQuery = "INSERT INTO [dbo].[Items] ([product_id],[product_name],[product_description],[quantity],[unitmeasure],[crit_qty],[price],[selling_price],[addedby],[datetimeadded],[Status])VALUES('" & ProductID & "', '" & ProductName & "','" & ProductDescription & "','" & Quantity & "','" & Unit_Measure & "','" & Crit_Quantity & "','" & Price & "','" & SellPrice & "','Admin',getDate(),'Active')"
            mycommand = New SqlCommand(myQuery, conn)
            mycommand.CommandTimeout = 0
            mycommand.ExecuteNonQuery()


        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

    End Sub

    Public Sub InsertReceipt(ByVal InvoiceID As System.Object, ByVal ProductID As System.Object, ByVal ProductName As System.Object, ByVal Quantity As System.Object, ByVal Price As System.Object, ByVal TotalPrice As System.Object, ByVal Cashtendered As System.Object)


        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim _Auth As String = ""
        Dim Result As String = ""
        conn.Open()

        Try

            myQuery = "INSERT INTO [dbo].[Temp_receipt] VALUES('" & InvoiceID & "','" & ProductID & "', '" & ProductName & "','" & Quantity & "','" & Price & "','" & Cashtendered & "','0','0','" & TotalPrice & "','Admin',getDate(),'0')"
            mycommand = New SqlCommand(myQuery, conn)
            mycommand.CommandTimeout = 0
            mycommand.ExecuteNonQuery()


        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

    End Sub

    Public Function GetProdName(ByVal ProductID As System.Object)

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim Result As String = ""

        conn.Open()
        myQuery = "Select product_name From [Inventory].[dbo].[Items] where product_id ='" & ProductID & "'"
        mycommand = New SqlCommand(myQuery, conn)
        mycommand.CommandTimeout = 0
        mycommand.ExecuteNonQuery()
        Try

            Dim reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Result = reader("product_name").ToString.Trim

            End If

        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

        Return Result

    End Function

    Public Function GetItems(ByVal ProductID As System.Object)

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim Result As String = False

        conn.Open()
        myQuery = "Select * From [Inventory].[dbo].[Items] where product_id ='" & ProductID & "'"
        mycommand = New SqlCommand(myQuery, conn)
        mycommand.CommandTimeout = 0
        mycommand.ExecuteNonQuery()
        Try

            Dim reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                Result = True

            End If

        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

        Return Result

    End Function

    Public Function GetCritItems()

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim Result As String = ""

        conn.Open()
        myQuery = "  Select count(id) as CritItems from [Inventory].[dbo].[Items] where quantity <= crit_qty"
        mycommand = New SqlCommand(myQuery, conn)
        mycommand.CommandTimeout = 0
        mycommand.ExecuteNonQuery()
        Try

            Dim reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then

                reader.Read()
                Result = reader("CritItems").ToString.Trim

            End If

        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

        Return Result

    End Function

    Public Function GetLastInvoice()

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim Result As String = ""

        conn.Open()
        myQuery = "SELECT TOP 1 SUBSTRING(Invoice_id, 13,LEN(Invoice_id)) AS SubstringResult FROM [Inventory].[dbo].[Temp_receipt] ORDER BY datetimeadded DESC"
        mycommand = New SqlCommand(myQuery, conn)
        mycommand.CommandTimeout = 0
        mycommand.ExecuteNonQuery()
        Try

            Dim reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then

                reader.Read()
                Result = reader("SubstringResult").ToString.Trim

            End If

        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

        Return Result

    End Function

    Public Function InvoiceID(ByVal Substr As System.Object)

        Dim Result As String = ""
        Dim value As Integer = Convert.ToInt32(Substr) + 1
        Dim today As DateTime = DateTime.Now
        Result = "LPNA" & today.ToString("yyyyMMdd") & value.ToString().PadLeft(4, "0"c)

        Return Result

    End Function


End Class
