Imports System.Data.SqlClient
Public Class DatabaseManage
    Public cn As New SqlConnection("Data Source=SC-PC;Initial Catalog=DBbounsy;Integrated Security=True")
    Public da As New SqlDataAdapter
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public ds As New DataSet
    Public sql As String = ""

    Public Sub connect()
        If cn.State = ConnectionState.Closed Then
            cn.Open()

        End If
    End Sub

    Public Sub Excute(sql As String)
        connect()
        cmd = New SqlCommand(sql, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SelectData(sql As String)
        connect()
        da = New SqlDataAdapter(sql, cn)
        ds.Clear()
        da.Fill(ds, "table")

    End Sub
End Class
