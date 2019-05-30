Imports System.Data.SqlClient

Module database
    Friend cn As New SqlConnection("Data Source=SC-PC;Initial Catalog=DBbounsy;Integrated Security=True")
    Friend da As New SqlDataAdapter
    Friend cmd As New SqlCommand
    Friend dr As SqlDataReader
    Friend ds As New DataSet
    Friend sql As String = ""

    Friend Sub connnect()

    End Sub



End Module
