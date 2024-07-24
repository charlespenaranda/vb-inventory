Imports System.Data
Imports System.Data.SqlClient

Public Class LoginClass

    Private _Username As String
    Private _Auth As String

    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal value As String)
            _Username = value
        End Set
    End Property

    Public Property Auth() As String
        Get
            Return _Auth
        End Get
        Set(ByVal value As String)
            _Auth = value
        End Set
    End Property

    Public Function GetLogin(ByVal User As System.Object, ByVal Password As System.Object)

        Dim conn As New SqlConnection(connstring)
        Dim mycommand As SqlCommand
        Dim myQuery As String
        Dim Result As String = ""

        conn.Open()
        myQuery = "Select * From [Inventory].[dbo].[User] where Username ='" & User & "' and Password = '" & Password & "'"
        mycommand = New SqlCommand(myQuery, conn)
        mycommand.CommandTimeout = 0
        mycommand.ExecuteNonQuery()
        Try

            Dim reader As SqlDataReader = mycommand.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                _Auth = reader("Authentication").ToString.Trim
                _Username = reader("Username").ToString.Trim
                Result = "True"

            End If


        Catch ex As Exception

        Finally
            conn.Close()
            conn.Dispose()

        End Try

        Return Result

    End Function

End Class
